using System.Linq.Expressions;

namespace Hafta5_Sercaniyili.Business.Abstract
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
    }
}
