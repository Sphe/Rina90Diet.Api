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
    public class BlockchainUserApiController : Controller
    { 
        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="blockchainBlockchainAssetId"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/v1/blockchainUser/byId")]
        
        [SwaggerOperation("BlockchainUserByIdGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(BlockchainUserDescription))]
        public virtual IActionResult BlockchainUserByIdGet([FromQuery]string blockchainBlockchainAssetId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(BlockchainUserDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"blockchainUserId\" : \"blockchainUserId\",\n  \"blockchainPublicKey\" : \"blockchainPublicKey\",\n  \"blockchainPrivateKey\" : \"blockchainPrivateKey\",\n  \"blockchainId\" : \"blockchainId\",\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<BlockchainUserDescription>(exampleJson)
            : default(BlockchainUserDescription);
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
        [Route("/v1/blockchainUser/create")]
        
        [SwaggerOperation("BlockchainUserCreatePost")]
        [ProducesResponseType(statusCode: 200, type: typeof(BlockchainUserDescription))]
        public virtual IActionResult BlockchainUserCreatePost([FromBody]BlockchainUserCreateOrUpdate body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(BlockchainUserDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"blockchainUserId\" : \"blockchainUserId\",\n  \"blockchainPublicKey\" : \"blockchainPublicKey\",\n  \"blockchainPrivateKey\" : \"blockchainPrivateKey\",\n  \"blockchainId\" : \"blockchainId\",\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<BlockchainUserDescription>(exampleJson)
            : default(BlockchainUserDescription);
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
        [Route("/v1/blockchainUser/list")]
        
        [SwaggerOperation("BlockchainUserListGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(List<BlockchainUserDescription>))]
        public virtual IActionResult BlockchainUserListGet([FromQuery]int? skip, [FromQuery]int? limit, [FromQuery]string where)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<BlockchainUserDescription>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "[ {\n  \"blockchainUserId\" : \"blockchainUserId\",\n  \"blockchainPublicKey\" : \"blockchainPublicKey\",\n  \"blockchainPrivateKey\" : \"blockchainPrivateKey\",\n  \"blockchainId\" : \"blockchainId\",\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}, {\n  \"blockchainUserId\" : \"blockchainUserId\",\n  \"blockchainPublicKey\" : \"blockchainPublicKey\",\n  \"blockchainPrivateKey\" : \"blockchainPrivateKey\",\n  \"blockchainId\" : \"blockchainId\",\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<BlockchainUserDescription>>(exampleJson)
            : default(List<BlockchainUserDescription>);
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
        [Route("/v1/blockchainUser/update")]
        
        [SwaggerOperation("BlockchainUserUpdatePut")]
        [ProducesResponseType(statusCode: 200, type: typeof(BlockchainUserDescription))]
        public virtual IActionResult BlockchainUserUpdatePut([FromBody]BlockchainUserCreateOrUpdate body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(BlockchainUserDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"blockchainUserId\" : \"blockchainUserId\",\n  \"blockchainPublicKey\" : \"blockchainPublicKey\",\n  \"blockchainPrivateKey\" : \"blockchainPrivateKey\",\n  \"blockchainId\" : \"blockchainId\",\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<BlockchainUserDescription>(exampleJson)
            : default(BlockchainUserDescription);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
