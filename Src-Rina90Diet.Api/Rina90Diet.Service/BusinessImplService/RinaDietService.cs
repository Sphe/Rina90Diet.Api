﻿using AutoMapper;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Rina90Diet.Data.FullDomain.Infrastructure;
using Rina90Diet.Dto;
using Rina90Diet.Front.ApiWeb;
using Rina90Diet.Model.FullDomain;
using Rina90Diet.Service.BusinessImplService.Contract;
using Rina90Diet.Service.Contract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rina90Diet.Service.BusinessImplService
{
    public class RinaDietService : IRinaDietService
    {
        private readonly ILogger<RinaDietService> _logger;

        private readonly IDbContextService _dbContext;
        private readonly IGenericCrudService<RinaCustomerProfile, Customerprofile> _genService;
        private readonly IGenericCrudService<CustomerWeightEntry, Customerweightentry> _weightEntryService;
        private readonly IRina90DietDbFullDomainUnitOfWork _unitOfWork;

        private int _numberRinaDay = 90;
        private Random _random;

        private IMapper _mapper;

        public RinaDietService(
            ILogger<RinaDietService> logger,
            IGenericCrudService<RinaCustomerProfile, Customerprofile> genService,
            IGenericCrudService<CustomerWeightEntry, Customerweightentry> weightEntryService,
            IDbContextService dbContext,
            IRina90DietDbFullDomainUnitOfWork unitOfWork,
            MapperConfiguration mapperConfiguration)
        {
            _logger = logger;

            _genService = genService;
            _weightEntryService = weightEntryService;

            _dbContext = dbContext;
            _unitOfWork = unitOfWork;

            _mapper = mapperConfiguration.CreateMapper();

            _random = new Random();
        }

        public async Task<RinaCustomerProfile> GetProfileByCustomerProfileId(string customerProfileId)
        {

            var u1 = await _genService.GetSingleByPredicateAsync((a) => a.Customerprofileid.ToString() == customerProfileId);

            var rinaSession = CreateDiet(u1.StartDate, u1.EndDate, u1.IsWaterDay);

            var lstWeightEntries = await _weightEntryService.GetListByPredicateAsync((a) => a.Customerprofileid.ToString() == u1.CustomerProfileId);
            var grp1 = lstWeightEntries.GroupBy(x => x.TimeStamp.ToString("dd-MM-yyyy")).ToList();
            u1.EntryHistoryList = grp1.Select(x1 => x1.Last()).OrderBy(x1 => x1.TimeStamp).ToList();
            u1.AssociatedSession = rinaSession;

            return u1;

        }

        public async Task<RinaCustomerProfile> GetProfileByCustomerId(string customerId)
        {

            var u1List = await _genService.GetListByPredicateAsync((a) => a.Userid.ToString() == customerId && a.Activated == true);
            RinaCustomerProfile u1 = null;

            if (u1List != null && u1List.Count > 0)
            {
                u1 = u1List.First();
            }
            else
            {
                var u1L2 = await _genService.GetListByPredicateAsync((a) => a.Userid.ToString() == customerId);
                if (u1L2 != null && u1L2.Count > 0)
                {
                    u1 = u1L2.First();
                }
                else
                {
                    throw new Exception("No profile for this user !");
                }
            }

            var rinaSession = CreateDiet(u1.StartDate, u1.EndDate, u1.IsWaterDay);

            var lstWeightEntries = await _weightEntryService.GetListByPredicateAsync((a) => a.Customerprofileid.ToString() == u1.CustomerProfileId);
            var grp1 = lstWeightEntries.GroupBy(x => x.TimeStamp.ToString("dd-MM-yyyy")).ToList();
            u1.EntryHistoryList = grp1.Select(x1 => x1.Last()).OrderBy(x1 => x1.TimeStamp).ToList();
            u1.AssociatedSession = rinaSession;

            return u1;

        }

        public async Task<RinaCustomerProfile> ActivateProfileById(string customerProfileId)
        {
            var cp = await _genService.GetSingleByPredicateAsync((a) => a.Customerprofileid.ToString() == customerProfileId);

            var cpListForCustomer = await _genService.GetListByPredicateAsync((a) => a.Userid.ToString() == cp.CustomerId);
            
            var now = DateTime.UtcNow;

            foreach (var cp1 in cpListForCustomer)
            {
                cp1.Modifiedon = now;
                cp1.Activated = false;

                var u1 = await _genService.UpdateAsync(cp1, (a) => a.Customerprofileid.ToString() == cp1.CustomerProfileId);
            }

            cp.Activated = true;
            cp.Modifiedon = now;

            var a1 = await _genService.UpdateAsync(cp, (a) => a.Customerprofileid.ToString() == cp.CustomerProfileId);

            var errors = await _unitOfWork.CommitHandledAsync();

            if (!errors)
            {
                _logger.LogError($"Can't UpdateProfile !");
            }

            return a1;
        }

        public async Task<List<RinaCustomerProfile>> ListProfileByCustomerId(string customerId)
        {
            var cpListForCustomer = await _genService.GetListByPredicateAsync((a) => a.Userid.ToString() == customerId && a.Deleted != true);

            return cpListForCustomer;
        }

        public async Task DeleteCustomerProfileByProfileId(string customerProfileId)
        {
            var rcp1 = await GetProfileByCustomerProfileId(customerProfileId);

            rcp1.Deleted = true;
            
            await _genService.UpdateAsync(rcp1, x1 => x1.Customerprofileid.ToString() == rcp1.CustomerProfileId);
            var errors2 = await _unitOfWork.CommitHandledAsync();

            if (!errors2)
            {
                _logger.LogError($"Can't Update Profile ! { JsonConvert.SerializeObject(rcp1, Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore })} ");
            }
        }

        public async Task<RinaCustomerStatistic> GetCustomerStatistic(string customerId)
        {

            var u1List = await _genService.GetListByPredicateAsync((a) => a.Userid.ToString() == customerId && a.Activated == true);

            var u1 = u1List.FirstOrDefault();

            if (u1 == null)
            {
                u1 = await _genService.GetSingleByPredicateAsync((a) => a.Userid.ToString() == customerId);
            }

            var rinaSession = CreateDiet(u1.StartDate, u1.EndDate, u1.IsWaterDay);

            var lstWeightEntries = await _weightEntryService.GetListByPredicateAsync((a) => a.Customerprofileid.ToString() == u1.CustomerProfileId);

            u1.EntryHistoryList = lstWeightEntries;
            u1.AssociatedSession = rinaSession;

            var stat = new RinaCustomerStatistic();

            var listStats1 = new List<RinaCustomerStatisticDay>();

            var linearTheoricKgLossPerDay = Math.Round((decimal)15 / u1.TotalDietDays, 2);

            decimal sumLossFromStart = 0;

            u1.AssociatedSession.DaysListed.ForEach(a1 =>
            {
                var ff1 = lstWeightEntries.FirstOrDefault(x1 => x1.IndexDay == a1.DayNumber);

                listStats1.Add(new RinaCustomerStatisticDay()
                {

                    IndexDay = a1.DayNumber,
                    WeightInKg = ff1 != null ? (decimal?)ff1.WeightInKg : null,
                    TimeStamp = ff1 != null ? ff1.TimeStamp : a1.Date,

                    TheoricWeightInKg = u1.InitialWeight - sumLossFromStart
                    
                });

                sumLossFromStart = sumLossFromStart + linearTheoricKgLossPerDay;
            });

            for (var i1 = 0; i1 < listStats1.Count; i1++)
            {
                if (i1 != 0)
                {
                    if (listStats1[i1].WeightInKg.HasValue)
                    {
                        listStats1[i1].CurrentRealLossDifference = listStats1[i1].WeightInKg.Value - listStats1[i1].TheoricWeightInKg;

                        var labelRating = "NotAvailable";

                        if (Math.Abs(listStats1[i1].CurrentRealLossDifference.Value) < (decimal)0.5)
                        {
                            labelRating = "OnTrack";
                        }
                        else if (listStats1[i1].CurrentRealLossDifference.Value < (decimal)-1)
                        {
                            labelRating = "Outperform";
                        }
                        else if(listStats1[i1].CurrentRealLossDifference.Value < (decimal)-0.5)
                        {
                            labelRating = "Green";
                        }
                        else if (listStats1[i1].CurrentRealLossDifference.Value > (decimal)1)
                        {
                            labelRating = "Danger";
                        }
                        else if(listStats1[i1].CurrentRealLossDifference.Value > (decimal)0.5)
                        {
                            labelRating = "Red";
                        }


                        listStats1[i1].CurrentRatingInString = labelRating;
                    }
                }
            }

            stat.CustomerProfile = u1;
            stat.PerDayList = listStats1;

            return stat;

        }

        public async Task<RinaCustomerProfile> CreateProfile(
            string customerId, 
            decimal weightInKg, 
            decimal heightInM, 
            DateTime? startDate, 
            DateTime? endDate, 
            bool? waterDay)
        {
            var rinaSession = CreateDiet(startDate, endDate, waterDay);

            var imc = CalculateImc(weightInKg, heightInM);
            var goal = weightInKg - 15;

            var custProfile = new RinaCustomerProfile();

            custProfile.TotalDietDays = 90;
            custProfile.StartDate = rinaSession.StartDate;
            custProfile.EndDate = rinaSession.EndDate;

            custProfile.CustomerId = customerId;

            custProfile.InitialWeight = weightInKg;
            custProfile.CurrentWeight = weightInKg;
            custProfile.TargetWeight = goal;

            custProfile.HeightInM = heightInM;

            custProfile.InitialImc = imc;
            custProfile.CurrentImc = imc;
            custProfile.TargetImc = CalculateImc(goal, heightInM);

            custProfile.IsWaterDay = waterDay.HasValue ? waterDay.Value : false;

            custProfile.AssociatedSession = rinaSession;
            
            var now = DateTime.UtcNow;
            
            var u1 = await _genService.CreateAsync(custProfile, (a) => a.Customerprofileid.ToString() == custProfile.CustomerProfileId);

            var errors = await _unitOfWork.CommitHandledAsync();

            if (!errors)
            {
                _logger.LogError($"Can't CreateProfile ! { JsonConvert.SerializeObject(custProfile, Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore })} ");
            }
            
            return u1;
        }

        private decimal CalculateImc(decimal weightInKg, decimal heightInM)
        {
            var imc = Math.Round(weightInKg / (heightInM * heightInM), 2);
            return imc;
        }

        public async Task<CustomerWeightEntry> AddWeight(string customerId, DateTime timestamp, decimal weightInKg)
        {
            if (weightInKg == 0)
            {
                throw new Exception("Bad weight");
            }
            
            var now = DateTime.UtcNow;

            var profile = await GetProfileByCustomerId(customerId);

            if (profile != null)
            {
                var idxDay = 0;
                    
                var cursDay =
                    profile.AssociatedSession.DaysListed
                    .Where(x1 => x1.Date.Day == timestamp.Day
                    && x1.Date.Month == timestamp.Month
                    && x1.Date.Year == timestamp.Year).FirstOrDefault();

                if (cursDay != null)
                {
                    idxDay = cursDay.DayNumber;
                }
                    
                var e1 = new CustomerWeightEntry()
                {
                    CustomerProfileId = profile.CustomerProfileId,
                    IndexDay = idxDay,
                    TimeStamp = timestamp,
                    WeightInKg = weightInKg,
                    Createdby = customerId,
                    Modifiedby = customerId,
                    Createdon = now,
                    Modifiedon = now
                };

                var u1 = await _weightEntryService.CreateAsync(e1, (a) => a.Customerprofileid.ToString() == e1.CustomerProfileId);

                var errors = await _unitOfWork.CommitHandledAsync();

                if (!errors)
                {
                    _logger.LogError($"Can't AddWeight ! { JsonConvert.SerializeObject(e1, Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore })} ");
                }

                var lstWeight = await _weightEntryService.GetListByPredicateAsync(x1 => x1.Customerprofileid.Value.ToString() == profile.CustomerProfileId);

                var profileNew = await GetProfileByCustomerId(customerId);
                var fd1 = lstWeight.OrderByDescending(x1 => x1.TimeStamp).FirstOrDefault();

                if (fd1 != null)
                {
                    profileNew.CurrentWeight = fd1.WeightInKg;
                }
                else
                {
                    profileNew.CurrentWeight = profileNew.InitialWeight;
                }
    
                profileNew.CurrentImc = CalculateImc(profileNew.CurrentWeight, profileNew.HeightInM);
                profileNew.Modifiedon = DateTime.Now;

                await _genService.UpdateAsync(profileNew, x1 => x1.Customerprofileid.ToString() == profileNew.CustomerProfileId);
                var errors2 = await _unitOfWork.CommitHandledAsync();

                if (!errors2)
                {
                    _logger.LogError($"Can't Update Profile ! { JsonConvert.SerializeObject(e1, Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore })} ");
                }

                return u1;
            }

            return null;
        }

        public RinaSession CreateDiet(DateTime? startDate, DateTime? endDate, bool? waterDay)
        {
            var now1 = DateTime.Now;

            DateTime startDateCurrent = now1;
            DateTime endDateCurrent = now1;

            if (endDate.HasValue)
            {
                endDateCurrent = endDate.Value;
                startDateCurrent = endDateCurrent.AddDays(-(_numberRinaDay - 1));
            }

            if (startDate.HasValue)
            {
                startDateCurrent = startDate.Value;
                endDateCurrent = startDateCurrent.AddDays(_numberRinaDay - 1);
            }

            var rSession = new RinaSession();
            rSession.StartDate = startDateCurrent;
            rSession.EndDate = endDateCurrent;

            var listRina1 = new List<RinaDay>();

            var cursor1 = startDateCurrent;

            if (waterDay.HasValue && waterDay.Value)
            {
                var firstCursorWaterDay = 28;
                var secondCursorWaterDay = 57;
                var thirdCursorWaterDay = 86;

                var cursorProteinAfterFirstWaterDay = firstCursorWaterDay + 1;
                var cursorProteinAfterSecondWaterDay = secondCursorWaterDay + 1;
                var cursorProteinAfterThirdWaterDay = thirdCursorWaterDay + 1;

                Enumerable.Range(0, 90).ToList().ForEach((a1) =>
                {

                    if (a1 != 0)
                    {
                        cursor1 = cursor1.AddDays(1);
                    }

                    var typ1 = RinaDayTypeEnum.Water;

                    if (a1 < firstCursorWaterDay)
                    {
                        if (a1 % 4 == 0)
                        {
                            typ1 = RinaDayTypeEnum.Protein;
                        }

                        if (a1 % 4 == 1)
                        {
                            typ1 = RinaDayTypeEnum.Starch;
                        }

                        if (a1 % 4 == 2)
                        {
                            typ1 = RinaDayTypeEnum.Carbohydrates;
                        }

                        if (a1 % 4 == 3)
                        {
                            typ1 = RinaDayTypeEnum.Vitamins;
                        }
                    }
                    else if (a1 == firstCursorWaterDay || a1 == secondCursorWaterDay || a1 == thirdCursorWaterDay)
                    {
                        typ1 = RinaDayTypeEnum.Water;
                    }
                    else if (a1 > firstCursorWaterDay && a1 < secondCursorWaterDay)
                    {
                        if (a1 % cursorProteinAfterFirstWaterDay % 4 == 0)
                        {
                            typ1 = RinaDayTypeEnum.Protein;
                        }

                        if (a1 % cursorProteinAfterFirstWaterDay % 4 == 1)
                        {
                            typ1 = RinaDayTypeEnum.Starch;
                        }

                        if (a1 % cursorProteinAfterFirstWaterDay % 4 == 2)
                        {
                            typ1 = RinaDayTypeEnum.Carbohydrates;
                        }

                        if (a1 % cursorProteinAfterFirstWaterDay % 4 == 3)
                        {
                            typ1 = RinaDayTypeEnum.Vitamins;
                        }
                    }
                    else if (a1 > secondCursorWaterDay && a1 < thirdCursorWaterDay)
                    {
                        if (a1 % cursorProteinAfterSecondWaterDay % 4 == 0)
                        {
                            typ1 = RinaDayTypeEnum.Protein;
                        }

                        if (a1 % cursorProteinAfterSecondWaterDay % 4 == 1)
                        {
                            typ1 = RinaDayTypeEnum.Starch;
                        }

                        if (a1 % cursorProteinAfterSecondWaterDay % 4 == 2)
                        {
                            typ1 = RinaDayTypeEnum.Carbohydrates;
                        }

                        if (a1 % cursorProteinAfterSecondWaterDay % 4 == 3)
                        {
                            typ1 = RinaDayTypeEnum.Vitamins;
                        }
                    }
                    else
                    {
                        if (a1 % cursorProteinAfterThirdWaterDay % 4 == 0)
                        {
                            typ1 = RinaDayTypeEnum.Protein;
                        }

                        if (a1 % cursorProteinAfterThirdWaterDay % 4 == 1)
                        {
                            typ1 = RinaDayTypeEnum.Starch;
                        }

                        if (a1 % cursorProteinAfterThirdWaterDay % 4 == 2)
                        {
                            typ1 = RinaDayTypeEnum.Carbohydrates;
                        }

                        if (a1 % cursorProteinAfterThirdWaterDay % 4 == 3)
                        {
                            typ1 = RinaDayTypeEnum.Vitamins;
                        }
                    }

                    listRina1.Add(new RinaDay()
                    {

                        DayNumber = a1 + 1,
                        Date = cursor1,
                        Type = typ1,
                        DateString = cursor1.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture),
                        TypeString = typ1.ToString()

                    });

                });

            }
            else
            {
                Enumerable.Range(0, 90).ToList().ForEach((a1) =>
                {

                    if (a1 != 0)
                    {
                        cursor1 = cursor1.AddDays(1);
                    }

                    var typ1 = RinaDayTypeEnum.Protein;

                    if (a1 % 4 == 0)
                    {
                        typ1 = RinaDayTypeEnum.Protein;
                    }

                    if (a1 % 4 == 1)
                    {
                        typ1 = RinaDayTypeEnum.Starch;
                    }

                    if (a1 % 4 == 2)
                    {
                        typ1 = RinaDayTypeEnum.Carbohydrates;
                    }

                    if (a1 % 4 == 3)
                    {
                        typ1 = RinaDayTypeEnum.Vitamins;
                    }

                    listRina1.Add(new RinaDay()
                    {

                        DayNumber = a1 + 1,
                        Date = cursor1,
                        Type = typ1,
                        DateString = cursor1.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture),
                        TypeString = typ1.ToString()

                    });

                });
            }
   
            rSession.DaysListed = listRina1.Take(90).ToList();

            return rSession;
        }


    }
}
