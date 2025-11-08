using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SOA.features.auth.utils;
using SOA.features.property.admin.dtos;
using SOA.features.property.admin.services;

namespace SOA.features.property.admin.controllers
{
    [Route("api/property-admin")]
    [ApiController]
    public class PropertyAdminController : ControllerBase
    {
        private readonly UserContextService _userContext;
        private readonly PropertyAdminService _service;

        public PropertyAdminController(UserContextService userContext, PropertyAdminService service)
        {
            _userContext = userContext;
            _service = service;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePropertyAdminDto dto)
        {
            try
            {
                var userId = _userContext.GetUserId();

                var result = await _service.CreateAsync(dto, (Guid)userId);

                return Ok(new
                {
                    message = "Propiedad creada correctamente",
                    data = result
                });
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new
                {
                    message = ex.Message
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    message = "Ocurrió un error inesperado en el servidor",
                    error = ex.Message
                });
            }
        }

    }
}
