using Common.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rina90Diet.Data.FullDomain.Infrastructure
{
    public interface IRina90DietDbFullDomainRepository<T> : IRepository<T> 
        where T : class
    {
    }
}
