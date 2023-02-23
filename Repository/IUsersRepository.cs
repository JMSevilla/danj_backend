using System.Linq.Expressions;
using danj_backend.Data;
using danj_backend.Helper;
using danj_backend.Model;

namespace danj_backend.Repository
{
    public interface IUsersRepository<T> where T : class, IEntity {
       Task<T> AddUserAdmin(T entity);
       public T FindEmailExist(Expression<Func<T, bool>> predicate);
    }
}