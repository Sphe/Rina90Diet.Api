using Common.Data.Infrastructure;
using Rina90Diet.Front.ApiWeb;
using Rina90Diet.Model.FullDomain;

namespace Rina90Diet.Data.FullDomain.Infrastructure
{
    public class Rina90DietDbFullDomainRepositoryBase<T> : RepositoryBase<T, Rina90DietdbContext>, IRina90DietDbFullDomainRepository<T>
        where T : class
    {
        public Rina90DietDbFullDomainRepositoryBase(IDatabaseFactory<Rina90DietdbContext> databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
