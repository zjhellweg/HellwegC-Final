using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace HellwegFinal.Controllers
{
    public class JwtAuthenticationManager
    {
        private readonly string key;

        private readonly IList<Dictionary<String,String>> users = new List<Dictionary<String, String>>() { 
            new Dictionary<string, string> { { "userName", "test" },{ "password", "password" }, { "role", "dmv" } },
            new Dictionary<string, string> { { "userName", "test2" },{ "password", "password2" }, { "role", "cop" } }
        };

        public JwtAuthenticationManager(string Key)
        {
            this.key = Key;
        }

        public string Authenticate(string username, string password, string role)
        {
            if(!users.Any(u => u["userName"] == username && u["password"] == password && u["role"] == role))
            {
                return null;
            }

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(key);

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, username),
                    new Claim(ClaimTypes.Role, role)
                }),

                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = handler.CreateToken(tokenDescriptor);

            return handler.WriteToken(token);

        }
    }
}
