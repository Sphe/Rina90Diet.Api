using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Data.Infrastructure;
using Rina90Diet.Data.FullDomain;
using Rina90Diet.Model.FullDomain;
using Rina90Diet.Service.Contract;

namespace Rina90Diet.Service
{
    public class DbContextService : IDbContextService
    {
        private readonly IDatabaseFactory<Rina90DietdbContext> _databaseFactory;

        public DbContextService(IDatabaseFactory<Rina90DietdbContext> databaseFactory)
        {
            _databaseFactory = databaseFactory;
        }

        public void RefreshFullDomain()
        {
            _databaseFactory.Refresh();
        }
    }
}
