using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Dto
{
    public class SearchResultDto
    {
        public string Identifier { get; set; }

        public string Type { get; set; }

        public string PrefLabel { get; set; }

        public List<string> AltLabels { get; set; }

        public string Definition { get; set; }

        public List<string> LinkedDataUris { get; set; }

    }
}
