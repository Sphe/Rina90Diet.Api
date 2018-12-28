using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;

using IO.Swagger.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Rina90Diet.ApiController.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class TransactionApiController : Controller
    { 
        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="transactionId"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/v1/transaction/byId")]
        
        [SwaggerOperation("TransactionByIdGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(TransactionDescription))]
        public virtual IActionResult TransactionByIdGet([FromQuery]string transactionId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(TransactionDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"TransactionNumber\" : \"TransactionNumber\",\n  \"TransactionStatusId\" : \"TransactionStatusId\",\n  \"grandTotal\" : 1.4658129805029452,\n  \"customerId\" : \"customerId\",\n  \"contentId\" : \"contentId\",\n  \"subTotal\" : 0.8008281904610115,\n  \"taxAmount\" : 6.027456183070403,\n  \"TransactionId\" : \"TransactionId\",\n  \"finalTotal\" : 5.962133916683182,\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TransactionDescription>(exampleJson)
            : default(TransactionDescription);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="body"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpPost]
        [Route("/v1/transaction/create")]
        
        [SwaggerOperation("TransactionCreatePost")]
        [ProducesResponseType(statusCode: 200, type: typeof(TransactionDescription))]
        public virtual IActionResult TransactionCreatePost([FromBody]TransactionCreateOrUpdate body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(TransactionDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"TransactionNumber\" : \"TransactionNumber\",\n  \"TransactionStatusId\" : \"TransactionStatusId\",\n  \"grandTotal\" : 1.4658129805029452,\n  \"customerId\" : \"customerId\",\n  \"contentId\" : \"contentId\",\n  \"subTotal\" : 0.8008281904610115,\n  \"taxAmount\" : 6.027456183070403,\n  \"TransactionId\" : \"TransactionId\",\n  \"finalTotal\" : 5.962133916683182,\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TransactionDescription>(exampleJson)
            : default(TransactionDescription);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="skip"></param>
        /// <param name="limit"></param>
        /// <param name="where"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/v1/transaction/list")]
        
        [SwaggerOperation("TransactionListGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(List<TransactionDescription>))]
        public virtual IActionResult TransactionListGet([FromQuery]int? skip, [FromQuery]int? limit, [FromQuery]string where)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<TransactionDescription>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "[ {\n  \"TransactionNumber\" : \"TransactionNumber\",\n  \"TransactionStatusId\" : \"TransactionStatusId\",\n  \"grandTotal\" : 1.4658129805029452,\n  \"customerId\" : \"customerId\",\n  \"contentId\" : \"contentId\",\n  \"subTotal\" : 0.8008281904610115,\n  \"taxAmount\" : 6.027456183070403,\n  \"TransactionId\" : \"TransactionId\",\n  \"finalTotal\" : 5.962133916683182,\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}, {\n  \"TransactionNumber\" : \"TransactionNumber\",\n  \"TransactionStatusId\" : \"TransactionStatusId\",\n  \"grandTotal\" : 1.4658129805029452,\n  \"customerId\" : \"customerId\",\n  \"contentId\" : \"contentId\",\n  \"subTotal\" : 0.8008281904610115,\n  \"taxAmount\" : 6.027456183070403,\n  \"TransactionId\" : \"TransactionId\",\n  \"finalTotal\" : 5.962133916683182,\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<TransactionDescription>>(exampleJson)
            : default(List<TransactionDescription>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="body"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpPut]
        [Route("/v1/transaction/update")]
        
        [SwaggerOperation("TransactionUpdatePut")]
        [ProducesResponseType(statusCode: 200, type: typeof(TransactionDescription))]
        public virtual IActionResult TransactionUpdatePut([FromBody]TransactionCreateOrUpdate body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(TransactionDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"TransactionNumber\" : \"TransactionNumber\",\n  \"TransactionStatusId\" : \"TransactionStatusId\",\n  \"grandTotal\" : 1.4658129805029452,\n  \"customerId\" : \"customerId\",\n  \"contentId\" : \"contentId\",\n  \"subTotal\" : 0.8008281904610115,\n  \"taxAmount\" : 6.027456183070403,\n  \"TransactionId\" : \"TransactionId\",\n  \"finalTotal\" : 5.962133916683182,\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TransactionDescription>(exampleJson)
            : default(TransactionDescription);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
