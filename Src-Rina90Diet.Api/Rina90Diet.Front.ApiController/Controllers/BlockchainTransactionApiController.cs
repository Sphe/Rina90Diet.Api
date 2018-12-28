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
    public class BlockchainTransactionApiController : Controller
    { 
        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="blockchainTransactionId"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/v1/blockchainTransaction/byId")]
        
        [SwaggerOperation("BlockchainTransactionByIdGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(BlockchainTransactionDescription))]
        public virtual IActionResult BlockchainTransactionByIdGet([FromQuery]string blockchainTransactionId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(BlockchainTransactionDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"code\" : \"code\",\n  \"facebookPage\" : \"facebookPage\",\n  \"contactName\" : \"contactName\",\n  \"description\" : \"description\",\n  \"isActive\" : true,\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"phone\" : \"phone\",\n  \"twitterPage\" : \"twitterPage\",\n  \"createdBy\" : \"createdBy\",\n  \"lastUpdate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"name\" : \"name\",\n  \"modifiedBy\" : \"modifiedBy\",\n  \"email\" : \"email\",\n  \"blockchainTransactionId\" : \"blockchainTransactionId\",\n  \"homepage\" : \"homepage\",\n  \"status\" : 0\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<BlockchainTransactionDescription>(exampleJson)
            : default(BlockchainTransactionDescription);
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
        [Route("/v1/blockchainTransaction/create")]
        
        [SwaggerOperation("BlockchainTransactionCreatePost")]
        [ProducesResponseType(statusCode: 200, type: typeof(BlockchainTransactionDescription))]
        public virtual IActionResult BlockchainTransactionCreatePost([FromBody]BlockchainTransactionCreateOrUpdate body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(BlockchainTransactionDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"code\" : \"code\",\n  \"facebookPage\" : \"facebookPage\",\n  \"contactName\" : \"contactName\",\n  \"description\" : \"description\",\n  \"isActive\" : true,\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"phone\" : \"phone\",\n  \"twitterPage\" : \"twitterPage\",\n  \"createdBy\" : \"createdBy\",\n  \"lastUpdate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"name\" : \"name\",\n  \"modifiedBy\" : \"modifiedBy\",\n  \"email\" : \"email\",\n  \"blockchainTransactionId\" : \"blockchainTransactionId\",\n  \"homepage\" : \"homepage\",\n  \"status\" : 0\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<BlockchainTransactionDescription>(exampleJson)
            : default(BlockchainTransactionDescription);
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
        [Route("/v1/blockchainTransaction/list")]
        
        [SwaggerOperation("BlockchainTransactionListGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(List<BlockchainTransactionDescription>))]
        public virtual IActionResult BlockchainTransactionListGet([FromQuery]int? skip, [FromQuery]int? limit, [FromQuery]string where)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<BlockchainTransactionDescription>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "[ {\n  \"code\" : \"code\",\n  \"facebookPage\" : \"facebookPage\",\n  \"contactName\" : \"contactName\",\n  \"description\" : \"description\",\n  \"isActive\" : true,\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"phone\" : \"phone\",\n  \"twitterPage\" : \"twitterPage\",\n  \"createdBy\" : \"createdBy\",\n  \"lastUpdate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"name\" : \"name\",\n  \"modifiedBy\" : \"modifiedBy\",\n  \"email\" : \"email\",\n  \"blockchainTransactionId\" : \"blockchainTransactionId\",\n  \"homepage\" : \"homepage\",\n  \"status\" : 0\n}, {\n  \"code\" : \"code\",\n  \"facebookPage\" : \"facebookPage\",\n  \"contactName\" : \"contactName\",\n  \"description\" : \"description\",\n  \"isActive\" : true,\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"phone\" : \"phone\",\n  \"twitterPage\" : \"twitterPage\",\n  \"createdBy\" : \"createdBy\",\n  \"lastUpdate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"name\" : \"name\",\n  \"modifiedBy\" : \"modifiedBy\",\n  \"email\" : \"email\",\n  \"blockchainTransactionId\" : \"blockchainTransactionId\",\n  \"homepage\" : \"homepage\",\n  \"status\" : 0\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<BlockchainTransactionDescription>>(exampleJson)
            : default(List<BlockchainTransactionDescription>);
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
        [Route("/v1/blockchainTransaction/update")]
        
        [SwaggerOperation("BlockchainTransactionUpdatePut")]
        [ProducesResponseType(statusCode: 200, type: typeof(BlockchainTransactionDescription))]
        public virtual IActionResult BlockchainTransactionUpdatePut([FromBody]BlockchainTransactionCreateOrUpdate body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(BlockchainTransactionDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"code\" : \"code\",\n  \"facebookPage\" : \"facebookPage\",\n  \"contactName\" : \"contactName\",\n  \"description\" : \"description\",\n  \"isActive\" : true,\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"phone\" : \"phone\",\n  \"twitterPage\" : \"twitterPage\",\n  \"createdBy\" : \"createdBy\",\n  \"lastUpdate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"name\" : \"name\",\n  \"modifiedBy\" : \"modifiedBy\",\n  \"email\" : \"email\",\n  \"blockchainTransactionId\" : \"blockchainTransactionId\",\n  \"homepage\" : \"homepage\",\n  \"status\" : 0\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<BlockchainTransactionDescription>(exampleJson)
            : default(BlockchainTransactionDescription);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
