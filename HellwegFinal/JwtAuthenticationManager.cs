using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlTypes;
using HellwegFinal;

namespace HellwegFinal.Controllers
{
    public class JwtAuthenticationManager
    {
        private readonly string key;

        /*
         * private readonly IList<Dictionary<String,String>> users = new List<Dictionary<String, String>>() { 
            new Dictionary<string, string> { { "userName", "test" },{ "password", "password" }, { "role", "dmv" } },
            new Dictionary<string, string> { { "userName", "test2" },{ "password", "password2" }, { "role", "cop" } }
        };
        */

        public List<Dictionary<String,String>> Something() { 

        List<Dictionary<String, String>> users = new List<Dictionary<string, string>>();
        SqlConnection cn = new SqlConnection("Data Source=HELLWEGSQLPC;Initial Catalog=DriverDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cm = new SqlCommand("Select * From EmployeeAccounts", cn);

            try
            {
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    Dictionary<String, String> user = new Dictionary<String, String>();
                    user["userName"] = dr.GetString(1);
                    user["password"] = dr.GetString(2);
                    user["role"] = dr.GetString(3);

                    users.Add(user);
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }

            return users;

        }



        public JwtAuthenticationManager(string Key)
        {
            this.key = Key;
        }

        public string Authenticate(string username, string password, string role)
        {
            if(!Something().Any(u => u["userName"] == username && u["password"] == password && u["role"] == role))
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
