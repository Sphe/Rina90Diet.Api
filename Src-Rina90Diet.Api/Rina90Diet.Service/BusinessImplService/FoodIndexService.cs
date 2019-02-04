using AutoMapper;
using Microsoft.Extensions.Logging;
using Nest;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Rina90Diet.Data.FullDomain.Infrastructure;
using Rina90Diet.Dto;
using Rina90Diet.Front.ApiWeb;
using Rina90Diet.Model.FullDomain;
using Rina90Diet.Service.BusinessImplService.Contract;
using Rina90Diet.Service.Contract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rina90Diet.Service.BusinessImplService
{
    public class FoodIndexService : IFoodIndexService
    {
        private readonly ILogger<FoodIndexService> _logger;

        private IElasticClient _elasticClient;

        public FoodIndexService(
            ILogger<FoodIndexService> logger,
            IElasticClient elasticClient)
        {
            _logger = logger;

            _elasticClient = elasticClient;
        }

        public void IndexJsonObject(IEnumerable<Dictionary<string, object>> obj1, string indexName, string type)
        {

            var bdesc = new BulkDescriptor();

            bdesc.IndexMany(obj1, (f, g) => f.Index(indexName).Type(type));

            var x = _elasticClient.Bulk(bdesc);

        }

        public async Task<SearchResultBodyDto> ExecuteSearch(string query, int size, int skip)
        {

            if (string.IsNullOrWhiteSpace(query))
            {
                return new SearchResultBodyDto()
                {
                    Count = 0,
                    Skip = 0,
                    TotalCount = 0,
                    Results = new List<SearchResultDto>()
                };
            }

            string xyz = query.ToLowerInvariant();
            xyz = string.Join(" ", xyz.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            ISearchResponse<Dictionary<string, object>> res1;

            if (xyz.Contains(' '))
            {

                var arRes1 = xyz.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var mustArr1 = new List<QueryContainer>();

                foreach (var r1 in arRes1)
                {
                    mustArr1.Add(new BoolQuery()
                    {

                        Should = new List<QueryContainer>()
                                {

                                    new TermQuery()
                                    {
                                        Field = "http://www.w3.org/2004/02/skos/core#prefLabel",
                                        Value = r1
                                    },
                                    new TermQuery()
                                    {
                                        Field = "http://www.w3.org/2004/02/skos/core#altLabel",
                                        Value = r1
                                    },
                                    new WildcardQuery()
                                    {
                                        Field = "http://www.w3.org/2004/02/skos/core#definition",
                                        Value = string.Concat("*", r1, "*")
                                    },
                                    new WildcardQuery()
                                    {
                                        Field = "http://www.w3.org/2004/02/skos/core#altLabel",
                                        Value = string.Concat("*", r1, "*")
                                    }

                                },

                        Boost = 1.0,
                        MinimumShouldMatch = 1

                    });
                }

                res1 = await _elasticClient.SearchAsync<Dictionary<string, object>>(new SearchRequest<Dictionary<string, object>>(Indices.Parse("foodthesaurusindex_try"), Types.Parse("fooditem"))
                {

                    Size = size,
                    From = skip,

                    Query = new BoolQuery()
                            {
                        
                                Should = mustArr1,

                                Boost = 1.0,
                                MinimumShouldMatch = 1

                            }


                });
            }
            else
            {
                res1 = await _elasticClient.SearchAsync<Dictionary<string, object>>(new SearchRequest<Dictionary<string, object>>(Indices.Parse("foodthesaurusindex_try"), Types.Parse("fooditem"))
                {

                    Size = size,
                    From = skip,

                    Query = new BoolQuery()
                    {

                        Should = new List<QueryContainer>()
                        {

                            new TermQuery()
                            {
                                Field = "http://www.w3.org/2004/02/skos/core#prefLabel",
                                Value = xyz
                            },
                            new TermQuery()
                            {
                                Field = "http://www.w3.org/2004/02/skos/core#altLabel",
                                Value = xyz
                            },
                            new WildcardQuery()
                            {
                                Field = "http://www.w3.org/2004/02/skos/core#definition",
                                Value = string.Concat("*", xyz, "*")
                            },
                            new WildcardQuery()
                            {
                                Field = "http://www.w3.org/2004/02/skos/core#altLabel",
                                Value = string.Concat("*", xyz, "*")
                            }

                        },
                        Boost = 1.0,
                        MinimumShouldMatch = 1

                    }


                });
            }

            var resFinal = new SearchResultBodyDto();

            resFinal.TotalCount = res1.Total;
            resFinal.Count = res1.Hits.Count;
            resFinal.Skip = skip;
            resFinal.Results = new List<SearchResultDto>();

            if (res1 == null || res1.Hits == null || res1.Hits.Count < 1)
            {
                return new SearchResultBodyDto()
                {
                    Count = 0,
                    Skip = 0,
                    TotalCount = 0,
                    Results = new List<SearchResultDto>()
                };
            }

            foreach (var h1 in res1.Hits)
            {
                var jObj1 = h1.Source;

                var jU1 = new SearchResultDto();

                if (jObj1.ContainsKey("http://www.w3.org/1999/02/22-rdf-syntax-ns#type"))
                {
                    jU1.Type = jObj1["http://www.w3.org/1999/02/22-rdf-syntax-ns#type"].ToString();
                }

                if (jObj1.ContainsKey("http://www.w3.org/2004/02/skos/core#definition"))
                {
                    jU1.Definition = jObj1["http://www.w3.org/2004/02/skos/core#definition"].ToString();
                }

                if (jObj1.ContainsKey("identifier"))
                {
                    jU1.Identifier = jObj1["identifier"].ToString();
                }

                if (jObj1.ContainsKey("http://www.w3.org/2004/02/skos/core#prefLabel"))
                {
                    jU1.PrefLabel = jObj1["http://www.w3.org/2004/02/skos/core#prefLabel"].ToString();
                }

                if (jObj1.ContainsKey("http://www.w3.org/2004/02/skos/core#altLabel"))
                {
                    var ja1 = jObj1["http://www.w3.org/2004/02/skos/core#altLabel"] as JArray;

                    if (ja1 != null)
                    {
                        jU1.AltLabels = (ja1).ToObject<List<string>>();
                    }
                    
                    var js1 = jObj1["http://www.w3.org/2004/02/skos/core#altLabel"] as string;

                    if (js1 != null)
                    {
                        jU1.AltLabels = new List<string>() { js1.ToString() };
                    }
                }

                if (jObj1.ContainsKey("http://purl.org/dc/terms/source"))
                {

                    var ja1 = jObj1["http://purl.org/dc/terms/source"] as JArray;

                    if (ja1 != null)
                    {
                        jU1.LinkedDataUris = (ja1).ToObject<List<string>>();
                    }

                    var js1 = jObj1["http://purl.org/dc/terms/source"] as string;

                    if (js1 != null)
                    {
                        jU1.LinkedDataUris = new List<string>() { js1.ToString() };
                    }

                }

                resFinal.Results.Add(jU1);

            }

            return resFinal;

        }


    }
}
