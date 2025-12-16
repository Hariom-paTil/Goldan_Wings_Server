using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CakesController : ControllerBase
    {
        private readonly AppDbContext _context;


        public CakesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var cakeData = _context.Cakes.ToList();
            return Ok(cakeData);
        }
    }
}
