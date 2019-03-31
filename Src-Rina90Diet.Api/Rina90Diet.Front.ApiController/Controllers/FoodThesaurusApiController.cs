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
using System.Linq;

namespace Rina90Diet.ApiController.Controllers
{ 

    public class FoodThesaurusApiController : Controller
    {

        private ITripleStoreCursorBusiness _tripleStoreCursorBusiness;
        private readonly IFoodIndexService _foodIndexService;
        private readonly HttpClient _httpClient;
        
        public FoodThesaurusApiController

            (
                 ITripleStoreCursorBusiness tripleStoreCursorBusiness,
                 IFoodIndexService foodIndexService
            )

        {
            _tripleStoreCursorBusiness = tripleStoreCursorBusiness;
            _foodIndexService = foodIndexService;

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

        [HttpPost]
        [Route("/v1/foodthesaurus/processtree")]
        [SwaggerOperation("ExtractFoodProcessTreeGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(object))]
        public virtual IActionResult ExtractFoodProcessTreeGet(
                [FromQuery]string uri, [FromQuery]int countRetry, [FromQuery]int broaderLevel)
        {

            var lstCount = _tripleStoreCursorBusiness.DoExtract(uri, countRetry, broaderLevel);

            var lstValues = lstCount.SelectMany(x1 => x1.Value);
            var lstKeys = lstCount.Select(x1 => x1.Key);

            var concat1 = lstValues.Concat(lstKeys).Distinct().ToList();

            Console.WriteLine("Number of items to index: " + concat1.Count());

            Console.WriteLine(string.Join(";", concat1));

            var lstElm1 = new List<string>();

            for (var i1 = 0; i1 < concat1.Count(); i1++)
            {
                lstElm1.Add(concat1[i1]);

                if (lstElm1.Count % 5 == 0)
                {
                    _tripleStoreCursorBusiness.IndexObjectsFromTriple(lstElm1);
                    lstElm1.Clear();
                }
            }

            if (lstElm1.Count > 0)
            {
                _tripleStoreCursorBusiness.IndexObjectsFromTriple(lstElm1);
            }

            return new ObjectResult(true);

        }

        [HttpGet]
        [Route("/v1/foodthesaurus/loadontology")]
        [SwaggerOperation("LoadOntologyGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(object))]
        public virtual IActionResult LoadOntologyGet(
               [FromQuery]string uri)
        {

            var res1 = _tripleStoreCursorBusiness.LoadOntologySubclass(uri);

            return new ObjectResult(res1);
        }

        [HttpGet]
        [Route("/v1/foodthesaurus/loadontologyalltree")]
        [SwaggerOperation("LoadOntologyGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(object))]
        public virtual IActionResult LoadOntologyAllTreeGet(
               [FromQuery]string uri)
        {

            var lstCount = new List<string>();

            _tripleStoreCursorBusiness.LoadAllTreeFromUri(uri, lstCount);

            return new ObjectResult(lstCount);
        }

        [HttpGet]
        [Route("/v1/foodthesaurus/extractBySubject")]
        [SwaggerOperation("ExtractBySubjectGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(object))]
        public virtual IActionResult ExtractBySubjectGet(
               [FromQuery]string uri)
        {

            var lstCount = new List<string>();

            _tripleStoreCursorBusiness.ExecuteSparqlAllEntities(uri, lstCount);

            return new ObjectResult(lstCount);
        }

    }
}
