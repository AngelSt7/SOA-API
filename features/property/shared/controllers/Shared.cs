using Microsoft.AspNetCore.Mvc;
using SOA.features.properties.enums;

namespace SOA.features.property.shared.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Shared : ControllerBase
    {

        [HttpGet("property-categories")]
        public IActionResult GetCategories()
        {
            var categories = Enum.GetValues(typeof(PropertyCategory))
                .Cast<PropertyCategory>()
                .Select(c => new
                {
                    key = c.ToString(),
                    value = (int)c
                })
                .ToList();

            return Ok(categories);
        }

        [HttpGet("property-types")]
        public IActionResult GetPropertyTypes()
        {
            var types = Enum.GetValues(typeof(PropertyType))
                .Cast<PropertyType>()
                .Select(t => new
                {
                    key = t.ToString(),
                    value = (int)t
                })
                .ToList();

            return Ok(types);
        }

    }
}
