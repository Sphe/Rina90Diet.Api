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
    public class BlockchainApiController : Controller
    { 
        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="blockchainId"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/v1/blockchain/byId")]
        
        [SwaggerOperation("BlockchainByIdGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(BlockchainDescription))]
        public virtual IActionResult BlockchainByIdGet([FromQuery]string blockchainId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(BlockchainDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"country\" : \"country\",\n  \"zipCode\" : \"zipCode\",\n  \"code\" : \"code\",\n  \"city\" : \"city\",\n  \"latitude\" : 6.0274563,\n  \"description\" : \"description\",\n  \"wifiPassword\" : \"wifiPassword\",\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"countryId\" : 0,\n  \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"useBlockchainTransactionLogo\" : true,\n  \"modifiedBy\" : \"modifiedBy\",\n  \"state\" : \"state\",\n  \"email\" : \"email\",\n  \"longitude\" : 1.4658129,\n  \"address\" : \"address\",\n  \"address2\" : \"address2\",\n  \"contactName\" : \"contactName\",\n  \"wifiSsid\" : \"wifiSsid\",\n  \"phone\" : \"phone\",\n  \"createdBy\" : \"createdBy\",\n  \"lastUpdate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"name\" : \"name\",\n  \"blockchainId\" : \"blockchainId\",\n  \"blockchainTransactionId\" : \"blockchainTransactionId\",\n  \"homepage\" : \"homepage\",\n  \"status\" : 5\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<BlockchainDescription>(exampleJson)
            : default(BlockchainDescription);
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
        [Route("/v1/blockchain/create")]
        
        [SwaggerOperation("BlockchainCreatePost")]
        [ProducesResponseType(statusCode: 200, type: typeof(BlockchainDescription))]
        public virtual IActionResult BlockchainCreatePost([FromBody]BlockchainCreateOrUpdate body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(BlockchainDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"country\" : \"country\",\n  \"zipCode\" : \"zipCode\",\n  \"code\" : \"code\",\n  \"city\" : \"city\",\n  \"latitude\" : 6.0274563,\n  \"description\" : \"description\",\n  \"wifiPassword\" : \"wifiPassword\",\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"countryId\" : 0,\n  \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"useBlockchainTransactionLogo\" : true,\n  \"modifiedBy\" : \"modifiedBy\",\n  \"state\" : \"state\",\n  \"email\" : \"email\",\n  \"longitude\" : 1.4658129,\n  \"address\" : \"address\",\n  \"address2\" : \"address2\",\n  \"contactName\" : \"contactName\",\n  \"wifiSsid\" : \"wifiSsid\",\n  \"phone\" : \"phone\",\n  \"createdBy\" : \"createdBy\",\n  \"lastUpdate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"name\" : \"name\",\n  \"blockchainId\" : \"blockchainId\",\n  \"blockchainTransactionId\" : \"blockchainTransactionId\",\n  \"homepage\" : \"homepage\",\n  \"status\" : 5\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<BlockchainDescription>(exampleJson)
            : default(BlockchainDescription);
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
        [Route("/v1/blockchain/list")]
        
        [SwaggerOperation("BlockchainListGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(List<BlockchainDescription>))]
        public virtual IActionResult BlockchainListGet([FromQuery]int? skip, [FromQuery]int? limit, [FromQuery]string where)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<BlockchainDescription>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "[ {\n  \"country\" : \"country\",\n  \"zipCode\" : \"zipCode\",\n  \"code\" : \"code\",\n  \"city\" : \"city\",\n  \"latitude\" : 6.0274563,\n  \"description\" : \"description\",\n  \"wifiPassword\" : \"wifiPassword\",\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"countryId\" : 0,\n  \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"useBlockchainTransactionLogo\" : true,\n  \"modifiedBy\" : \"modifiedBy\",\n  \"state\" : \"state\",\n  \"email\" : \"email\",\n  \"longitude\" : 1.4658129,\n  \"address\" : \"address\",\n  \"address2\" : \"address2\",\n  \"contactName\" : \"contactName\",\n  \"wifiSsid\" : \"wifiSsid\",\n  \"phone\" : \"phone\",\n  \"createdBy\" : \"createdBy\",\n  \"lastUpdate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"name\" : \"name\",\n  \"blockchainId\" : \"blockchainId\",\n  \"blockchainTransactionId\" : \"blockchainTransactionId\",\n  \"homepage\" : \"homepage\",\n  \"status\" : 5\n}, {\n  \"country\" : \"country\",\n  \"zipCode\" : \"zipCode\",\n  \"code\" : \"code\",\n  \"city\" : \"city\",\n  \"latitude\" : 6.0274563,\n  \"description\" : \"description\",\n  \"wifiPassword\" : \"wifiPassword\",\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"countryId\" : 0,\n  \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"useBlockchainTransactionLogo\" : true,\n  \"modifiedBy\" : \"modifiedBy\",\n  \"state\" : \"state\",\n  \"email\" : \"email\",\n  \"longitude\" : 1.4658129,\n  \"address\" : \"address\",\n  \"address2\" : \"address2\",\n  \"contactName\" : \"contactName\",\n  \"wifiSsid\" : \"wifiSsid\",\n  \"phone\" : \"phone\",\n  \"createdBy\" : \"createdBy\",\n  \"lastUpdate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"name\" : \"name\",\n  \"blockchainId\" : \"blockchainId\",\n  \"blockchainTransactionId\" : \"blockchainTransactionId\",\n  \"homepage\" : \"homepage\",\n  \"status\" : 5\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<BlockchainDescription>>(exampleJson)
            : default(List<BlockchainDescription>);
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
        [Route("/v1/blockchain/update")]
        
        [SwaggerOperation("BlockchainUpdatePut")]
        [ProducesResponseType(statusCode: 200, type: typeof(BlockchainDescription))]
        public virtual IActionResult BlockchainUpdatePut([FromBody]BlockchainCreateOrUpdate body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(BlockchainDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"country\" : \"country\",\n  \"zipCode\" : \"zipCode\",\n  \"code\" : \"code\",\n  \"city\" : \"city\",\n  \"latitude\" : 6.0274563,\n  \"description\" : \"description\",\n  \"wifiPassword\" : \"wifiPassword\",\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"countryId\" : 0,\n  \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"useBlockchainTransactionLogo\" : true,\n  \"modifiedBy\" : \"modifiedBy\",\n  \"state\" : \"state\",\n  \"email\" : \"email\",\n  \"longitude\" : 1.4658129,\n  \"address\" : \"address\",\n  \"address2\" : \"address2\",\n  \"contactName\" : \"contactName\",\n  \"wifiSsid\" : \"wifiSsid\",\n  \"phone\" : \"phone\",\n  \"createdBy\" : \"createdBy\",\n  \"lastUpdate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"name\" : \"name\",\n  \"blockchainId\" : \"blockchainId\",\n  \"blockchainTransactionId\" : \"blockchainTransactionId\",\n  \"homepage\" : \"homepage\",\n  \"status\" : 5\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<BlockchainDescription>(exampleJson)
            : default(BlockchainDescription);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
