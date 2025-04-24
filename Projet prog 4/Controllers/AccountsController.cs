using Microsoft.AspNetCore.Mvc;
using Projet_prog_4.Auth;

namespace Projet_prog_4.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class AccountsController(IAuthManager authManager) : ControllerBase
        {
            private readonly IAuthManager _authManager = authManager;

            // POST: api/Account/register-ogre
            //[HttpPost]
            //[Route("register-ogre")]
            //public async Task<ActionResult> RegisterOgre([FromBody] Models.RegisterModel register)
            //{
            //    var errors = await _authManager.RegisterOgre(register);
            //    if (errors.Any())
            //    {
            //        foreach (var error in errors)
            //            ModelState.AddModelError(error.Code, error.Description);
            //        return BadRequest(ModelState);
            //    }
            //    return Ok();
            //}
            // POST: api/Account/register-cuisinier

            [HttpPost]
            [Route("register-cuisinier")]
            public async Task<ActionResult> RegisterUtilisateur([FromBody] Models.RegisterModel
           register)
            {
                var errors = await _authManager.RegisterUtilisateur(register);
                if (errors.Any())
                {
                    foreach (var error in errors)
                        ModelState.AddModelError(error.Code, error.Description);
                    return BadRequest(ModelState);
                }
                return Ok();
            }
            // POST: api/Account/register
            [HttpPost]
            [Route("login")]
            public async Task<ActionResult> Login([FromBody] Models.LoginModel login)
            {
                var authResponse = await _authManager.Login(login);
                if (authResponse is null)
                    return Unauthorized();
                return Ok(authResponse);
            }
        }
}
