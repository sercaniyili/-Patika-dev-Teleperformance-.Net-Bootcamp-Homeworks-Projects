using Hafta5_Sercaniyili.Business.Abstract;
using Hafta5_Sercanİyili.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Hafta5_Sercaniyili.Business.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        protected AppDbContext _context { get; set; }

        public GenericRepository(AppDbContext context) => _context = context;


        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).AsNoTracking();
        }
    }
}
