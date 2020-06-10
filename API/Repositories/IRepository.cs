using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IRepository<T> where T : BaseIdEntity<int>
    {
        Task AddAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task DeleteAsync(T entity);
        Task<List<T>> GetAllAsync();
        Task UpdateAsync(T entity);
    }
}
