using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rina90Diet.Data.FullDomain.Bulk
{
    public interface IRina90DietBulkOperator
    {
        Task BulkInsertBulkCopy<EntitySimple>(List<EntitySimple> list, IList<Tuple<string, string>> mappings, string destinationTable, int batchSize);
    }
}
