using Carosa.Entities;

namespace Carosa.Core.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Get(int id);
        bool Create(T entity);
        bool Remove(T entity);
        bool Update(T entity);
    }

}
