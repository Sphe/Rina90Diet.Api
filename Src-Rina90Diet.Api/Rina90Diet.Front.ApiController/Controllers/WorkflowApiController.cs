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
    public class WorkflowApiController : Controller
    { 
        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="workflowId"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/v1/workflow/byId")]
        
        [SwaggerOperation("WorkflowByIdGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(WorkflowDescription))]
        public virtual IActionResult WorkflowByIdGet([FromQuery]string workflowId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(WorkflowDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"cultureId\" : \"cultureId\",\n  \"timeStamp\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"hasArguments\" : true,\n  \"name\" : \"name\",\n  \"description\" : \"description\",\n  \"arguments\" : {\n    \"key\" : \"{}\"\n  },\n  \"isEntryCoin\" : true,\n  \"body\" : \"body\",\n  \"workflowTypeId\" : \"workflowTypeId\",\n  \"workflowId\" : \"workflowId\",\n  \"categoryId\" : \"categoryId\",\n  \"isComponent\" : true\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<WorkflowDescription>(exampleJson)
            : default(WorkflowDescription);
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
        [Route("/v1/workflow/create")]
        
        [SwaggerOperation("WorkflowCreatePost")]
        [ProducesResponseType(statusCode: 200, type: typeof(WorkflowDescription))]
        public virtual IActionResult WorkflowCreatePost([FromBody]WorkflowCreateOrUpdate body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(WorkflowDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"cultureId\" : \"cultureId\",\n  \"timeStamp\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"hasArguments\" : true,\n  \"name\" : \"name\",\n  \"description\" : \"description\",\n  \"arguments\" : {\n    \"key\" : \"{}\"\n  },\n  \"isEntryCoin\" : true,\n  \"body\" : \"body\",\n  \"workflowTypeId\" : \"workflowTypeId\",\n  \"workflowId\" : \"workflowId\",\n  \"categoryId\" : \"categoryId\",\n  \"isComponent\" : true\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<WorkflowDescription>(exampleJson)
            : default(WorkflowDescription);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpPost]
        [Route("/v1/workflow/executeText")]
        
        [SwaggerOperation("WorkflowExecuteContentPost")]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public virtual IActionResult WorkflowExecuteContentPost()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Object));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "\"{}\"";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Object>(exampleJson)
            : default(Object);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="workflowId"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/v1/workflow/executeStored/byId")]
        
        [SwaggerOperation("WorkflowExecuteStoredByIdPost")]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public virtual IActionResult WorkflowExecuteStoredByIdPost([FromQuery]string workflowId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Object));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "\"{}\"";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Object>(exampleJson)
            : default(Object);
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
        [Route("/v1/workflow/execute")]
        
        [SwaggerOperation("WorkflowExecuteWithArgsPost")]
        [ProducesResponseType(statusCode: 200, type: typeof(Object))]
        public virtual IActionResult WorkflowExecuteWithArgsPost([FromBody]WorkflowExecutionWithArgs body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Object));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "\"{}\"";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Object>(exampleJson)
            : default(Object);
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
        [Route("/v1/workflow/list")]
        
        [SwaggerOperation("WorkflowListGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(List<WorkflowDescription>))]
        public virtual IActionResult WorkflowListGet([FromQuery]int? skip, [FromQuery]int? limit, [FromQuery]string where)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<WorkflowDescription>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "[ {\n  \"cultureId\" : \"cultureId\",\n  \"timeStamp\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"hasArguments\" : true,\n  \"name\" : \"name\",\n  \"description\" : \"description\",\n  \"arguments\" : {\n    \"key\" : \"{}\"\n  },\n  \"isEntryCoin\" : true,\n  \"body\" : \"body\",\n  \"workflowTypeId\" : \"workflowTypeId\",\n  \"workflowId\" : \"workflowId\",\n  \"categoryId\" : \"categoryId\",\n  \"isComponent\" : true\n}, {\n  \"cultureId\" : \"cultureId\",\n  \"timeStamp\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"hasArguments\" : true,\n  \"name\" : \"name\",\n  \"description\" : \"description\",\n  \"arguments\" : {\n    \"key\" : \"{}\"\n  },\n  \"isEntryCoin\" : true,\n  \"body\" : \"body\",\n  \"workflowTypeId\" : \"workflowTypeId\",\n  \"workflowId\" : \"workflowId\",\n  \"categoryId\" : \"categoryId\",\n  \"isComponent\" : true\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<WorkflowDescription>>(exampleJson)
            : default(List<WorkflowDescription>);
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
        [Route("/v1/workflow/update")]
        
        [SwaggerOperation("WorkflowUpdatePut")]
        [ProducesResponseType(statusCode: 200, type: typeof(WorkflowDescription))]
        public virtual IActionResult WorkflowUpdatePut([FromBody]WorkflowCreateOrUpdate body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(WorkflowDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"cultureId\" : \"cultureId\",\n  \"timeStamp\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"hasArguments\" : true,\n  \"name\" : \"name\",\n  \"description\" : \"description\",\n  \"arguments\" : {\n    \"key\" : \"{}\"\n  },\n  \"isEntryCoin\" : true,\n  \"body\" : \"body\",\n  \"workflowTypeId\" : \"workflowTypeId\",\n  \"workflowId\" : \"workflowId\",\n  \"categoryId\" : \"categoryId\",\n  \"isComponent\" : true\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<WorkflowDescription>(exampleJson)
            : default(WorkflowDescription);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
