using System;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Rina90Diet.Service;
using Rina90Diet.Service.Contract;
using Rina90Diet.Dto;
using Rina90Diet.Model.FullDomain;
using Rina90Diet.Service.BusinessImplService.Contract;
using System.Threading.Tasks;
using Rina90Diet.Front.ApiWeb;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Rina90Diet.ApiController.Controllers
{ 

    public class FoodThesaurusApiController : Controller
    {

        private readonly HttpClient _httpClient;

        public FoodThesaurusApiController

            (
                 
            )

        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "YWxleGw6ZW5qb3kxMzJA");
            _httpClient.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");
        }

        [HttpGet]
        [Route("/v1/foodthesaurus/extract")]
        [SwaggerOperation("ExtractFoodGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(object))]
        public virtual async Task<IActionResult> ExtractFoodGet(
                [FromQuery]string query)
        {
            var res1 = await _httpClient.GetStringAsync(
                $"https://poolparty.payglx.com/extractor/api/extract?text={query}&projectId=1E14681A-00B6-0001-A3C5-185314C017D6&language=en&categorizationWithPpxBoost=true&useRelatedConcepts=true&useTransitiveBroaderConcepts=true&useTransitiveBroaderTopConcepts=true");

            var r1 = JObject.Parse(res1);

            return new ObjectResult(r1);
        }

    }
}
