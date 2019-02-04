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
using VDS.RDF;
using VDS.RDF.Parsing;
using VDS.RDF.Nodes;
using System.IO;
using System.Linq;

namespace Rina90Diet.ApiController.Controllers
{ 

    public class FoodIndexApiController : Controller
    {
        private readonly IFoodIndexService _foodIndexService;

        private readonly HttpClient _httpClient;

        public FoodIndexApiController

            (
                 IFoodIndexService foodIndexService
            )

        {
            _foodIndexService = foodIndexService;

            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "YWxleGw6ZW5qb3kxMzJA");
            _httpClient.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");
        }

        [HttpGet]
        [Route("/v1/foodindex/search")]
        [SwaggerOperation("SearchFoodGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(object))]
        public virtual async Task<IActionResult> SearchFoodGet(
                [FromQuery]string query, [FromQuery]int skip = 0, [FromQuery]int count = 10)
        {

            var result1 = await _foodIndexService.ExecuteSearch(query, count, skip);

            return new ObjectResult(result1);
        }

        [HttpGet]
        [Route("/v1/foodindex/suggest")]
        [SwaggerOperation("SuggestFoodGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(object))]
        public virtual async Task<IActionResult> SuggestFoodGet(
                [FromQuery]string query)
        {
            return new ObjectResult(false);
        }

        [HttpGet]
        [Route("/v1/foodindex/recommand")]
        [SwaggerOperation("RecommandFoodGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(object))]
        public virtual async Task<IActionResult> RecommandFoodGet(
                [FromQuery]string query)
        {
            return new ObjectResult(false);
        }

        [HttpGet]
        [Route("/v1/foodindex/reindex")]
        [SwaggerOperation("ExtractReindexGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(object))]
        public virtual async Task<IActionResult> ExtractReindexGet()
        {
            var res1 = await _httpClient.GetStringAsync(
                "https://poolparty.payglx.com/PoolParty/api/projects/1E14681A-00B6-0001-A3C5-185314C017D6/export?format=turtle&exportModules=concepts");

            Graph g = new Graph();
            g.BaseUri = new Uri("https://ontology.rina90days.com/FoodExternalThesaurus");
            TurtleParser ttlparser = new TurtleParser();

            var finString = res1.Replace("http://%5Bhttp:/www.biomedcentral.com/1471-2229/10/6/abstract", "http://www.biomedcentral.com/1471-2229/10/6/abstract");
            finString = finString.Replace("http://hintmint.com)", "http://hintmint.com");
            finString = finString.Replace("http://www.military-nutrition.com''Website", "http://www.military-nutrition.com");
            finString = finString.Replace("http://www.cjingredient.com)", "http://www.cjingredient.com");
            finString = finString.Replace("http://Park_G%C3%BCell#mediaviewer/File:Parc_G%C3%BCell_Dragon_Restored.jpg", "http://mediaviewer.com/BCell_Dragon_Restored.jpg");

            finString = finString.Replace("http://www.casistar.ch)", "http://www.casistar.ch");
            finString = finString.Replace("http://www.meatprocessingforum.com,", "http://www.meatprocessingforum.com");
            finString = finString.Replace("http://www.pfaf.org).", "http://www.pfaf.org");
            finString = finString.Replace("http://plants.usda.gov).", "http://plants.usda.gov");




            ttlparser.Load(g, new StringReader(finString));

            var listDicoFinal = new List<Dictionary<string, object>>();

            var lstSubjects = g.Triples.SubjectNodes.ToList().Distinct();

            foreach (var subject1 in lstSubjects)
            {
                var tList1 = g.GetTriplesWithSubject(subject1);

                var dico1 = new List<KeyValuePair<string, object>>();

                foreach (var tl1 in tList1)
                {
                    dico1.Add(new KeyValuePair<string, object>(tl1.Predicate.ToString(), tl1.Object.AsValuedNode().AsString()));
                }

                var grp1 = dico1.GroupBy(x1 => x1.Key);

                var dicoCurs = new Dictionary<string, object>();

                foreach (var gp1 in grp1)
                {
                    if (gp1.Count() > 1)
                    {
                        dicoCurs.Add(gp1.Key, gp1.ToList().Select(x2 => x2.Value).ToArray());
                    }
                    else
                    {
                        dicoCurs.Add(gp1.Key, gp1.First().Value);
                    }
                }

                dicoCurs.Add("identifier", subject1.ToString());

                listDicoFinal.Add(dicoCurs);

                if (listDicoFinal.Count > 10)
                {
                    var ar1 = listDicoFinal.ToArray();

                    _foodIndexService.IndexJsonObject(ar1, "foodthesaurusindex_try", "fooditem");

                    listDicoFinal.Clear();
                }
            }

            return new ObjectResult(true);
        }

    }
}
