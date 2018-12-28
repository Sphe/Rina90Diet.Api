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
    public class ClientMessagingApiController : Controller
    { 
        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="clientmessagingId"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/v1/clientmessaging/byId")]
        
        [SwaggerOperation("ClientMessagingByIdGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(ClientMessagingDescription))]
        public virtual IActionResult ClientMessagingByIdGet([FromQuery]string clientmessagingId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ClientMessagingDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"debitedCoins\" : 6.027456183070403,\n  \"redemptionId\" : \"redemptionId\",\n  \"clientmessagingId\" : \"clientmessagingId\",\n  \"clientmessagingedAmount\" : 0.8008281904610115,\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ClientMessagingDescription>(exampleJson)
            : default(ClientMessagingDescription);
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
        [Route("/v1/clientmessaging/create")]
        
        [SwaggerOperation("ClientMessagingCreatePost")]
        [ProducesResponseType(statusCode: 200, type: typeof(ClientMessagingDescription))]
        public virtual IActionResult ClientMessagingCreatePost([FromBody]ClientMessagingCreateOrUpdate body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ClientMessagingDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"debitedCoins\" : 6.027456183070403,\n  \"redemptionId\" : \"redemptionId\",\n  \"clientmessagingId\" : \"clientmessagingId\",\n  \"clientmessagingedAmount\" : 0.8008281904610115,\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ClientMessagingDescription>(exampleJson)
            : default(ClientMessagingDescription);
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
        [Route("/v1/clientmessaging/list")]
        
        [SwaggerOperation("ClientMessagingListGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(List<ClientMessagingDescription>))]
        public virtual IActionResult ClientMessagingListGet([FromQuery]int? skip, [FromQuery]int? limit, [FromQuery]string where)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ClientMessagingDescription>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "[ {\n  \"debitedCoins\" : 6.027456183070403,\n  \"redemptionId\" : \"redemptionId\",\n  \"clientmessagingId\" : \"clientmessagingId\",\n  \"clientmessagingedAmount\" : 0.8008281904610115,\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}, {\n  \"debitedCoins\" : 6.027456183070403,\n  \"redemptionId\" : \"redemptionId\",\n  \"clientmessagingId\" : \"clientmessagingId\",\n  \"clientmessagingedAmount\" : 0.8008281904610115,\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<ClientMessagingDescription>>(exampleJson)
            : default(List<ClientMessagingDescription>);
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
        [Route("/v1/clientmessaging/update")]
        
        [SwaggerOperation("ClientMessagingUpdatePut")]
        [ProducesResponseType(statusCode: 200, type: typeof(ClientMessagingDescription))]
        public virtual IActionResult ClientMessagingUpdatePut([FromBody]ClientMessagingCreateOrUpdate body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ClientMessagingDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"debitedCoins\" : 6.027456183070403,\n  \"redemptionId\" : \"redemptionId\",\n  \"clientmessagingId\" : \"clientmessagingId\",\n  \"clientmessagingedAmount\" : 0.8008281904610115,\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ClientMessagingDescription>(exampleJson)
            : default(ClientMessagingDescription);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
