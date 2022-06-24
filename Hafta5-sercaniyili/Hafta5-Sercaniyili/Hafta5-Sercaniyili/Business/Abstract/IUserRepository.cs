using Hafta5_Sercaniyili.Entities;
using Hafta5_Sercaniyili.Entities.Data;

namespace Hafta5_Sercaniyili.Business.Abstract
{
    public interface IUserRepository : IRepository<AppUser>
    {
        Task<PagedList<AppUser>> GetAllUsers(UserParameters parameters);
    }
}
