using Hafta5_Sercaniyili.Business.Abstract;
using Hafta5_Sercaniyili.Entities;
using Hafta5_Sercaniyili.Entities.Data;
using Hafta5_Sercanİyili.DataAccess;
using Hafta5_Sercanİyili.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using System.Text;
using System.Text.Json;

namespace Hafta5_Sercanİyili.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IMemoryCache _memoryCache;
        private readonly IDistributedCache _distributedCache;
        private readonly AppDbContext _appDbContext;
        private readonly IUserRepository _userRepository;

        public UserController(IMemoryCache memoryCache, AppDbContext appDbContext, IDistributedCache distributedCache, IUserRepository userRepository) =>
            (_memoryCache, _appDbContext, _distributedCache,_userRepository) = (memoryCache, appDbContext, distributedCache,userRepository);


        //Kullanıcıların hepsini gösteren metod, in memory cache'de varsa oradan erişim yoksa veri tabınından
        //User/Users
        [HttpGet]
        [Route("Users")]
        public async Task<IActionResult> GetAllUsersByMemoryCache()
        {
            const string key = "userList";

            if (!_memoryCache.TryGetValue(key, out List<AppUser> users))
            {
                users = await _appDbContext.Users.ToListAsync();

                var cacheEntryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(1),
                    SlidingExpiration = TimeSpan.FromSeconds(45),
                    Priority=CacheItemPriority.Normal
                };
                    _memoryCache.Set(key, users, cacheEntryOptions);
            };
            return Ok(users);
        }


        //Kullanıcıların hepsini gösteren metod, disributed cache olarak redis'de varsa oradan erişim yoksa veri tabınından
        //User/Users
        [HttpGet]
        [Route("UsersByRedis")]
        public async Task<IActionResult> GetAllUsersByRedisCache()
        {
            var key = "userList";
            string serializedUsers;

            var users = new List<AppUser>();
            var redisUser = await _distributedCache.GetAsync(key);
            if (redisUser != null)
            {
                serializedUsers = Encoding.UTF8.GetString(redisUser);
                users = JsonSerializer.Deserialize<List<AppUser>>(serializedUsers);
            }
            else
            {
                users = await _appDbContext.Users.ToListAsync();
                serializedUsers = JsonSerializer.Serialize(users);
                redisUser = Encoding.UTF8.GetBytes(serializedUsers);
                var options = new DistributedCacheEntryOptions()
                    .SetAbsoluteExpiration(DateTime.Now.AddMinutes(1))
                    .SetSlidingExpiration(TimeSpan.FromSeconds(30));
                await _distributedCache.SetAsync(key, redisUser, options);
            }
            return Ok(users);
        }

        //Kullanıcıları listeleme işlemi için paging, search ve filtreleme işlemlerini içerek bir endpoint
        //User/UsersbyQuery
        [HttpGet]
        [Route("UsersbyQuery")]
        public IActionResult GetAllUsersByMemoryCache([FromQuery] UserParameters parameters)
        {
            var users = _userRepository.GetAllUsers(parameters);

            var metadata = new
            {
                users.Result.TotalCount,
                users.Result.PageSize,
                users.Result.CurrentPage,
                users.Result.TotalPages,
                users.Result.HasNext,
                users.Result.HasPrevious
            };

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(metadata));
             return Ok(users);
        }
    }


         
}
