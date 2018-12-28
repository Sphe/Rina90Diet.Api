using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

using IO.Swagger.Models;
using Swashbuckle.AspNetCore.Annotations;
using Rina90Diet.Service;
using Rina90Diet.Service.Contract;
using Rina90Diet.Dto;
using Rina90Diet.Model.FullDomain;
using Rina90Diet.Service.BusinessImplService.Contract;
using System.Threading.Tasks;

namespace Rina90Diet.ApiController.Controllers
{ 

    public class KycProcessApiController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IDbContextService _dbContext;
        private readonly IGenericCrudService<UserGenericAttributeDto, Usergenericattributemap> _userAttributeService;
        private readonly IGenericCrudService<UserVerificationStatusDto, Userverificationstatus> _userVefirificationService;
        private readonly IAttributeService _attributeService;

        public KycProcessApiController(ICustomerService customerService,
            IDbContextService dbContext,
            IGenericCrudService<UserGenericAttributeDto, Usergenericattributemap> userAttributeService,
            IGenericCrudService<UserVerificationStatusDto, Userverificationstatus> userVefirificationService,
        IAttributeService attributeService
)
        {
            _customerService = customerService;
            _dbContext = dbContext;
            _userAttributeService = userAttributeService;
            _userVefirificationService = userVefirificationService;
            _attributeService = attributeService;
        }

        [HttpGet]
        [Route("/v1/kycprocess/acceptCustomer")]
        
        [SwaggerOperation("KycProcessAcceptCustomerGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(bool?))]
        public virtual async Task<IActionResult> KycProcessAcceptCustomerGet([FromQuery]string customerId)
        {
            var userIdInt = Convert.ToInt32(customerId);

            var cust1 = await _customerService.GetUserById(userIdInt);

            var status1 = await _userVefirificationService.GetSingleByPredicateAsync(x1 => x1.Name == "Done");

            cust1.Userverificationstatusid = status1.Userverificationstatusid;

            cust1.Modifiedon = DateTime.UtcNow;

            var bRes1 = await _customerService.UpdateUser(cust1);

            return new ObjectResult(bRes1);
        }

        [HttpGet]
        [Route("/v1/kycprocess/customerSubmit")]

        [SwaggerOperation("KycProcessSubmittedCustomerGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(bool?))]
        public virtual async Task<IActionResult> KycProcessSubmittedCustomerGet([FromQuery]string customerId)
        {
            var userIdInt = Convert.ToInt32(customerId);

            var cust1 = await _customerService.GetUserById(userIdInt);

            var status1 = await _userVefirificationService.GetSingleByPredicateAsync(x1 => x1.Name == "Submitted");

            cust1.Userverificationstatusid = status1.Userverificationstatusid;

            cust1.Modifiedon = DateTime.UtcNow;

            var bRes1 = await _customerService.UpdateUser(cust1);

            return new ObjectResult(bRes1);
        }

        [HttpGet]
        [Route("/v1/kycprocess/checkinByAdmin")]

        [SwaggerOperation("KycProcessCheckinByAdminGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(bool?))]
        public virtual async Task<IActionResult> KycProcessCheckinByAdminGet([FromQuery]string customerId)
        {
            var userIdInt = Convert.ToInt32(customerId);

            var cust1 = await _customerService.GetUserById(userIdInt);

            var status1 = await _userVefirificationService.GetSingleByPredicateAsync(x1 => x1.Name == "Checking");

            cust1.Userverificationstatusid = status1.Userverificationstatusid;

            cust1.Modifiedon = DateTime.UtcNow;

            var bRes1 = await _customerService.UpdateUser(cust1);

            return new ObjectResult(bRes1);
        }

        [HttpGet]
        [Route("/v1/kycprocess/refuseCustomer")]

        [SwaggerOperation("KycProcessRefuseUserGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(bool?))]
        public virtual async Task<IActionResult> KycProcessRefuseUserGet([FromQuery]string customerId, [FromQuery]string reason)
        {
            var userIdInt = Convert.ToInt32(customerId);

            var cust1 = await _customerService.GetUserById(userIdInt);

            var status1 = await _userVefirificationService.GetSingleByPredicateAsync(x1 => x1.Name == "Rejected");

            cust1.Userverificationstatusid = status1.Userverificationstatusid;

            cust1.Modifiedon = DateTime.UtcNow;

            var bRes1 = await _customerService.UpdateUser(cust1);

            return new ObjectResult(bRes1);
        }

        [HttpGet]
        [Route("/v1/kycprocess/requestingCustomer")]

        [SwaggerOperation("KycProcessRequestingUserGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(bool?))]
        public virtual async Task<IActionResult> KycProcessRequestingUserGet([FromQuery]string customerId, [FromQuery]string question)
        {
            var userIdInt = Convert.ToInt32(customerId);

            var cust1 = await _customerService.GetUserById(userIdInt);

            var status1 = await _userVefirificationService.GetSingleByPredicateAsync(x1 => x1.Name == "Requesting");

            cust1.Userverificationstatusid = status1.Userverificationstatusid;

            cust1.Modifiedon = DateTime.UtcNow;

            var bRes1 = await _customerService.UpdateUser(cust1);

            return new ObjectResult(bRes1);
        }

        [HttpGet]
        [Route("/v1/kycprocess/acknowledgeCustomer")]

        [SwaggerOperation("KycProcessAcknowledgeCustomerGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(bool?))]
        public virtual async Task<IActionResult> KycProcessAcknowledgeCustomerGet([FromQuery]string customerId)
        {
            var userIdInt = Convert.ToInt32(customerId);

            var cust1 = await _customerService.GetUserById(userIdInt);

            var status1 = await _userVefirificationService.GetSingleByPredicateAsync(x1 => x1.Name == "Verified");

            cust1.Userverificationstatusid = status1.Userverificationstatusid;

            cust1.Modifiedon = DateTime.UtcNow;

            var bRes1 = await _customerService.UpdateUser(cust1);

            return new ObjectResult(bRes1);
        }
        
        [HttpGet]
        [Route("/v1/kycprocess/byId")]
        
        [SwaggerOperation("KycProcessByIdGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(KycProcessDescription))]
        public virtual IActionResult KycProcessByIdGet([FromQuery]string kycprocessId)
        { 
            return new ObjectResult(null);
        }

        [HttpGet]
        [Route("/v1/kycprocess/byCustomerId")]

        [SwaggerOperation("KycProcessByCustomerIdGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(KycProcessDescription))]
        public virtual IActionResult KycProcessByCustomerIdGet([FromQuery]string customerId)
        {
            return new ObjectResult(null);
        }

        [HttpGet]
        [Route("/v1/kycprocess/create")]
        [SwaggerOperation("Create KYC Application Process for the Customer", "This is triggered when the User submits the KYC Form. It will do additional checks on the form data.")]
        [ProducesResponseType(statusCode: 200, type: typeof(KycProcessDescription))]
        public virtual async Task<IActionResult> KycProcessCreatePost([FromQuery]string customerId)
        {
            //TODO check all the KYC form data
            //TODO on error return the Customer form data with the error description
            //TODO If OK, take snapshot of the data
            //TODO create the KYCProcess
            var userIdInt = Convert.ToInt32(customerId);

            var cust1 = await _customerService.GetUserById(userIdInt);

            var status1 = await _userVefirificationService.GetSingleByPredicateAsync(x1 => x1.Name == "Created");

            cust1.Userverificationstatusid = status1.Userverificationstatusid;

            cust1.Modifiedon = DateTime.UtcNow;

            var bRes1 = await _customerService.UpdateUser(cust1);

            return new ObjectResult(bRes1);
        }

        [HttpGet]
        [Route("/v1/kycprocess/existCustomer")]
        
        [SwaggerOperation("KycProcessExistCustomerGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(bool?))]
        public virtual IActionResult KycProcessExistCustomerGet([FromQuery]string customerId)
        { 
            return new ObjectResult(null);
        }

        [HttpGet]
        [Route("/v1/kycprocess/statusCustomer")]
        [SwaggerOperation("Find the current KYC status of a Customer", "Returns the KYC Status object (Code, Name, Timestamp) for a given Customer")]
        [Produces("application/json", "text/json")]
        [ProducesResponseType(statusCode: 200, type: typeof(KycStatusDescription))]
        public virtual async Task<IActionResult> KycProcessStatusCustomerGet(
            [SwaggerParameter("The CustomerID of the Customer to Return. Embedded in the JWToken.", Required = true)][FromQuery]string customerId)
        {
            //TODO !Important: IF KYC = NULL Then Return Status "Pending"

            var userIdInt = Convert.ToInt32(customerId);

            var cust1 = await _customerService.GetUserById(userIdInt);

            if (cust1 != null && cust1.Userverificationstatusid.HasValue)
            {
                var statusVal1 = await _userVefirificationService.GetSingleByPredicateAsync(x1 => x1.Userverificationstatusid == cust1.Userverificationstatusid.Value);

                var res1 = new KycStatusDescription()
                {
                    Timestamp = cust1.Modifiedon,
                    UserVerificationStatusId = statusVal1.Userverificationstatusid,
                    UserVerificationStatusName = statusVal1.Name
                };

                return new ObjectResult(res1);
            }

            var statusValDefault = await _userVefirificationService.GetSingleByPredicateAsync(x1 => x1.Name == "Pending");

            var resDefault = new KycStatusDescription()
            {
                Timestamp = cust1.Modifiedon,
                UserVerificationStatusId = statusValDefault.Userverificationstatusid,
                UserVerificationStatusName = statusValDefault.Name
            };

            return new ObjectResult(resDefault);
        }
        
        [HttpGet]
        [Route("/v1/kycprocess/list")]
        
        [SwaggerOperation("KycProcessListingGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(List<KycProcessDescription>))]
        public virtual IActionResult KycProcessListingGet([FromQuery]int? skip, [FromQuery]int? limit, [FromQuery]string where)
        { 
            return new ObjectResult(null);
        }

        [HttpGet]
        [Route("/v1/kycprocess/statuslist")]

        [SwaggerOperation("KycProcessStatusListingGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(List<UserVerificationStatusDto>))]
        public virtual async Task<IActionResult> KycProcessStatusListingGet()
        {
            var lst1 = await _userVefirificationService.GetAllAsync();
            return new ObjectResult(lst1);
        }

    }
}
