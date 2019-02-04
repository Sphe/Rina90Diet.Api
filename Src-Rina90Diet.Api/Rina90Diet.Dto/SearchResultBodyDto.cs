using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Dto
{
    public class SearchResultBodyDto
    {

        public int Skip { get; set; }

        public int Count { get; set; }

        public long TotalCount { get; set; }

        public List<SearchResultDto> Results { get; set; }

    }
}
