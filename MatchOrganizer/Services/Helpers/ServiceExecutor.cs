using Database;
using Microsoft.EntityFrameworkCore;
using Services.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Helpers
{
    public class ServiceExecutor<TDto, TEntity> : IServiceExecutor<TDto, TEntity> where TEntity : class
    {
        private readonly MatchOrganizerContext _context;
        public ServiceExecutor(MatchOrganizerContext context)
        {
            _context = context;
        }
        public async Task TryAdding(TDto dto, Predicate<TEntity> condition)
        {
            TEntity dbEntity = await GetSingleOrDefault(condition);
            await _context.Set<TEntity>().AddAsync(Mapping.Mapper.Map<TEntity>(dto));
            await _context.SaveChangesAsync();
        }

        public async Task TryDeleting(TEntity entity)
        {

            await _context.SaveChangesAsync();
        }
   
        public async Task<IList<TDto>> TryGettingAll(Predicate<TEntity> condition)
        {
            return await _context.Set<TEntity>().Where(x => condition(x)).Select(x => Mapping.Mapper.Map<TDto>(x)).ToListAsync();
        }

        public async Task<TDto> TryGettingOne(Predicate<TEntity> condition)
        {
            var entity = await GetSingleOrDefault(condition);
            return Mapping.Mapper.Map<TDto>(entity);
        }

        public async Task TryUpdating(TDto dto, Predicate<TEntity> condition)
        {
            var dbEntity = await GetSingleOrDefault(condition);
            Mapping.Mapper.Map<TDto, TEntity>(dto, dbEntity);
            await _context.SaveChangesAsync();
        }
        public async Task<TEntity> GetSingleOrDefault(Predicate<TEntity> condition)
        {
            return await _context.Set<TEntity>().Where(x => condition(x)).SingleAsync();
        }
    }
}
