using CitasAppAPI.Data;
using CitasAppAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CitasAppAPI.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]

        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(user);
        }
    }
}
