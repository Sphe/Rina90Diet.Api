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
    public class BlockchainAssetApiController : Controller
    { 
        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="blockchainBlockchainAssetId"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/v1/blockchainAsset/byId")]
        
        [SwaggerOperation("BlockchainAssetByIdGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(BlockchainAssetDescription))]
        public virtual IActionResult BlockchainAssetByIdGet([FromQuery]string blockchainBlockchainAssetId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(BlockchainAssetDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"blockchainUserId\" : \"blockchainUserId\",\n  \"blockchainBlockchainAssetId\" : \"blockchainBlockchainAssetId\",\n  \"blockchainBlockchainAssetLabel\" : \"blockchainBlockchainAssetLabel\",\n  \"name\" : \"name\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"blockchainBlockchainAssetSymbol\" : \"blockchainBlockchainAssetSymbol\",\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<BlockchainAssetDescription>(exampleJson)
            : default(BlockchainAssetDescription);
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
        [Route("/v1/blockchainAsset/create")]
        
        [SwaggerOperation("BlockchainAssetCreatePost")]
        [ProducesResponseType(statusCode: 200, type: typeof(BlockchainAssetDescription))]
        public virtual IActionResult BlockchainAssetCreatePost([FromBody]BlockchainAssetCreateOrUpdate body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(BlockchainAssetDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"blockchainUserId\" : \"blockchainUserId\",\n  \"blockchainBlockchainAssetId\" : \"blockchainBlockchainAssetId\",\n  \"blockchainBlockchainAssetLabel\" : \"blockchainBlockchainAssetLabel\",\n  \"name\" : \"name\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"blockchainBlockchainAssetSymbol\" : \"blockchainBlockchainAssetSymbol\",\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<BlockchainAssetDescription>(exampleJson)
            : default(BlockchainAssetDescription);
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
        [Route("/v1/blockchainAsset/list")]
        
        [SwaggerOperation("BlockchainAssetListGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(List<BlockchainAssetDescription>))]
        public virtual IActionResult BlockchainAssetListGet([FromQuery]int? skip, [FromQuery]int? limit, [FromQuery]string where)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<BlockchainAssetDescription>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "[ {\n  \"blockchainUserId\" : \"blockchainUserId\",\n  \"blockchainBlockchainAssetId\" : \"blockchainBlockchainAssetId\",\n  \"blockchainBlockchainAssetLabel\" : \"blockchainBlockchainAssetLabel\",\n  \"name\" : \"name\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"blockchainBlockchainAssetSymbol\" : \"blockchainBlockchainAssetSymbol\",\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}, {\n  \"blockchainUserId\" : \"blockchainUserId\",\n  \"blockchainBlockchainAssetId\" : \"blockchainBlockchainAssetId\",\n  \"blockchainBlockchainAssetLabel\" : \"blockchainBlockchainAssetLabel\",\n  \"name\" : \"name\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"blockchainBlockchainAssetSymbol\" : \"blockchainBlockchainAssetSymbol\",\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<BlockchainAssetDescription>>(exampleJson)
            : default(List<BlockchainAssetDescription>);
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
        [Route("/v1/blockchainAsset/update")]
        
        [SwaggerOperation("BlockchainAssetUpdatePut")]
        [ProducesResponseType(statusCode: 200, type: typeof(BlockchainAssetDescription))]
        public virtual IActionResult BlockchainAssetUpdatePut([FromBody]BlockchainAssetCreateOrUpdate body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(BlockchainAssetDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"blockchainUserId\" : \"blockchainUserId\",\n  \"blockchainBlockchainAssetId\" : \"blockchainBlockchainAssetId\",\n  \"blockchainBlockchainAssetLabel\" : \"blockchainBlockchainAssetLabel\",\n  \"name\" : \"name\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"blockchainBlockchainAssetSymbol\" : \"blockchainBlockchainAssetSymbol\",\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<BlockchainAssetDescription>(exampleJson)
            : default(BlockchainAssetDescription);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
