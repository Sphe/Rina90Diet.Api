using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rina90Diet.Common.Core;
using Rina90Diet.Data.FullDomain.Infrastructure;
using Rina90Diet.Dto;
using Rina90Diet.Model.FullDomain;
using Rina90Diet.Service.BusinessImplService.Contract;

namespace Rina90Diet.Service.BusinessImplService
{

    public class GenericCrudService<TD, T> : IGenericCrudService<TD, T>
        where TD: GenericDto
        where T : BaseEntity, new()
    {
        private readonly IRina90DietDbFullDomainRepository<T> _genRepository;
        private readonly IRina90DietDbFullDomainUnitOfWork _unitOfWork;

        private readonly ILogger<GenericCrudService<TD, T>> _logger;

        private IMapper _mapper;

        public GenericCrudService(ILogger<GenericCrudService<TD, T>> logger,
            IRina90DietDbFullDomainRepository<T> genRepository,
            IRina90DietDbFullDomainUnitOfWork unitOfWork,
            MapperConfiguration mapperConfiguration)
        {
            _logger = logger;

            _genRepository = genRepository;
            _unitOfWork = unitOfWork;

            _mapper = mapperConfiguration.CreateMapper();
        }

        public async Task<TD> CreateAsync(TD pDto, Func<T, bool> keyPredicate)
        {
            Check.Require(pDto != null, "entity must be valid.");

            var now = DateTime.UtcNow;

            var p0 = new T();

            var p = _mapper.Map<TD, T>(pDto, p0);
            p.Createdon = now;
            p.Modifiedon = now;
            p.Createdby = "System";
            p.Modifiedby = "System";

            var up1 = await _genRepository.AddAsync(p);

            var errors = await _unitOfWork.CommitHandledAsync();

            if (!errors)
            {
                _logger.LogError($"Can't create ! {JsonConvert.SerializeObject(p, Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore })} ");
            }

            return _mapper.Map<T, TD>(up1);
        }

        public async Task<TD> UpdateAsync(TD c1, Func<T, bool> keyPredicate)
        {
            Check.Require(c1 != null, "PageDto must exist.");

            var p1 = _genRepository.DbSet
                .Where(keyPredicate).First();

            Check.Require(p1 != null, "Entity must exist.");
            
            var createdOn1 = p1.Createdon;
            var createdBy1 = p1.Createdby;

            var updatedEntity = _mapper.Map(c1, p1);

            var now = DateTime.UtcNow;

            p1.Modifiedon = now;
            p1.Createdby = createdBy1;
            p1.Createdon = createdOn1;

            await _genRepository.UpdateAsync(p1);

            var errors = await _unitOfWork.CommitHandledAsync();

            if (!errors)
            {
                _logger.LogError($"Can't update ! {JsonConvert.SerializeObject(p1, Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore })} ");
            }

            return _mapper.Map<T, TD>(p1);
        }

        public async Task DeleteAsync(TD c1, Func<T, bool> keyPredicate)
        {
            Check.Require(c1 != null, "Dto must exist.");

            var p1 = _genRepository.DbSet
                .Where(keyPredicate).First();

            Check.Require(p1 != null, "Entity must exist.");
            
            await _genRepository.DeleteAsync(p1);

            var errors = await _unitOfWork.CommitHandledAsync();

            if (!errors)
            {
                _logger.LogError($"Can't delete ! {JsonConvert.SerializeObject(p1, Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore })} ");
            }
        }

        public async Task<IList<TD>> GetAllAsync(Func<DbSet<T>, IQueryable<T>> selectIncludes = null)
        {
            return await Task.Run(() =>
            {
                List<T> pRes;

                if (selectIncludes != null)
                {
                    var testF1 = selectIncludes(_genRepository.DbSet);
                    pRes = testF1 != null ? testF1.ToList() : Enumerable.Empty<T>().ToList();
                }
                else
                {
                    pRes = _genRepository.DbSet.ToList();
                }

                return _mapper.Map<List<T>, List<TD>>(pRes);
            });
        }

        public async Task<TD> GetSingleByPredicateAsync(Func<T, bool> predicate, Func<DbSet<T>, IQueryable<T>> selectIncludes = null)
        {

            return await Task.Run(() =>
            {
                T pRes;

                if (selectIncludes != null)
                {
                    pRes = selectIncludes(_genRepository.DbSet).Where(predicate).First();
                }
                else
                {
                    pRes = _genRepository.DbSet.Where(predicate).First();
                }

                return _mapper.Map<T, TD>(pRes);
            });
        }

        public async Task<List<TD>> GetListByPredicateAsync(Func<T, bool> predicate, Func<DbSet<T>, IQueryable<T>> selectIncludes = null)
        {

            return await Task.Run(() =>
            {
                List<T> pRes;

                if (selectIncludes != null)
                {
                    pRes = selectIncludes(_genRepository.DbSet).Where(predicate).ToList();
                }
                else
                {
                    pRes = _genRepository.DbSet.Where(predicate).ToList();
                }

                return _mapper.Map<List<T>, List<TD>>(pRes);
            });
        }
    }
}
