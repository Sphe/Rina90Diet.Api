using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Rina90Diet.Service;
using Rina90Diet.Service.Contract;
using Rina90Diet.Dto;
using AutoMapper;
using Rina90Diet.Data.FullDomain;
using Rina90Diet.Model.FullDomain;
using Rina90Diet.Front.ApiWeb;

namespace Rina90Diet.ApiController.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [EnableCors("SiteCorsPolicy")]
    public class AttributeApiController : Controller
    { 
        private readonly IAttributeService _attributeService;
        private readonly IDbContextService _dbContext;
        private readonly IMapper _mapper;

        public AttributeApiController(IAttributeService attributeService,
            IDbContextService dbContext, MapperConfiguration mapConfig)
        {
            _attributeService = attributeService;
            _dbContext = dbContext;
            _mapper = mapConfig.CreateMapper();
        }

        [HttpGet]
        [Route("/v1/attribute/list")]
        [SwaggerOperation("GenericAttributeDtoListGet")]
        [ProducesResponseType(typeof(List<GenericAttributeDto>), 200)]
        [Authorize(Roles = "attribute,attribute:list")]
        public virtual async Task<IActionResult> GenericAttributeDtoListGet([FromQuery]int start, [FromQuery]int size)
        {
            _dbContext.RefreshFullDomain();

            var l1 = await _attributeService.ListAttribute(size, start);

            return new ObjectResult(_mapper.Map<List<Genericattribute>, List<GenericAttributeDto>>(l1));
        }

        [HttpPost]
        [Route("/v1/attribute/get")]
        [SwaggerOperation("GenericAttributeDtoGet")]
        [ProducesResponseType(typeof(GenericAttributeDto), 200)]
        [Authorize(Roles = "attribute,attribute:get")]
        public virtual async Task<IActionResult> GenericAttributeDtoGet([FromBody]string type)
        {
            _dbContext.RefreshFullDomain();
            var custs = await _attributeService.CreateOrGetAttribute(type, null);
            return new ObjectResult(_mapper.Map<Genericattribute, GenericAttributeDto>(custs));
        }

        [HttpPost]
        [Route("/v1/attribute/getOrCreate")]
        [SwaggerOperation("GenericAttributeDtoCreateGet")]
        [ProducesResponseType(typeof(GenericAttributeDto), 200)]
        [Authorize(Roles = "attribute,attribute:create")]
        public virtual async Task<IActionResult> GenericAttributeDtoCreateGet([FromBody]string type, [FromBody]string value)
        {
            _dbContext.RefreshFullDomain();
            var custs = await _attributeService.CreateOrGetAttribute(type, value);
            return new ObjectResult(_mapper.Map<Genericattribute, GenericAttributeDto>(custs));
        }

    }
}
