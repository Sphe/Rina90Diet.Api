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
    public class RegistryApiController : Controller
    { 
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
        [Route("/v1/registry/list")]
        
        [SwaggerOperation("KycProcessListGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(List<KycProcessDescription>))]
        public virtual IActionResult KycProcessListGet([FromQuery]int? skip, [FromQuery]int? limit, [FromQuery]string where)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<KycProcessDescription>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "[ {\n  \"iconSet\" : \"iconSet\",\n  \"productPictureInBase64\" : \"productPictureInBase64\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"brandUniverseDataString\" : \"brandUniverseDataString\",\n  \"emailRedeem\" : true,\n  \"picture\" : \"picture\",\n  \"textColorInHex\" : \"textColorInHex\",\n  \"primaryColorInHex\" : \"primaryColorInHex\",\n  \"websiteUrl\" : \"websiteUrl\",\n  \"name\" : \"name\",\n  \"coinLabel\" : \"coinLabel\",\n  \"logoInBase64\" : \"logoInBase64\",\n  \"userNumber\" : 0,\n  \"hasOneVoucherHack\" : true,\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}, {\n  \"iconSet\" : \"iconSet\",\n  \"productPictureInBase64\" : \"productPictureInBase64\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"brandUniverseDataString\" : \"brandUniverseDataString\",\n  \"emailRedeem\" : true,\n  \"picture\" : \"picture\",\n  \"textColorInHex\" : \"textColorInHex\",\n  \"primaryColorInHex\" : \"primaryColorInHex\",\n  \"websiteUrl\" : \"websiteUrl\",\n  \"name\" : \"name\",\n  \"coinLabel\" : \"coinLabel\",\n  \"logoInBase64\" : \"logoInBase64\",\n  \"userNumber\" : 0,\n  \"hasOneVoucherHack\" : true,\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<KycProcessDescription>>(exampleJson)
            : default(List<KycProcessDescription>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/v1/registry/byBlockchainUser")]
        
        [SwaggerOperation("RegistryByBlockchainUserGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(List<RegistryDescription>))]
        public virtual IActionResult RegistryByBlockchainUserGet([FromQuery]string id, [FromQuery]string name)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<RegistryDescription>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "[ {\n  \"keyValue\" : \"keyValue\",\n  \"itemValue\" : \"{}\",\n  \"name\" : \"name\",\n  \"registryGenericAttributeId\" : \"registryGenericAttributeId\",\n  \"genericAttributeId\" : \"genericAttributeId\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}, {\n  \"keyValue\" : \"keyValue\",\n  \"itemValue\" : \"{}\",\n  \"name\" : \"name\",\n  \"registryGenericAttributeId\" : \"registryGenericAttributeId\",\n  \"genericAttributeId\" : \"genericAttributeId\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<RegistryDescription>>(exampleJson)
            : default(List<RegistryDescription>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/v1/registry/byContent")]
        
        [SwaggerOperation("RegistryByContentIdGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(List<RegistryDescription>))]
        public virtual IActionResult RegistryByContentIdGet([FromQuery]string id, [FromQuery]string name)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<RegistryDescription>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "[ {\n  \"keyValue\" : \"keyValue\",\n  \"itemValue\" : \"{}\",\n  \"name\" : \"name\",\n  \"registryGenericAttributeId\" : \"registryGenericAttributeId\",\n  \"genericAttributeId\" : \"genericAttributeId\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}, {\n  \"keyValue\" : \"keyValue\",\n  \"itemValue\" : \"{}\",\n  \"name\" : \"name\",\n  \"registryGenericAttributeId\" : \"registryGenericAttributeId\",\n  \"genericAttributeId\" : \"genericAttributeId\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<RegistryDescription>>(exampleJson)
            : default(List<RegistryDescription>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/v1/registry/byBlockchainAsset")]
        
        [SwaggerOperation("RegistryByKycProcessIdGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(List<RegistryDescription>))]
        public virtual IActionResult RegistryByKycProcessIdGet([FromQuery]string id, [FromQuery]string name)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<RegistryDescription>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "[ {\n  \"keyValue\" : \"keyValue\",\n  \"itemValue\" : \"{}\",\n  \"name\" : \"name\",\n  \"registryGenericAttributeId\" : \"registryGenericAttributeId\",\n  \"genericAttributeId\" : \"genericAttributeId\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}, {\n  \"keyValue\" : \"keyValue\",\n  \"itemValue\" : \"{}\",\n  \"name\" : \"name\",\n  \"registryGenericAttributeId\" : \"registryGenericAttributeId\",\n  \"genericAttributeId\" : \"genericAttributeId\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<RegistryDescription>>(exampleJson)
            : default(List<RegistryDescription>);
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
        [Route("/v1/registry/create")]
        
        [SwaggerOperation("RegistryCreatePost")]
        [ProducesResponseType(statusCode: 200, type: typeof(RegistryDescription))]
        public virtual IActionResult RegistryCreatePost([FromBody]RegistryCreateOrUpdate body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(RegistryDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"keyValue\" : \"keyValue\",\n  \"itemValue\" : \"{}\",\n  \"name\" : \"name\",\n  \"registryGenericAttributeId\" : \"registryGenericAttributeId\",\n  \"genericAttributeId\" : \"genericAttributeId\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<RegistryDescription>(exampleJson)
            : default(RegistryDescription);
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
        [Route("/v1/registry/update")]
        
        [SwaggerOperation("RegistryUpdatePut")]
        [ProducesResponseType(statusCode: 200, type: typeof(RegistryDescription))]
        public virtual IActionResult RegistryUpdatePut([FromBody]RegistryCreateOrUpdate body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(RegistryDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"keyValue\" : \"keyValue\",\n  \"itemValue\" : \"{}\",\n  \"name\" : \"name\",\n  \"registryGenericAttributeId\" : \"registryGenericAttributeId\",\n  \"genericAttributeId\" : \"genericAttributeId\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<RegistryDescription>(exampleJson)
            : default(RegistryDescription);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/v1/registry/byBlockchain")]
        
        [SwaggerOperation("RegistrybyBlockchainGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(List<RegistryDescription>))]
        public virtual IActionResult RegistrybyBlockchainGet([FromQuery]string id, [FromQuery]string name)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<RegistryDescription>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "[ {\n  \"keyValue\" : \"keyValue\",\n  \"itemValue\" : \"{}\",\n  \"name\" : \"name\",\n  \"registryGenericAttributeId\" : \"registryGenericAttributeId\",\n  \"genericAttributeId\" : \"genericAttributeId\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}, {\n  \"keyValue\" : \"keyValue\",\n  \"itemValue\" : \"{}\",\n  \"name\" : \"name\",\n  \"registryGenericAttributeId\" : \"registryGenericAttributeId\",\n  \"genericAttributeId\" : \"genericAttributeId\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<RegistryDescription>>(exampleJson)
            : default(List<RegistryDescription>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
