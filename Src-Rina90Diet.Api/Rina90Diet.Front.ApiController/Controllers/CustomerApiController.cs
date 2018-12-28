
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Rina90Diet.Service;
using Rina90Diet.Service.Contract;
using Rina90Diet.Api.Web.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Linq;
using Rina90Diet.Service.BusinessImplService.Contract;
using Rina90Diet.Model.FullDomain;
using Rina90Diet.Dto;
using System;
using Microsoft.EntityFrameworkCore;
using Rina90Diet.Data.FullDomain.Infrastructure;

namespace Rina90Diet.ApiController.Controllers
{
    /// <summary>
    /// All APIs related to rina90Diet customers.
    /// </summary>
    [EnableCors("SiteCorsPolicy")]
    public class CustomerApiController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IDbContextService _dbContext;
        private readonly IGenericCrudService<UserGenericAttributeDto, Usergenericattributemap> _genService;
        private readonly IAttributeService _attributeService;
        private readonly IRina90DietDbFullDomainRepository<Usergenericattributemap> _userAttributeMapRepository;

        public CustomerApiController(ICustomerService customerService,
            IDbContextService dbContext,
            IGenericCrudService<UserGenericAttributeDto, Usergenericattributemap> genService,
            IAttributeService attributeService,
            IRina90DietDbFullDomainRepository<Usergenericattributemap> userAttributeMapRepository
        )
        {
            _customerService = customerService;
            _dbContext = dbContext;
            _genService = genService;
            _attributeService = attributeService;
            _userAttributeMapRepository = userAttributeMapRepository;
        }


        /// <summary>
        /// Find customer by ID
        /// </summary>
        /// <remarks>Returns customer and his details based on ID</remarks>
        /// <param name="CustomerId" >customer Id</param>
        /// <response code="200">customer object found</response>
        /// <response code="0">error payload</response>
        [HttpGet]
        [Route("/v1/customer/byId")]
        [SwaggerOperation("Find Customer by ID", "Returns a single Customer.")]
        [Produces("application/json", "text/json")]
        [ProducesResponseType(typeof(CustomerProfile), 200)]        
        //[Authorize(Roles = "customer,customer:byid")]
        public virtual async Task<IActionResult> CustomerByIdGet(
            [SwaggerParameter("The CustomerID of the Customer to Return. Embedded in the JWToken.", Required = true)][FromQuery]string CustomerId,
            [SwaggerParameter("Pulls or not the attached documents.", Required = false)][FromQuery]bool extended = false)
        {
            //User.CheckIfValidCustomerId(id, true);

            _dbContext.RefreshFullDomain();
            var cust = await _customerService.GetCustomerByIdAsync(CustomerId);

            if (extended)
            {
                var docList = await _genService.GetListByPredicateAsync((x => {
                    return x.Userid.ToString() == CustomerId;
                }), d =>
                {
                    return d
                        .Include("Genericattribute");
                });

                var listDoc = docList.Select(x =>
                {

                    if (x != null && x.Genericattribute != null)
                    {
                        var rr1 = new AttachedDocumentDto()
                        {

                            Data = x.Genericattribute.Valuestring,
                            Name = x.Genericattribute.Typestring,
                            Timestamp = x.Modifiedon

                        };

                        return rr1;
                    }

                    return null;

                }
                ).Where(x1 => x1 != null).OrderByDescending(x1 => x1.Timestamp);

                cust.Documents = listDoc.ToList();
            }

            return new ObjectResult(cust);
        }

        /// <summary>
        /// List customer
        /// </summary>
        /// <remarks>Returns customer list</remarks>
        /// <response code="200">list customers found</response>
        /// <response code="0">error payload</response>
        [HttpGet]
        [Route("/v1/customer/list")]
        [SwaggerOperation("List all Customers", "This can only be done by an Admin User. Returns an array of Customers, from the first one to the last one." )]
        [Produces("application/json", "text/json")]
        [ProducesResponseType(typeof(List<CustomerProfile>), 200)]
        //[Authorize(Roles = "customer,customer:byid")]
        public virtual async Task<IActionResult> CustomerListGet(
            [SwaggerParameter("The number of occurrences not counted from start.", Required = false)][FromQuery]int skip = 0,
            [SwaggerParameter("The number of occurences to return.", Required = false)][FromQuery]int take = 50)
        {   
            //TODO FIXME @alex: only admin should be able to use that API.

            //User.CheckIfValidCustomerId(id, true);

            _dbContext.RefreshFullDomain();
            var cust = await _customerService.GetAllCustomersAsync(skip, take);
            return new ObjectResult(cust);
        }

        /// <summary>
        /// Create customer
        /// </summary>
        /// <remarks>Create customer</remarks>
        /// <param name="customer">Customer object that needs to be added to the store</param>
        /// <response code="200">customer response</response>
        /// <response code="0">error payload</response>
        [HttpPost]
        [Route("/v1/customer/create")]
        [SwaggerOperation("Create a Customer with minimum data through sign up", "This can only be done by the Identity App. Returns a Customer with the CustomerID.")]
        [Consumes("application/json", "text/json")]
        [Produces("application/json", "text/json")]
        [ProducesResponseType(typeof(List<CustomerProfile>), 200)]
        //[Authorize(Roles = "customer:create")]
        public virtual async Task<IActionResult> CustomerCreatePost(
            [SwaggerParameter("The Customer details. Uses only First Name, Last Name and email.", Required = true)][FromBody]CustomerCreateOrUpdate customer)
        {
            //TODO FIXME @alex: only Identity App can call that API.

            _dbContext.RefreshFullDomain();
            var cust = await _customerService.CreateCustomerAsync(customer);
            return new ObjectResult(cust);
        }

        /// <summary>
        /// Update Customer info in the store with form data
        /// </summary>
        /// <remarks>Update customer</remarks>
        /// <param name="customer">Customer object that needs to be added to the store</param>
        /// <response code="200">customer response</response>
        /// <response code="0">error payload</response>
        [HttpPut]
        [Route("/v1/customer/update")]
        [SwaggerOperation("Updates a Customer in the store with KYC form data", 
            "Updates Customer with data on KYC form. Can only be called when KYC Status in [PENDING, IDENTIFIED, ATTACHING]")]
        [Consumes("application/json", "text/json")]
        [Produces("application/json", "text/json")]
        [ProducesResponseType(typeof(List<CustomerProfile>), 200)]
        [ProducesResponseType(typeof(bool), 405)]
        [ProducesResponseType(typeof(bool), 409)]
        [ProducesResponseType(typeof(bool), 423)]
        //[Authorize(Roles = "customer,customer:update")]
        public virtual async Task<IActionResult> CustomerUpdatePut(
            [SwaggerParameter("The Customer details. Uses only First Name, Last Name and email.", Required = true)][FromBody]CustomerCreateOrUpdate customer)
        {
            //User.CheckIfValidCustomerId(customer.CustomerId, true);

            //TODO FIXME !important: Check the KYC Process Status, it must be in [PENDING, IDENTIFIED, ATTACHING] to continue the update. Otherwise, send an error

            _dbContext.RefreshFullDomain();
            var cust = await _customerService.UpdateCustomerAsync(customer);
            return new ObjectResult(cust);
        }


        /// <summary>
        /// Get information about the owner of the access token.
        /// </summary>
        /// <remarks>The User Profile endpoint returns information about the user that has authorized with the application.</remarks>
        /// <response code="200">Profile information for a user</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/v1/customer/me")]
        [SwaggerOperation("Returns info for the logged user", "Returns Customer containing all the details for the logged user.")]
        [Produces("application/json", "text/json")]
        [ProducesResponseType(typeof(CustomerProfile), 200)]
        //[Authorize(Roles = "customer,customer:me")]
        public virtual IActionResult CustomerMeGet()
        {
            _dbContext.RefreshFullDomain();
            string exampleJson = null;

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CustomerProfile>(exampleJson)
            : default(CustomerProfile);
            return new ObjectResult(example);
        }

        [HttpPost]
        [Route("/v1/customer/attachDocument")]
        [SwaggerOperation("Upload a document for Customer", "Upload a document for a given Customer from KYC form data.")]
        [Produces("application/json", "text/json")]
        [ProducesResponseType(statusCode: 200, type: typeof(bool))]
        public async Task<IActionResult> CustomerAttachDocument(
            [SwaggerParameter("The CustomerID of the Customer to Return. Embedded in the JWToken.", Required = true)][FromQuery]string customerId,
            [SwaggerParameter("key", Required = true)][FromQuery]string key,
            [SwaggerParameter("The documents in byte[].", Required = true)][FromForm] List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            var now = DateTime.UtcNow;

            var count = 0;

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new MemoryStream())
                    {
                        await formFile.CopyToAsync(stream);
                        await stream.FlushAsync();
                        stream.Position = 0;

                        var b1 = stream.ToArray();

                        var keyGen = string.Concat("docsave-customer-", customerId, "-", key, "-", count);

                        var ga = await _attributeService.CreateOrGetAttribute(keyGen, Convert.ToBase64String(b1));


                        var exists = await _userAttributeMapRepository
                                            .DbSet
                                            .Include("Genericattribute")
                                            .FirstOrDefaultAsync(x1 => x1.Genericattribute.Typestring == keyGen);

                        if (exists != null)
                        {
                            var ugad = new UserGenericAttributeDto()
                            {
                                Userattributeid = exists.Userattributeid,
                                Active = true,
                                Genericattributeid = ga.Genericattributeid,
                                Userid = Convert.ToInt32(customerId),
                                Createdby = "system",
                                Modifiedby = "system",
                                Createdon = now,
                                Modifiedon = now
                            };

                            var res1 = await _genService.UpdateAsync(ugad, (x => { return x.Userattributeid == ugad.Userattributeid; }));
                        }
                        else
                        {
                            var ugad = new UserGenericAttributeDto()
                            {
                                Active = true,
                                Genericattributeid = ga.Genericattributeid,
                                Userid = Convert.ToInt32(customerId),
                                Createdby = "system",
                                Modifiedby = "system",
                                Createdon = now,
                                Modifiedon = now
                            };

                            var res1 = await _genService.CreateAsync(ugad, (x => { return x.Userattributeid == ugad.Userattributeid; }));
                        }

                        count++;
                    }
                }
            }

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return Ok(new { count = files.Count });
        }

    }
}
