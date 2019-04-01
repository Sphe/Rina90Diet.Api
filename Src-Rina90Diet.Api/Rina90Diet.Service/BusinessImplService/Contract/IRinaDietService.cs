using Rina90Diet.Dto;
using Rina90Diet.Model.FullDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rina90Diet.Service.BusinessImplService.Contract
{
    public interface IRinaDietService
    {
        RinaSession CreateDiet(DateTime? startDate, DateTime? endDate, bool? waterDay);

        Task<RinaCustomerProfile> GetProfileByCustomerId(string customerId);

        Task<RinaCustomerProfile> CreateProfile(
            string customerId,
            decimal weightInKg,
            decimal heightInM,
            DateTime? startDate,
            DateTime? endDate,
            bool? waterDay);

        Task<CustomerWeightEntry> AddWeight(string customerId, DateTime timestamp, decimal weightInKg);

        Task<RinaCustomerStatistic> GetCustomerStatistic(string customerId);

        Task<RinaCustomerProfile> ActivateProfileById(string customerProfileId);

        Task<List<RinaCustomerProfile>> ListProfileByCustomerId(string customerId);

        Task<RinaCustomerProfile> GetProfileByCustomerProfileId(string customerProfileId);

        Task DeleteCustomerProfileByProfileId(string customerProfileId);
    }
}
