using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using StudentENTITIES;

namespace StudentCORE.DataAccess.Abstract
{

    public interface IEntityRepository<T> where T : BaseEntity, new()
    {
        List<T> GetAllAsync();
        T Get(Expression<Func<T, bool>> filter);

        Task CreateAsync(T item);
        void UpdateAsync(T item);
        void DeleteAsync(T item);
        void Remove(Guid id);
        Task CreateRange(List<T> item);
        void UpdateRange(List<T> item);
        void DeleteRange(List<T> item);

        List<T> Where(Expression<Func<T, bool>> exp); 

        bool Any(Expression<Func<T, bool>> exp); 

        T FirstOrDefault(Expression<Func<T, bool>> exp); 

        T Find(Guid id); 

    }
}
