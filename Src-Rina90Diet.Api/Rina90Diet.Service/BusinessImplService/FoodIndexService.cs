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
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

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

        public async Task<SearchResultDto> GetByUri(string uri)
        {

            if (string.IsNullOrWhiteSpace(uri))
            {
                throw new Exception("No Uri Provided");
            }

            var res1 = await _elasticClient.SearchAsync<Dictionary<string, object>>(new SearchRequest<Dictionary<string, object>>(Indices.Parse("dbpediafoodindex_2019_02_hash"), Types.Parse("fooditem"))
            {

                Size = 1,
                From = 0,

                Query = new BoolQuery()
                {

                    Should = new List<QueryContainer>()
                    {

                        new TermQuery()
                        {
                            Field = "identifiersha1",
                            Value = GetHash(uri)
                        }

                    },

                    Boost = 1.0,
                    MinimumShouldMatch = 1

                }

            });

            if (res1 != null && res1.Hits != null && res1.Hits.Count > 0)
            {

                var jObj1 = res1.Hits.First().Source;

                var jU1 = MakeObj(jObj1);

                return jU1;
            }

            return null;

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
                                        Field = "label",
                                        Value = r1
                                    },
                                    new TermQuery()
                                    {
                                        Field = "name",
                                        Value = r1
                                    },
                                    new TermQuery()
                                    {
                                        Field = "name1",
                                        Value = r1
                                    },
                                    new TermQuery()
                                    {
                                        Field = "abstract",
                                        Value = r1
                                    },
                                    new TermQuery()
                                    {
                                        Field = "comment",
                                        Value = r1
                                    },
                                    new TermQuery()
                                    {
                                        Field = "altLabels",
                                        Value = r1
                                    },
                                    new WildcardQuery()
                                    {
                                        Field = "name",
                                        Value = string.Concat("*", r1, "*")
                                    },
                                    new WildcardQuery()
                                    {
                                        Field = "name1",
                                        Value = string.Concat("*", r1, "*")
                                    },
                                    new WildcardQuery()
                                    {
                                        Field = "abstract",
                                        Value = string.Concat("*", r1, "*")
                                    },
                                    new WildcardQuery()
                                    {
                                        Field = "comment",
                                        Value = string.Concat("*", r1, "*")
                                    },
                                    new WildcardQuery()
                                    {
                                        Field = "altLabels",
                                        Value = string.Concat("*", r1, "*")
                                    },
                                    new WildcardQuery()
                                    {
                                        Field = "label",
                                        Value = string.Concat("*", r1, "*")
                                    }

                                },

                        Boost = 1.0,
                        MinimumShouldMatch = 1

                    });
                }

                res1 = await _elasticClient.SearchAsync<Dictionary<string, object>>(new SearchRequest<Dictionary<string, object>>(Indices.Parse("dbpediafoodindex_2019_02_hash"), Types.Parse("fooditem"))
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
                res1 = await _elasticClient.SearchAsync<Dictionary<string, object>>(new SearchRequest<Dictionary<string, object>>(Indices.Parse("dbpediafoodindex_2019_02_hash"), Types.Parse("fooditem"))
                {

                    Size = size,
                    From = skip,

                    Query = new BoolQuery()
                    {

                        Should = new List<QueryContainer>()
                        {

                            new TermQuery()
                            {
                                Field = "label",
                                Value = xyz
                            },
                            new TermQuery()
                            {
                                Field = "name",
                                Value = xyz
                            },
                            new TermQuery()
                            {
                                Field = "name1",
                                Value = xyz
                            },
                            new TermQuery()
                            {
                                Field = "abstract",
                                Value = xyz
                            },
                            new TermQuery()
                            {
                                Field = "comment",
                                Value = xyz
                            },
                            new TermQuery()
                            {
                                Field = "altLabels",
                                Value = xyz
                            },
                            new WildcardQuery()
                            {
                                Field = "label",
                                Value = string.Concat("*", xyz, "*")
                            },
                            new WildcardQuery()
                            {
                                Field = "name",
                                Value = string.Concat("*", xyz, "*")
                            },
                            new WildcardQuery()
                            {
                                Field = "name1",
                                Value = string.Concat("*", xyz, "*")
                            },
                            new WildcardQuery()
                            {
                                Field = "abstract",
                                Value = string.Concat("*", xyz, "*")
                            },
                            new WildcardQuery()
                            {
                                Field = "comment",
                                Value = string.Concat("*", xyz, "*")
                            },
                            new WildcardQuery()
                            {
                                Field = "altLabels",
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

            var lstRelated = new List<string>();

            foreach (var h1 in res1.Hits)
            {
                var jObj1 = h1.Source;

                var jU1 = MakeObj(jObj1);

                resFinal.Results.Add(jU1);

            }

            //Enrich with related if num < requested size

            var distinctRelated = lstRelated.Distinct();

            if (resFinal.Results.Count < size && distinctRelated != null && distinctRelated.Count() > 0)
            {
                var lstQ1 = new List<QueryContainer>();

                foreach (var l1 in distinctRelated)
                {
                    lstQ1.Add(new TermQuery()
                    {
                        Field = "identifiersha1",
                        Value = GetHash(l1)
                    });
                }

                var resEnrich = await _elasticClient.SearchAsync<Dictionary<string, object>>(new SearchRequest<Dictionary<string, object>>(Indices.Parse("dbpediafoodindex_2019_02_hash"), Types.Parse("fooditem"))
                {

                    Size = size,
                    From = skip,

                    Query = new BoolQuery()
                    {

                        Should = lstQ1,
                        Boost = 1.0,
                        MinimumShouldMatch = 1

                    }


                });

                if (resEnrich == null || resEnrich.Hits == null || resEnrich.Hits.Count < 1)
                {
                }
                else
                {
                    foreach (var h1 in resEnrich.Hits)
                    {
                        var jObj1 = h1.Source;

                        var jU1 = MakeObj(jObj1);

                        resFinal.Results.Add(jU1);
                        resFinal.Count = resFinal.Count + 1;
                        resFinal.TotalCount = resFinal.TotalCount + 1;

                    }

                    if (resFinal.Count > size)
                    {
                        resFinal.Results = resFinal.Results.Take(size).ToList();
                        resFinal.Count = resFinal.Results.Count;
                    }
                }

            }

            return resFinal;

        }

        public SearchResultDto MakeObj(Dictionary<string, object> jObj1)
        {
            var jU1 = new SearchResultDto();

            if (jObj1.ContainsKey("abstract"))
            {
                jU1.Definition = jObj1["abstract"].ToString();
            }

            if (jObj1.ContainsKey("wasDerivedFrom"))
            {
                jU1.Source = jObj1["wasDerivedFrom"].ToString();
            }

            if (jObj1.ContainsKey("thumbnail"))
            {
                jU1.ImageUrl = jObj1["thumbnail"].ToString();
            }

            if (jObj1.ContainsKey("identifier"))
            {
                jU1.Identifier = jObj1["identifier"].ToString();
            }

            if (jObj1.ContainsKey("label"))
            {
                jU1.PrefLabel = jObj1["label"].ToString();
            }

            if (jObj1.ContainsKey("altLabels"))
            {
                var ja1 = jObj1["altLabels"] as JArray;

                if (ja1 != null)
                {
                    jU1.AltLabels = (ja1).ToObject<List<string>>().Select(x1 => WebUtility.UrlDecode(x1)).ToList();
                }

                var js1 = jObj1["altLabels"] as string;

                if (js1 != null)
                {
                    jU1.AltLabels = (new List<string>() { js1.ToString() }).Select(x1 => WebUtility.UrlDecode(x1)).ToList();
                }
            }

            if (jObj1.ContainsKey("protein"))
            {
                jU1.Protein = decimal.Parse(jObj1["protein"].ToString());
            }

            if (jObj1.ContainsKey("niacinMg"))
            {
                jU1.NiacinMg = decimal.Parse(jObj1["niacinMg"].ToString());
            }

            if (jObj1.ContainsKey("vitcMg"))
            {
                jU1.VitcMg = decimal.Parse(jObj1["vitcMg"].ToString());
            }

            if (jObj1.ContainsKey("fat"))
            {
                jU1.Fat = decimal.Parse(jObj1["fat"].ToString());
            }

            if (jObj1.ContainsKey("kj"))
            {
                jU1.Kj = decimal.Parse(jObj1["kj"].ToString());
            }

            if (jObj1.ContainsKey("ncbi"))
            {
                jU1.Ncbi = decimal.Parse(jObj1["ncbi"].ToString());
            }

            if (jObj1.ContainsKey("vitb6Mg"))
            {
                jU1.Vitb6Mg = decimal.Parse(jObj1["vitb6Mg"].ToString());
            }

            if (jObj1.ContainsKey("sourceUsda"))
            {
                jU1.SourceUsda = decimal.Parse(jObj1["sourceUsda"].ToString());
            }

            if (jObj1.ContainsKey("fiber"))
            {
                jU1.Fiber = decimal.Parse(jObj1["fiber"].ToString());
            }

            if (jObj1.ContainsKey("eol"))
            {
                jU1.Eol = decimal.Parse(jObj1["eol"].ToString());
            }

            if (jObj1.ContainsKey("phosphorusMg"))
            {
                jU1.PhosphorusMg = decimal.Parse(jObj1["phosphorusMg"].ToString());
            }

            if (jObj1.ContainsKey("betacaroteneUg"))
            {
                jU1.BetacaroteneUg = decimal.Parse(jObj1["betacaroteneUg"].ToString());
            }

            if (jObj1.ContainsKey("manganeseMg"))
            {
                jU1.ManganeseMg = decimal.Parse(jObj1["manganeseMg"].ToString());
            }

            if (jObj1.ContainsKey("luteinUg"))
            {
                jU1.LuteinUg = decimal.Parse(jObj1["luteinUg"].ToString());
            }

            if (jObj1.ContainsKey("carbs"))
            {
                jU1.Carbs = decimal.Parse(jObj1["carbs"].ToString());
            }

            if (jObj1.ContainsKey("viteMg"))
            {
                jU1.ViteMg = decimal.Parse(jObj1["viteMg"].ToString());
            }

            if (jObj1.ContainsKey("thiaminMg"))
            {
                jU1.ThiaminMg = decimal.Parse(jObj1["thiaminMg"].ToString());
            }

            if (jObj1.ContainsKey("vitaUg"))
            {
                jU1.VitaUg = decimal.Parse(jObj1["vitaUg"].ToString());
            }

            if (jObj1.ContainsKey("potassiumMg"))
            {
                jU1.PotassiumMg = decimal.Parse(jObj1["potassiumMg"].ToString());
            }

            if (jObj1.ContainsKey("water"))
            {
                jU1.Water = decimal.Parse(jObj1["water"].ToString());
            }

            if (jObj1.ContainsKey("magnesiumMg"))
            {
                jU1.MagnesiumMg = decimal.Parse(jObj1["magnesiumMg"].ToString());
            }

            if (jObj1.ContainsKey("vitkUg"))
            {
                jU1.VitkUg = decimal.Parse(jObj1["vitkUg"].ToString());
            }

            if (jObj1.ContainsKey("opt1v"))
            {
                jU1.Opt1v = decimal.Parse(jObj1["opt1v"].ToString());
            }

            if (jObj1.ContainsKey("sugars"))
            {
                jU1.Sugars = decimal.Parse(jObj1["sugars"].ToString());
            }

            return jU1;
        }

        public static string GetHash(string input)
        {

            using (var t1 = new MD5CryptoServiceProvider())
            {
                return string.Join("", (t1.ComputeHash(Encoding.UTF8.GetBytes(input))).Select(x => x.ToString("x2")).ToArray());
            }

        }


    }
}
