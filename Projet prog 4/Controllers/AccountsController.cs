using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Projet_prog_4.Auth;

namespace Projet_prog_4.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class AccountsController : ControllerBase
        {
            private readonly IAuthManager _authManager;
            private readonly UserManager<IdentityUser> _userManager;
            private readonly RoleManager<IdentityRole> _roleManager;

            public AccountsController(
                IAuthManager authManager,
                UserManager<IdentityUser> userManager,
                RoleManager<IdentityRole> roleManager)
            {
                _authManager = authManager;
                _userManager = userManager;
                _roleManager = roleManager;
            }


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
            [Route("register-client")]
        [AllowAnonymous]
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
            [AllowAnonymous]
        public async Task<ActionResult> Login([FromBody] Models.LoginModel login)
            {
                var authResponse = await _authManager.Login(login);
                if (authResponse is null)
                    return Unauthorized();
                return Ok(authResponse);
            }

            //Ce endpoint est seulement là car quand on fait un add-migration,update-database, le role d'admin se perd
            [HttpPost("assign-admin-role")]
            [AllowAnonymous]
        public async Task<IActionResult> AssignAdminRole([FromBody] string username)
            {
                var user = await _userManager.FindByNameAsync(username);
                if (user == null) return NotFound("Utilisateur non trouvé");

                if (!await _roleManager.RoleExistsAsync("Admin"))
                {
                    await _roleManager.CreateAsync(new IdentityRole("Admin"));
                }

                if (!await _userManager.IsInRoleAsync(user, "Admin"))
                {
                    await _userManager.AddToRoleAsync(user, "Admin");
                }

                return Ok("Rôle admin assigné avec succès.");
            }

        }
}
