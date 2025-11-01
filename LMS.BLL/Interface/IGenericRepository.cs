using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BLL.Interface
{
    public interface IGenericRepository<TEntity> where TEntity : class, new()
    {
        public List<TEntity> GetAll();
        public TEntity GetBy(int id);
        public void Create(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(TEntity entity);
    }
}
