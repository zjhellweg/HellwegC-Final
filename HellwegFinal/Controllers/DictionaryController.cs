using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Text.Json;

namespace HellwegFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DictionaryController : ControllerBase
    {

        private readonly JwtAuthenticationManager _jwtAuthenticationManager;

        public DictionaryController(JwtAuthenticationManager jwtAuthenticationManager)
        {
            this._jwtAuthenticationManager = jwtAuthenticationManager;
        }

        [AllowAnonymous]
        [HttpPost(Name = "DictionaryText")]
        public ActionResult<List<Sorter>> Post(List<Dictionary<String,String>> Values)
        {
            List<Sorter> David = new List<Sorter>();

            Dictionary<String,String> StringValues = new Dictionary<String,String>();

            Dictionary<String, int> StringCount = new Dictionary<String, int>();


            for (int i = 0; i < Values.Count; i++)
            {
                foreach(var item in Values[i])
                {
                    if (!StringValues.ContainsKey(item.Key))
                    {
                        StringValues[item.Key] = item.Value;
                    } else if (!StringCount.ContainsKey(item.Key))
                    {
                        StringCount[item.Key] = 2;
                    } else { StringCount[item.Key] += 1; }
                }
            }

            StringValues = StringValues.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            StringCount = StringCount.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            Sorter Donald = new Sorter(StringValues,StringCount);

            David.Add(Donald);
            
            return David;
        }

        [AllowAnonymous]
        [HttpPost("Authorize")]
        public IActionResult AuthUser([FromBody] User usr)
        {
            var token = _jwtAuthenticationManager.Authenticate(usr.username, usr.password, usr.role);
            if(token == null)
            {
                return Unauthorized();
            }
            
            return Ok(token);
        }

    }

    public class Sorter
{
    public Dictionary<String,String> Values { get; set; }
    public Dictionary<String,int> Count { get; set; }

        public Sorter(Dictionary<String, String> Values, Dictionary<String, int> Count)
        {
            this.Values = Values;
            this.Count = Count;
        }
}

    public class User
    {
        public String username { get; set; }
        public String password { get; set; }

        public String role { get; set; }
    }

}
