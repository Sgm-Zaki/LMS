using LMS.BLL.Interface;
using LMS.DAL.Database;
using LMS.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BLL.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, new()
    {
        ApplicationContext _db = new ApplicationContext(); 
        public List<TEntity> GetAll()
        {
           var result = _db.Set<TEntity>().ToList();
            return result;
        }

        public TEntity GetBy(int id)
        {
           var result = _db.Set<TEntity>().Find(id);
            return result;
        }
        public void Create(TEntity entity)
        {
            //_db.Add(entity);  In case of Add, Update, Or remove, I can omit .Set<TEntity>
            _db.Set<TEntity>().Add(entity);
            _db.SaveChanges(); // After Add, Update, Or Remove, I must add SaveChanges()
        }

        public void Update(TEntity entity)
        {
            _db.Set<TEntity>().Update(entity);
            _db.SaveChanges(); //Commit
        }
        public void Delete(TEntity entity)
        {
            _db.Set<TEntity>().Remove(entity);
            _db.SaveChanges(); // Commit
        }

        // Async

        public async Task<List<TEntity>> GetAllAsync()
        {
            var result = await _db.Set<TEntity>().ToListAsync();
            return result;
        }

        public async Task<TEntity> GetByAsync(int id)
        {
            var result = await _db.Set<TEntity>().FindAsync(id);
            return result;
        }
        public async Task CreateAsync(TEntity entity)
        {
            //_db.Add(entity);  In case of Add, Update, Or remove, I can omit .Set<TEntity>
            await _db.Set<TEntity>().AddAsync(entity);
            _db.SaveChanges(); // After Add, Update, Or Remove, I must add SaveChanges()
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _db.Set<TEntity>().Update(entity);
            await _db.SaveChangesAsync(); //Commit
        }
        public async Task DeleteAsync(TEntity entity)
        {
            _db.Set<TEntity>().Remove(entity);
            await _db.SaveChangesAsync(); // Commit
        }

    }
}
