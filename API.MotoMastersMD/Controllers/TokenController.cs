using CORE.MotoMastersMD.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API.MotoMastersMD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly Microsoft.Extensions.Configuration.IConfiguration _configuration;
        public TokenController(Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost]
        public IActionResult Authentication(Users Login)
        {
            if (IsValidUser(Login))
            {
                var token = GenerateToken();
                return Ok(new { token });
            }
            return NotFound();
        }

        private bool IsValidUser(Users login)
        {
            return true;
        }
        private string GenerateToken()
        {
            //Header
            var SymmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Authentication:SecretKey"]));

            var SigningCredentials = new SigningCredentials(SymmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var header = new JwtHeader(SigningCredentials);

            //Claims
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, "Daniel Moreno"),
                new Claim(ClaimTypes.Email, "morenodaniel747@gmail.com"),
                new Claim(ClaimTypes.Role, "Admin"),
            };

            //Payload
            var payload = new JwtPayload
            (
                _configuration["Authentication:Issuer"],
                _configuration["Authentication:Audience"],
                claims,
                DateTime.Now,
                DateTime.UtcNow.AddMinutes(35)
            );

            //Generate token
            var token = new JwtSecurityToken(header, payload);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
