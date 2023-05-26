using asset_project.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace asset_project.API.Controllers
{
    [ApiController]
    [Route("/api/users")]
    public class UsersController
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

       /* [HttpGet]
        public async Task<IActionResult> GetUser(string username)
        {

        }*/
    }
}
