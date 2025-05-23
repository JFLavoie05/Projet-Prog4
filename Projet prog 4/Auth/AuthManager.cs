using Projet_prog_4.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Projet_prog_4.Data;

namespace Projet_prog_4.Auth
{
    public interface IAuthManager
    {
        Task<AuthResponse> Login(LoginModel login);
        Task<IEnumerable<IdentityError>> RegisterUtilisateur(RegisterModel register);
    }

    

    

    public class AuthManager(UserManager<IdentityUser> userManager, IConfiguration configuration, Projet_prog_4Context context) : IAuthManager
    {
        private readonly UserManager<IdentityUser> _userManager = userManager;
        private readonly IConfiguration _configuration = configuration;
        private IdentityUser _user;
        private readonly Projet_prog_4Context _context = context;

        public async Task<AuthResponse> Login(LoginModel login)
        {
            //la validation de l'utilisateur et du mot de passe se fait ici
            _user = await _userManager.FindByNameAsync(login.Username);
            bool isValidUser = _user is not null
            && await _userManager.CheckPasswordAsync(_user, login.Password);
            if (_user == null || !isValidUser)
            {
                return null;
            }
            //Le jeton Web Token est crée ici
            var token = await GenerateToken();
            return new AuthResponse
            {
                Token = token,
                UserId = _user.Id
            };
        }

        public async Task<IEnumerable<IdentityError>> RegisterUtilisateur(RegisterModel register)
        {
            IdentityUser user = new IdentityUser
            {
                UserName = register.Username,
                Email = register.Email
            };
            var result = await _userManager.CreateAsync(user, register.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "UTILISATEUR");
            }
            var existingPanier = await _context.Panier.FirstOrDefaultAsync(p => p.UserId == user.Id);
            if (existingPanier == null)
            {
                var nouveauPanier = new Panier
                {
                    UserId = user.Id,
                    Total = 0,
                    SiteWeb = new List<SiteWeb>()
                };
                _context.Panier.Add(nouveauPanier);
                await _context.SaveChangesAsync();
            }
            return result.Errors;
        }





        private async Task<string> GenerateToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Secret"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var roles = await _userManager.GetRolesAsync(_user);
            var roleClaims = roles.Select(x => new Claim(ClaimTypes.Role, x)).ToList();
            var userClaims = await _userManager.GetClaimsAsync(_user);
            var claims = new List<Claim>
            {
                 new (JwtRegisteredClaimNames.Sub, _user.UserName),
                 new (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                 new (JwtRegisteredClaimNames.Email, _user.Email),
            }.Union(userClaims).Union(roleClaims).ToList();
            claims.Add(new Claim("role", roles.FirstOrDefault() ?? "Utilisateur"));
            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(
                Convert.ToInt32(_configuration["Jwt:DurationInMinutes"])),
                signingCredentials: credentials
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}

