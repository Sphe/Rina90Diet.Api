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

        public string Source { get; set; }

        public string ImageUrl { get; set; }

        public decimal Protein { get; set; }

        public decimal NiacinMg { get; set; }

        public decimal VitcMg { get; set; }

        public decimal Fat { get; set; }

        public decimal Kj { get; set; }

        public decimal Ncbi { get; set; }

        public decimal Vitb6Mg { get; set; }

        public decimal SourceUsda { get; set; }

        public decimal Fiber { get; set; }

        public decimal Eol { get; set; }

        public decimal PhosphorusMg { get; set; }

        public decimal BetacaroteneUg { get; set; }

        public decimal ManganeseMg { get; set; }

        public decimal LuteinUg { get; set; }

        public decimal Carbs { get; set; }

        public decimal ViteMg { get; set; }

        public decimal ThiaminMg { get; set; }

        public decimal VitaUg { get; set; }

        public decimal PotassiumMg { get; set; }

        public decimal Water { get; set; }

        public decimal MagnesiumMg { get; set; }

        public decimal VitkUg { get; set; }

        public decimal Opt1v { get; set; }

        public decimal Sugars { get; set; }

    }
}
