using Database;
using Microsoft.EntityFrameworkCore;
using Services.AutoMapper;
using Services.ErrorHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Helpers
{
    public class ServiceExecutor<TDto, TEntity> : IServiceExecutor<TDto, TEntity> where TEntity : class
    {
        private readonly MatchOrganizerContext _context;
        private readonly IErrorHandler _errorHandler;

        public ServiceExecutor(MatchOrganizerContext context, IErrorHandler errorHandler)
        {
            _context = context;
            _errorHandler = errorHandler;
        }

        public async Task<Status> Add(TDto dto, Predicate<TEntity> condition)
        {
            try
            {
                return await TryAdd(dto, condition);
            }
            catch (Exception ex)
            {
                _errorHandler.Handle(ex);
                return Status.DatabaseError;
            }
        }

        public async Task<Status> Delete(TEntity entity)
        {
            try
            {
                return await TryDelete(entity);
            }
            catch (Exception ex)
            {
                _errorHandler.Handle(ex);
                return Status.DatabaseError;
            }
        }

        public async Task<List<TDto>> GetAll(Predicate<TEntity> condition)
        {
            try
            {
                return await TryGetAll(condition);
            }
            catch (Exception ex)
            {
                _errorHandler.Handle(ex);
                return new List<TDto>();
            }
        }

        public async Task<TDto> GetOne(Predicate<TEntity> condition)
        {
            try
            {
                return await TryGetOne(condition);
            }
            catch (Exception ex)
            {
                _errorHandler.Handle(ex);
                return default(TDto);
            }
        }

        public async Task<Status> Update(TDto dto, Predicate<TEntity> condition)
        {
            try
            {
                return await TryUpdate(dto, condition);
            }
            catch (Exception ex)
            {
                _errorHandler.Handle(ex);
                return Status.DatabaseError;
            }
        }

        public async Task<TEntity> GetSingleOrDefault(Predicate<TEntity> condition)
        {
            return await _context.Set<TEntity>().Where(x => condition(x)).SingleOrDefaultAsync();
        }


        #region methodExecution

        public async Task<Status> TryAdd(TDto dto, Predicate<TEntity> condition)
        {
            TEntity dbEntity = await GetSingleOrDefault(condition);
            if (dbEntity == null)
            {
                return Status.AlreadyExists;
            }
            await _context.Set<TEntity>().AddAsync(Mapping.Mapper.Map<TEntity>(dto));
            await _context.SaveChangesAsync();
            return Status.Success;
        }

        public async Task<Status> TryDelete(TEntity entity)
        {
            await _context.SaveChangesAsync();
            return Status.Success;
        }

        public async Task<List<TDto>> TryGetAll(Predicate<TEntity> condition)
        {

            return await _context.Set<TEntity>().Where(x => condition(x)).Select(x => Mapping.Mapper.Map<TDto>(x)).ToListAsync();

        }

        public async Task<TDto> TryGetOne(Predicate<TEntity> condition)
        {

            TEntity entity = await GetSingleOrDefault(condition);
            return Mapping.Mapper.Map<TDto>(entity);
        }

        public async Task<Status> TryUpdate(TDto dto, Predicate<TEntity> condition)
        {

            TEntity dbEntity = await GetSingleOrDefault(condition);
            if (dbEntity == null)
            {
                return Status.NotFound;
            }
            Mapping.Mapper.Map<TDto, TEntity>(dto, dbEntity);
            await _context.SaveChangesAsync();
            return Status.Success;
        }


        #endregion

    }
}
