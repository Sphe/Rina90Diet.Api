﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Dto
{
    public class ContentblockDto : GenericDto
    {
        public ContentblockDto()
        {
        }


        public int Contentblockid { get; set; }
        public int? Contentblocktypeid { get; set; }
        public int? Pageid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Activate { get; set; }
        public int? Sort { get; set; }
        public string Content { get; set; }
        public int Cultureid { get; set; }

    }
}
