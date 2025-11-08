using Microsoft.AspNetCore.Mvc;
using SOA.features.location.dtos;
using SOA.features.location.models;
using SOA.Features.Location.Services;

namespace SOA.features.location.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly LocationService _service;
        public LocationController(LocationService service)
        {
            _service = service;
        }

        [HttpGet("{type?}")]
        public async Task<ActionResult<List<object>>> GetAll([FromRoute] LocationFilterDto filter)
        {
            var type = filter.Type?.ToUpper();

            var allowedTypes = new[] { "DEPARTMENT", "PROVINCE", "DISTRICT", "ALL" };

            if (!string.IsNullOrEmpty(type) && !allowedTypes.Contains(type))
            {
                return BadRequest("Type must be DEPARTMENT, PROVINCE, DISTRICT or ALL.");
            }

            var locations = await _service.GetAllAsync(type);
            return Ok(locations);
        }


    }
}
