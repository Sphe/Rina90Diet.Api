using Common.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Rina90Diet.Model.FullDomain;

namespace Rina90Diet.Data.FullDomain.Infrastructure
{
    public class Rina90DietDbFullDomainUnitOfWorkBase : UnitOfWorkBase<Rina90DietdbContext>, IRina90DietDbFullDomainUnitOfWork
    {
        private readonly Microsoft.Extensions.Logging.ILogger<Rina90DietDbFullDomainUnitOfWorkBase> _logger;

        public Rina90DietDbFullDomainUnitOfWorkBase(ILogger<Rina90DietDbFullDomainUnitOfWorkBase> logger,
            IDatabaseFactory<Rina90DietdbContext> databaseFactory)
            : base(databaseFactory)
        {
            _logger = logger;
        }

        public bool CommitHandled()
        {
            var errors = new List<Tuple<string, string>>();

            try
            {
                Commit();
            }
            catch (Exception e)
            {
                _logger.LogError(new EventId(370, "EntityFrameWork-Commit"), e, "Error during commit, not rethrowned.");
                return false;
            }

            return true;
        }

        public async Task<bool> CommitHandledAsync()
        {
            var errors = new List<Tuple<string, string>>();

            try
            {
                await DataContext.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                _logger.LogError(e.Message);

                if (e != null && e.InnerException != null)
                {
                    _logger.LogError(e.InnerException.Message);
                }

                return false;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return false;
            }
                
            return true;
        }
    }
}
