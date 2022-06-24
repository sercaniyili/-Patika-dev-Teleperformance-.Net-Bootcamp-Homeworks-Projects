using Hafta5_Sercaniyili.Business.Abstract;
using Hafta5_Sercaniyili.Entities;
using Hafta5_Sercaniyili.Entities.Data;
using Hafta5_Sercanİyili.DataAccess;

namespace Hafta5_Sercaniyili.Business.Concrete
{
    public class UserRepository : GenericRepository<AppUser>, IUserRepository
    {
        public UserRepository(AppDbContext _context) : base(_context) { }

        public Task<PagedList<AppUser>> GetAllUsers(UserParameters parameters)
        {
            var users = FindByCondition(x => x.Birthdate.Value.Year <= parameters.MinYearOfBirth &&
            x.Birthdate.Value.Year <= parameters.MaxYearOfBirth);
                           

            return Task.FromResult
             (PagedList<AppUser>.ToPagedList(users.OrderBy(x=>x.UserName),parameters.PageNumber,parameters.PageSize));
        }

    }
}
