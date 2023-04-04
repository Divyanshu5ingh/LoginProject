using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Users;

namespace Passwordlessauthentication.Controllers
{
    [Route("api/[controller]")]
    public class MyController : AbpController
    {
        private readonly ICurrentUser _currentUser;

        public MyController(ICurrentUser currentUser)
        {
            _currentUser = currentUser;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetCurrentUser()
        {
            var userId = _currentUser.Id;
            var userName = _currentUser.UserName;

            // return the current user's information as a JSON object
            return Ok(new { Id = userId, UserName = userName });
        }
    }
}
