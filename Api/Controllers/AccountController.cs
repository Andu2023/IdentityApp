using Api.DTOS.Account;
using Api.Models;
using Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly JWTService _jwtservice;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public AccountController( 
            JWTService jwtservice, 
            SignInManager<User> signInManager, 
            UserManager<User> userManager)
        {
            this._jwtservice = jwtservice;
            this._signInManager = signInManager;
            this._userManager = userManager;
        }
        [HttpPost("Login")]  
        public async Task<ActionResult<userDto>>Login(LoginDto model)
        {
            var user = await _userManager.FindByNameAsync(model.userName);
            if (user == null) return Unauthorized("invalid username");
            if (user.EmailConfirmed ==false) return Unauthorized("please check email verication first");
            var result = await _signInManager.CheckPasswordSignInAsync(user, model.password, false);
            if (!result.Succeeded) return Unauthorized("please check password");
            return CreateApplicationUserDto(user);
        }
        #region private helper methods
        private userDto CreateApplicationUserDto(User user)
        {
            return new userDto
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                JWT=_jwtservice.CreateJWT(user),

            };
        }
        # endregion 
    }
}
