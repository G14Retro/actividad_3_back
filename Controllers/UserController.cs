using actividad_3_back.Models.DAO;
using actividad_3_back.Models.DTO;
using actividad_3_back.Services.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace actividad_3_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        #region Private Fields
        private readonly IUsers _user;
        #endregion

        public UserController(IUsers user)
        {
            _user = user;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(string email, string password)
        {
            return Ok(await _user.LoginUser(email,password));
        }
        [HttpPost]
        [Route("CreateUser")]
        [Authorize]
        public async Task<IActionResult> CreateUser(UserModel user)
        {
            return Ok(await _user.CreateUser(user));
        }
    }
}
