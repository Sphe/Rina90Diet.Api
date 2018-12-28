using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Rina90Diet.Service.Contract;
using Rina90Diet.Service.BusinessImplService.Contract;

namespace Rina90Diet.ApiController.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [EnableCors("SiteCorsPolicy")]
    public class BusinessApiController : Controller
    { 
        private readonly IRina90DietBusinessService _businessService;
        private readonly IDbContextService _dbContext;

        public BusinessApiController(IRina90DietBusinessService businessService, IDbContextService dbContext)
        {
            _businessService = businessService;
            _dbContext = dbContext;
        }

        
    }
}
