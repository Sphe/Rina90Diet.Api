using Rina90Diet.Dto;
using Rina90Diet.Model.FullDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rina90Diet.Service.BusinessImplService.Contract
{
    public interface IFoodIndexService
    {
        void IndexJsonObject(IEnumerable<Dictionary<string, object>> obj1, string indexName, string type);

        Task<SearchResultBodyDto> ExecuteSearch(string query, int size, int skip);

        Task<SearchResultDto> GetByUri(string uri);
    }
}
