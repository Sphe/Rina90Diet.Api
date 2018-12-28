using System;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Dto
{
    public class AttachedDocumentDto
    {
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Data { get; set; }

        public DateTime Timestamp { get; set; }

    }
}
