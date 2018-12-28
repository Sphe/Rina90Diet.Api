using Common.Core;
using Common.Data.Infrastructure;
using Rina90Diet.Model.FullDomain;

namespace Rina90Diet.Data.FullDomain.Infrastructure
{
    public class Rina90DietDbFullDomainDatabaseFactory : Disposable, IDatabaseFactory<Rina90DietdbContext>
    {
        private Rina90DietdbContext _dataContext;
        private readonly object _syncObject = new object();
        private readonly string _connectionString;

        public Rina90DietDbFullDomainDatabaseFactory(string connectionString)
        {
            _connectionString = connectionString;
            _dataContext = new Rina90DietdbContext(_connectionString);
        }

        public Rina90DietdbContext Get()
        {
            if (_dataContext != null)
            {
                lock (_syncObject)
                {
                    if (_dataContext != null)
                    {
                        return _dataContext;
                    }
                }
            }
            return null;
        }

        protected override void DisposeCore()
        {
            if (_dataContext != null)
            {
                _dataContext.Dispose();
            }
        }

        public void Refresh()
        {
            if (_dataContext != null)
            {
                lock (_syncObject)
                {
                    if (_dataContext != null)
                    {
                        _dataContext.Dispose();
                        _dataContext = new Rina90DietdbContext(_connectionString);
                    }
                }
            }
        }

        public string ConnectionString()
        {
            return _connectionString;
        }
    }
}
