using Hafta5_Sercaniyili.Business.Abstract;
using Hafta5_Sercaniyili.Business.Concrete;
using Hafta5_Sercaniyili.Entities.Data;
using Hafta5_Sercanİyili.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hafta5_Sercanİyili.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IRabbitmqService _rabbitmqMagager;

        public AccountController(IConfiguration configuration, UserManager<AppUser> userManager, IRabbitmqService rabbitmqMagager)
        {
            _configuration = configuration;
            _userManager = userManager;
            _rabbitmqMagager = rabbitmqMagager;
        }

        //Veri tabanına kullanıcı ekleyen metod
        //Account/Register
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] UserCreateDto model)
        {

            var user = await _userManager.FindByNameAsync(model.Username);
            if (user != null)
                return BadRequest("Kullanıcı zaten var");

            AppUser newUser = new AppUser
            {
                UserName = model.Username,
                Email = model.Email,
            };

            var result = await _userManager.CreateAsync(newUser, model.Password);
            if (!result.Succeeded)
                return BadRequest("Kullnanıcı oluşturulken hata oluştu");
            else
                // Kullanıcı oluşturulunca Rabbitmq kuyruk ekleniyor
                _rabbitmqMagager.Publish(newUser, "direct", "direct.test", "direct.queuName", "direct.test.key");

            return Ok(model);
        }


        //Oluşturulan token ile Kullanıcı girişi sağlayan metod
        //Account/Login
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto model)
        {
            if (!ModelState.IsValid)  return BadRequest(ModelState);

            var user = await _userManager.FindByNameAsync(model.UserName);

            if (user == null) return BadRequest("Kullanıcı adı yanlış");
            
            var result = await _userManager.CheckPasswordAsync(user,model.Password.Trim());

            if (result)
            {
                TokenGenerator tokenGenerator = new TokenGenerator(_configuration); 
                var token = tokenGenerator.GetToken(user);
                return Ok(token);
            }
            return Unauthorized();

        }




    }
}
