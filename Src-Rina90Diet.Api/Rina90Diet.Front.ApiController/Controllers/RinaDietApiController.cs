using System;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Rina90Diet.Service;
using Rina90Diet.Service.Contract;
using Rina90Diet.Dto;
using Rina90Diet.Model.FullDomain;
using Rina90Diet.Service.BusinessImplService.Contract;
using System.Threading.Tasks;
using Rina90Diet.Front.ApiWeb;

namespace Rina90Diet.ApiController.Controllers
{ 

    public class RinaDietApiController : Controller
    {
        private readonly ICustomerService _customerService;
        
        private readonly IGenericCrudService<UserGenericAttributeDto, Usergenericattributemap> _userAttributeService;
        private readonly IAttributeService _attributeService;
        private readonly IDbContextService _dbContext;

        private readonly IRinaDietService _rinaDietService;

        public RinaDietApiController

            (ICustomerService customerService,
            IDbContextService dbContext,
            IGenericCrudService<UserGenericAttributeDto, Usergenericattributemap> userAttributeService,
            IAttributeService attributeService,
            IRinaDietService rinaDietService
            )

        {
            _customerService = customerService;
            _dbContext = dbContext;
            _userAttributeService = userAttributeService;
            _attributeService = attributeService;
            _rinaDietService = rinaDietService;
        }

        [HttpGet]
        [Route("/v1/rinadiet/createSession")]
        [SwaggerOperation("CreateSessionGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(RinaSession))]
        public virtual IActionResult CreateSessionGet(
                [FromQuery]DateTime? startDate, 
                [FromQuery]DateTime? endDate, 
                [FromQuery]bool? isWaterDay)
        {

            var rs1 = _rinaDietService.CreateDiet(startDate, endDate, isWaterDay);
            
            return new ObjectResult(rs1);
        }

        [HttpGet]
        [Route("/v1/rinadiet/createProfile")]
        [SwaggerOperation("CreateProfileGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(RinaCustomerProfile))]
        public virtual async Task<IActionResult> CreateProfileGet(
            [FromQuery]string customerId,
            [FromQuery]decimal weightInKg,
            [FromQuery]decimal heightInM,
            [FromQuery]DateTime? startDate,
            [FromQuery]DateTime? endDate,
            [FromQuery]bool? waterDay)
        {

            var rs1 = await _rinaDietService.CreateProfile(customerId, weightInKg, heightInM, startDate, endDate, waterDay);

            return new ObjectResult(rs1);
        }

        [HttpGet]
        [Route("/v1/rinadiet/getProfile")]
        [SwaggerOperation("GetProfileByCustomerGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(RinaCustomerProfile))]
        public virtual async Task<IActionResult> GetProfileByCustomerGet(
            [FromQuery]string customerId)
        {

            var rs1 = await _rinaDietService.GetProfileByCustomerId(customerId);

            return new ObjectResult(rs1);
        }

        [HttpGet]
        [Route("/v1/rinadiet/sendWeight")]
        [SwaggerOperation("SendWeightGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(CustomerWeightEntry))]
        public virtual async Task<IActionResult> SendWeightGet(
            [FromQuery]string customerId,
            [FromQuery]DateTime timestamp,
            [FromQuery]decimal weightInKg)
        {

            var rs1 = await _rinaDietService.AddWeight(customerId, timestamp, weightInKg);

            return new ObjectResult(rs1);
        }

        [HttpGet]
        [Route("/v1/rinadiet/getStatByCustomer")]
        [SwaggerOperation("CalculateStatisticsGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(RinaCustomerStatistic))]
        public virtual async Task<IActionResult> CalculateStatisticsGet(
            [FromQuery]string customerId)
        {

            var rs1 = await _rinaDietService.GetCustomerStatistic(customerId);

            return new ObjectResult(rs1);
        }

    }
}
