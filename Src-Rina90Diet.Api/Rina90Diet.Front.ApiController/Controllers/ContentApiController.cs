using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Rina90Diet.Service.Contract;
using Rina90Diet.Dto;
using Rina90Diet.Data.FullDomain;
using Rina90Diet.Service.BusinessImplService.Contract;
using Microsoft.EntityFrameworkCore;
using IO.Swagger.Models;
using Newtonsoft.Json;
using Rina90Diet.Model.FullDomain;
using Rina90Diet.Front.ApiWeb;

namespace Rina90Diet.ApiController.Controllers
{

    public class ContentApiController : Controller
    {

        private readonly IGenericCrudService<ContentblockDto, Contentblock> _genService;
        private readonly IDbContextService _dbContext;

        public ContentApiController(
                IGenericCrudService<ContentblockDto, Contentblock> genService,
                IDbContextService dbContext)
        {
            _genService = genService;
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("/v1/Contentblock/byId")]
        [SwaggerOperation("ContentByIdGet")]
        [ProducesResponseType(typeof(ContentblockDto), 200)]
        public virtual async Task<IActionResult> ContentblockByIdGet([FromQuery]string ContentblockId)
        {
            _dbContext.RefreshFullDomain();
            var workflowById = await _genService.GetSingleByPredicateAsync((x => {
                return x.Contentblockid.ToString() == ContentblockId;
            }), d =>
            {
                return d.Include("Contentblockimagemap")
                .Include("Contentblockimagemap.Image");
            });
            return new ObjectResult(workflowById);
        }

        [HttpGet]
        [Route("/v1/Contentblock/list")]
        [SwaggerOperation("ContentblockListGet")]
        [ProducesResponseType(typeof(List<ContentblockDto>), 200)]
        public virtual async Task<IActionResult> ContentblockListGet([FromQuery]int skip = 0, [FromQuery]int take = 100)
        {
            _dbContext.RefreshFullDomain();
            var workflowById = await _genService.GetAllAsync();
            return new ObjectResult(workflowById.Skip(skip).Take(take));
        }

        [HttpPost]
        [Route("/v1/Contentblock/create")]
        [SwaggerOperation("ContentblockCreatePost")]
        [ProducesResponseType(typeof(ContentblockDto), 200)]
        public virtual async Task<IActionResult> ContentblockCreatePost([FromBody]ContentblockDto body)
        {
            _dbContext.RefreshFullDomain();
            var workflowById = await _genService.CreateAsync(body, (x => { return x.Contentblockid == body.Contentblockid; }));
            return new ObjectResult(workflowById);
        }

        [HttpPost]
        [Route("/v1/Contentblock/update")]
        [SwaggerOperation("ContentblockUpdatePost")]
        [ProducesResponseType(typeof(ContentblockDto), 200)]
        public virtual async Task<IActionResult> ContentblockUpdatePost([FromBody]ContentblockDto body)
        {
            _dbContext.RefreshFullDomain();
            var workflowById = await _genService.UpdateAsync(body, (x => { return x.Contentblockid == body.Contentblockid; }));
            return new ObjectResult(workflowById);
        }

        [HttpDelete]
        [Route("/v1/Contentblock/delete")]
        [SwaggerOperation("ContentblockDelete")]
        [ProducesResponseType(typeof(bool), 200)]
        public virtual async Task<IActionResult> ContentblockDelete([FromBody]ContentblockDto body)
        {
            _dbContext.RefreshFullDomain();
            await _genService.DeleteAsync(body, (x => { return x.Contentblockid == body.Contentblockid; }));
            return new ObjectResult(true);
        }

        /// <param name="contentId"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/v1/content/byId")]

        [SwaggerOperation("ContentByIdGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(ContentDescription))]
        public virtual IActionResult ContentByIdGet([FromQuery]string contentId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ContentDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"contentSymbol\" : \"contentSymbol\",\n  \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"createdBy\" : \"createdBy\",\n  \"kycprocessName\" : \"kycprocessName\",\n  \"contentId\" : \"contentId\",\n  \"modifiedBy\" : \"modifiedBy\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"contentLabel\" : \"contentLabel\",\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"contentName\" : \"contentName\"\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ContentDescription>(exampleJson)
            : default(ContentDescription);
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
        [Route("/v1/content/create")]

        [SwaggerOperation("ContentCreatePost")]
        [ProducesResponseType(statusCode: 200, type: typeof(ContentDescription))]
        public virtual IActionResult ContentCreatePost([FromBody]ContentCreateOrUpdate body)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ContentDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"contentSymbol\" : \"contentSymbol\",\n  \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"createdBy\" : \"createdBy\",\n  \"kycprocessName\" : \"kycprocessName\",\n  \"contentId\" : \"contentId\",\n  \"modifiedBy\" : \"modifiedBy\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"contentLabel\" : \"contentLabel\",\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"contentName\" : \"contentName\"\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ContentDescription>(exampleJson)
            : default(ContentDescription);
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
        [Route("/v1/content/list")]

        [SwaggerOperation("ContentListGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(List<ContentDescription>))]
        public virtual IActionResult ContentListGet([FromQuery]int? skip, [FromQuery]int? limit, [FromQuery]string where)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ContentDescription>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "[ {\n  \"contentSymbol\" : \"contentSymbol\",\n  \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"createdBy\" : \"createdBy\",\n  \"kycprocessName\" : \"kycprocessName\",\n  \"contentId\" : \"contentId\",\n  \"modifiedBy\" : \"modifiedBy\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"contentLabel\" : \"contentLabel\",\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"contentName\" : \"contentName\"\n}, {\n  \"contentSymbol\" : \"contentSymbol\",\n  \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"createdBy\" : \"createdBy\",\n  \"kycprocessName\" : \"kycprocessName\",\n  \"contentId\" : \"contentId\",\n  \"modifiedBy\" : \"modifiedBy\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"contentLabel\" : \"contentLabel\",\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"contentName\" : \"contentName\"\n} ]";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<ContentDescription>>(exampleJson)
            : default(List<ContentDescription>);
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
        [Route("/v1/content/update")]

        [SwaggerOperation("ContentUpdatePut")]
        [ProducesResponseType(statusCode: 200, type: typeof(ContentDescription))]
        public virtual IActionResult ContentUpdatePut([FromBody]ContentCreateOrUpdate body)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ContentDescription));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"contentSymbol\" : \"contentSymbol\",\n  \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"createdBy\" : \"createdBy\",\n  \"kycprocessName\" : \"kycprocessName\",\n  \"contentId\" : \"contentId\",\n  \"modifiedBy\" : \"modifiedBy\",\n  \"kycprocessId\" : \"kycprocessId\",\n  \"contentLabel\" : \"contentLabel\",\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"contentName\" : \"contentName\"\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ContentDescription>(exampleJson)
            : default(ContentDescription);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

    }
}
