using Microsoft.AspNetCore.Mvc;
using SOA.features.services.models;

namespace SOA.features.services
{
    [Route("api/service")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ServiceController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult All()
        {
            var servicios = _context.Services
                .Select(s => new {
                    Id = s.Id,
                    Name = s.ServiceName
                })
                .ToArray();

            return Ok(servicios);
        }
    }
}
