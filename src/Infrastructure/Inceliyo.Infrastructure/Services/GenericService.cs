using Inceliyo.Application.Interfaces.Repositories;
using Inceliyo.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Inceliyo.Infrastructure.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;
        private readonly IUnitOfWorks _unitOfWork;

        public GenericService(IGenericRepository<T> repository, IUnitOfWorks unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _unitOfWork.CommitAsync();
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            await _unitOfWork.CommitAsync();
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveAsync(T entity)
        {
            await _unitOfWork.CommitAsync();
            throw new NotImplementedException();
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities)
        {
            await _unitOfWork.CommitAsync();
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(T entity)
        {
            await _unitOfWork.CommitAsync();
            throw new NotImplementedException();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
