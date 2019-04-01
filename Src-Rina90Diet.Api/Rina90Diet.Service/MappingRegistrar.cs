using AutoMapper;
using Rina90Diet.Api.Web.Models;
using System;
using Newtonsoft.Json;
using Rina90Diet.Data.FullDomain;
using Rina90Diet.Dto;
using Rina90Diet.Service.Json;
using Rina90Diet.Model.FullDomain;
using System.Reflection;
using Rina90Diet.Front.ApiWeb;

namespace Rina90Diet.Service
{
    public class MappingRegistrar
    {
        public static MapperConfiguration CreateMapperConfig()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All,
            };

            settings.Converters.Insert(0, new PrimitiveJsonConverter());

            var config = new MapperConfiguration(
                cfg => {

                    cfg.CreateMap<Genericattribute, GenericAttributeDto>();

                    //!!!!!! People

                    cfg.CreateMap<CustomerCreateOrUpdate, People>()
                        .ForMember(opt => opt.Email, x => x.MapFrom(x2 => x2.Email))
                        .ForMember(opt => opt.Firstname, x => x.MapFrom(x2 => x2.FirstName))
                        .ForMember(opt => opt.Title, x => x.MapFrom(x2 => x2.Title))
                        .ForMember(opt => opt.Middlename, x => x.MapFrom(x2 => x2.MiddleName))
                        .ForMember(opt => opt.Lastname, x => x.MapFrom(x2 => x2.LastName));

                    cfg.CreateMap<People, CustomerCreateOrUpdate>()
                        .ForMember(opt => opt.Email, x => x.MapFrom(x2 => x2.Email))
                        .ForMember(opt => opt.FirstName, x => x.MapFrom(x2 => x2.Firstname))
                        .ForMember(opt => opt.Title, x => x.MapFrom(x2 => x2.Title))
                        .ForMember(opt => opt.MiddleName, x => x.MapFrom(x2 => x2.Middlename))
                        .ForMember(opt => opt.LastName, x => x.MapFrom(x2 => x2.Lastname));
                        
                    //!!!!!! User
                    cfg.CreateMap<User, CustomerCreateOrUpdate>()
                        .ForMember(d => d.CustomerId, opt => opt.MapFrom(f => f.Userid))
                        .ForMember(d => d.Email, opt => opt.MapFrom(f => f.Email));

                    cfg.CreateMap<CustomerCreateOrUpdate, User>()
                        .ForMember(d => d.Userid, opt => opt.MapFrom(f => string.IsNullOrWhiteSpace(f.CustomerId) ? 0 : Convert.ToInt32(f.CustomerId)))
                        .ForMember(d => d.Username, opt => opt.MapFrom(f => f.Email))
                        .ForMember(d => d.Email, opt => opt.MapFrom(f => f.Email))
                        .ForMember(d => d.Password, opt => opt.MapFrom(f => f.Password));

                    cfg.CreateMap<User, CustomerProfile>()
                    .ForMember(d => d.CustomerId, opt => opt.MapFrom(f => f.Userid))
                    .ForMember(d => d.Email, opt => opt.MapFrom(f => f.Email))
                    .ForMember(d => d.FirstName, opt => opt.MapFrom(f => f.People != null ? f.People.Firstname : null))
                    .ForMember(d => d.MiddleName, opt => opt.MapFrom(f => f.People != null ? f.People.Middlename : null))
                    .ForMember(d => d.Title, opt => opt.MapFrom(f => f.People != null ? f.People.Title : null))
                    .ForMember(d => d.LastName, opt => opt.MapFrom(f => f.People != null ? f.People.Lastname : null))

                    .ForMember(d => d.MiddleName, opt => opt.MapFrom(f => f.People != null ? f.People.Middlename : null))
                    ;

                    cfg.CreateMap<CustomerCreateOrUpdate, User>()
                        .ForMember(d => d.Userid, opt => opt.MapFrom(f => string.IsNullOrWhiteSpace(f.CustomerId) ? 0 : Convert.ToInt32(f.CustomerId)))
                        .ForMember(d => d.Username, opt => opt.MapFrom(f => f.Email))
                        .ForMember(d => d.Email, opt => opt.MapFrom(f => f.Email))
                        .ForMember(d => d.Password, opt => opt.MapFrom(f => f.Password));

                    //!!!!!! CustomerProfile 
                    cfg.CreateMap<CustomerProfile, CustomerCreateOrUpdate>()
                        .ForMember(d => d.CustomerId, opt => opt.MapFrom(f => f.CustomerId))
                        .ForMember(d => d.FirstName, opt => opt.MapFrom(f => f.FirstName))
                        .ForMember(d => d.LastName, opt => opt.MapFrom(f => f.LastName))
                        .ForMember(d => d.MiddleName, opt => opt.MapFrom(f => f.MiddleName))
                        .ForMember(d => d.Nationality, opt => opt.MapFrom(f => f.Nationality))
                        .ForMember(d => d.PhoneNumber, opt => opt.MapFrom(f => f.PhoneNumber))
                        .ForMember(d => d.Picture, opt => opt.MapFrom(f => f.Picture))
                        .ForMember(d => d.TelegramUser, opt => opt.MapFrom(f => f.TelegramUser))
                        .ForMember(d => d.ZipCode, opt => opt.MapFrom(f => f.ZipCode))
                        .ForMember(d => d.Country, opt => opt.MapFrom(f => f.Country))
                        .ForMember(d => d.AddressLine1, opt => opt.MapFrom(f => f.AddressLine1))
                        .ForMember(d => d.AddressLine2, opt => opt.MapFrom(f => f.AddressLine2))
                        .ForMember(d => d.City, opt => opt.MapFrom(f => f.City))
                        .ForMember(d => d.Title, opt => opt.MapFrom(f => f.Title))
                        .ForMember(d => d.DateOfBirth, opt => opt.MapFrom(f => f.DateOfBirth))
                        .ForMember(d => d.Email, opt => opt.MapFrom(f => f.Email));

                    cfg.CreateMap<CustomerCreateOrUpdate, CustomerProfile>()
                        .ForMember(d => d.CustomerId, opt => opt.MapFrom(f => string.IsNullOrWhiteSpace(f.CustomerId) ? 0 : Convert.ToInt32(f.CustomerId)))
                        .ForMember(d => d.FirstName, opt => opt.MapFrom(f => f.FirstName))
                        .ForMember(d => d.LastName, opt => opt.MapFrom(f => f.LastName))
                        .ForMember(d => d.MiddleName, opt => opt.MapFrom(f => f.MiddleName))
                        .ForMember(d => d.Nationality, opt => opt.MapFrom(f => f.Nationality))
                        .ForMember(d => d.PhoneNumber, opt => opt.MapFrom(f => f.PhoneNumber))
                        .ForMember(d => d.Picture, opt => opt.MapFrom(f => f.Picture))
                        .ForMember(d => d.TelegramUser, opt => opt.MapFrom(f => f.TelegramUser))
                        .ForMember(d => d.ZipCode, opt => opt.MapFrom(f => f.ZipCode))
                        .ForMember(d => d.Country, opt => opt.MapFrom(f => f.Country))
                        .ForMember(d => d.AddressLine1, opt => opt.MapFrom(f => f.AddressLine1))
                        .ForMember(d => d.AddressLine2, opt => opt.MapFrom(f => f.AddressLine2))
                        .ForMember(d => d.City, opt => opt.MapFrom(f => f.City))
                        .ForMember(d => d.Title, opt => opt.MapFrom(f => f.Title))
                        .ForMember(d => d.DateOfBirth, opt => opt.MapFrom(f => f.DateOfBirth))
                        .ForMember(d => d.Email, opt => opt.MapFrom(f => f.Email));
                        

                    cfg.CreateMap<CultureDto, Culture>();

                    cfg.CreateMap<Culture, CultureDto>();

                    //

                    cfg.CreateMap<PageDto, Page>();

                    cfg.CreateMap<Page, PageDto>();

                    //

                    cfg.CreateMap<ArticleDto, Article>();

                    cfg.CreateMap<Article, ArticleDto>();

                    //

                    cfg.CreateMap<ContentblockDto, Contentblock>();

                    cfg.CreateMap<Contentblock, ContentblockDto>();

                    //

                    cfg.CreateMap<UserGenericAttributeDto, Usergenericattributemap>();

                    cfg.CreateMap<Usergenericattributemap, UserGenericAttributeDto>();

                    //cfg.CreateMap<ContentBlockImageMapDto, Contentblockimagemap>();

                    //cfg.CreateMap<Contentblockimagemap, ContentBlockImageMapDto>();



                    cfg.CreateMap<RinaCustomerProfile, Customerprofile>()
                        .ForMember(d => d.Customerprofileid, opt => opt.MapFrom(f => string.IsNullOrWhiteSpace(f.CustomerProfileId) ? 0 : Convert.ToInt32(f.CustomerProfileId)))
                        .ForMember(d => d.Userid, opt => opt.MapFrom(f => string.IsNullOrWhiteSpace(f.CustomerId) ? 0 : Convert.ToInt32(f.CustomerId)))
                        .ForMember(d => d.Currentimc, opt => opt.MapFrom(f => f.CurrentImc))
                        .ForMember(d => d.Initialimc, opt => opt.MapFrom(f => f.InitialImc))
                        .ForMember(d => d.Targetimc, opt => opt.MapFrom(f => f.TargetImc))
                        .ForMember(d => d.Iswaterday, opt => opt.MapFrom(f => f.IsWaterDay))
                        .ForMember(d => d.Currentweight, opt => opt.MapFrom(f => f.CurrentWeight))
                        .ForMember(d => d.Initialweight, opt => opt.MapFrom(f => f.InitialWeight))
                        .ForMember(d => d.Targetweight, opt => opt.MapFrom(f => f.TargetWeight))
                        .ForMember(d => d.Numberdietdays, opt => opt.MapFrom(f => f.TotalDietDays))
                        .ForMember(d => d.Startdate, opt => opt.MapFrom(f => f.StartDate))
                        .ForMember(d => d.Enddate, opt => opt.MapFrom(f => f.EndDate))
                        .ForMember(d => d.Activated, opt => opt.MapFrom(f => f.Activated))
                        .ForMember(d => d.Deleted, opt => opt.MapFrom(f => f.Deleted))
                        .ForMember(d => d.Heightinm, opt => opt.MapFrom(f => f.HeightInM));

                    cfg.CreateMap<Customerprofile, RinaCustomerProfile>()
                        .ForMember(d => d.CustomerProfileId, opt => opt.MapFrom(f => f.Customerprofileid.ToString()))
                        .ForMember(d => d.CustomerId, opt => opt.MapFrom(f => f.Userid.ToString()))
                        .ForMember(d => d.CurrentImc, opt => opt.MapFrom(f => f.Currentimc))
                        .ForMember(d => d.InitialImc, opt => opt.MapFrom(f => f.Initialimc))
                        .ForMember(d => d.TargetImc, opt => opt.MapFrom(f => f.Targetimc))
                        .ForMember(d => d.IsWaterDay, opt => opt.MapFrom(f => f.Iswaterday))
                        .ForMember(d => d.CurrentWeight, opt => opt.MapFrom(f => f.Currentweight))
                        .ForMember(d => d.InitialWeight, opt => opt.MapFrom(f => f.Initialweight))
                        .ForMember(d => d.TargetWeight, opt => opt.MapFrom(f => f.Targetweight))
                        .ForMember(d => d.TotalDietDays, opt => opt.MapFrom(f => f.Numberdietdays))
                        .ForMember(d => d.Activated, opt => opt.MapFrom(f => f.Activated))
                        .ForMember(d => d.Deleted, opt => opt.MapFrom(f => f.Deleted))
                        .ForMember(d => d.StartDate, opt => opt.MapFrom(f => f.Startdate))
                        .ForMember(d => d.EndDate, opt => opt.MapFrom(f => f.Enddate))
                        .ForMember(d => d.HeightInM, opt => opt.MapFrom(f => f.Heightinm));


                    cfg.CreateMap<CustomerWeightEntry, Customerweightentry>()
                        .ForMember(d => d.Customerprofileid, opt => opt.MapFrom(f => string.IsNullOrWhiteSpace(f.CustomerProfileId) ? 0 : Convert.ToInt32(f.CustomerProfileId)))
                        .ForMember(d => d.Customerweightentryid, opt => opt.MapFrom(f => string.IsNullOrWhiteSpace(f.CustomerWeightEntryId) ? 0 : Convert.ToInt32(f.CustomerWeightEntryId)))
                        .ForMember(d => d.Indexday, opt => opt.MapFrom(f => f.IndexDay))
                        .ForMember(d => d.Timestamp, opt => opt.MapFrom(f => f.TimeStamp))
                        .ForMember(d => d.Weightinkg, opt => opt.MapFrom(f => f.WeightInKg));

                    cfg.CreateMap<Customerfoodentry, CustomerFoodEntryDto>()
                        .ForMember(d => d.Customerfoodentryid, opt => opt.MapFrom(f => f.Customerfoodentryid))
                        .ForMember(d => d.Customerprofileid, opt => opt.MapFrom(f => f.Customerprofileid))
                        .ForMember(d => d.Mealinterval, opt => opt.MapFrom(f => f.Mealinterval))
                        .ForMember(d => d.Unit, opt => opt.MapFrom(f => f.Unit))
                        .ForMember(d => d.Entrydate, opt => opt.MapFrom(f => f.Entrydate))
                        .ForMember(d => d.Quantity, opt => opt.MapFrom(f => f.Quantity))
                        .ForMember(d => d.Urilink, opt => opt.MapFrom(f => f.Urilink));

                    cfg.CreateMap<CustomerFoodEntryDto, Customerfoodentry>()
                        .ForMember(d => d.Customerfoodentryid, opt => opt.MapFrom(f => f.Customerfoodentryid))
                        .ForMember(d => d.Customerprofileid, opt => opt.MapFrom(f => f.Customerprofileid))
                        .ForMember(d => d.Mealinterval, opt => opt.MapFrom(f => f.Mealinterval))
                        .ForMember(d => d.Unit, opt => opt.MapFrom(f => f.Unit))
                        .ForMember(d => d.Entrydate, opt => opt.MapFrom(f => f.Entrydate))
                        .ForMember(d => d.Quantity, opt => opt.MapFrom(f => f.Quantity))
                        .ForMember(d => d.Urilink, opt => opt.MapFrom(f => f.Urilink));


                });

            return config;
        }

    }
}
