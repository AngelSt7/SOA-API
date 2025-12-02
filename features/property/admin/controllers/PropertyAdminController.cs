using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SOA.features.auth.utils;
using SOA.features.property.admin.dtos.request;
using SOA.features.property.admin.dtos.response;
using SOA.features.property.admin.services;

namespace SOA.features.property.admin.controllers
{
    [Route("api/property-admin")]
    [ApiController]
    public class PropertyAdminController(UserContextService userContext, PropertyAdminService service) : ControllerBase
    {
        private readonly UserContextService _userContext = userContext;
        private readonly PropertyAdminService _service = service;


        [Authorize]
        [HttpGet()]
        public async Task<PropertyAdminListResponseDto> Filter([FromQuery] PropertyQueryDto query)
        {
            var userId = _userContext.GetUserId();
            return await _service.FilterAsync(query, (Guid)userId);
        }

        //[Authorize] 
        [HttpGet("{id}")]
        public async Task<PropertySingleResponseDto> GetOne([FromRoute] string id)
        {
           if (!Guid.TryParse(id, out var guid)) throw new ArgumentException("El id no es un GUID válido.");
            //  var userId = _userContext.GetUserId();
            return await _service.FindOneAsync(
     guid,
     Guid.Parse("54265359-ef98-473e-83cb-08de26e19b72")
 );

        }

        [Authorize]
        [HttpPatch("{id}")]
        public async Task<ActionPropertyResponse> Update(
            [FromRoute] string id,
            [FromBody] UpdatePropertyAdminDto dto)
        {
            if (!Guid.TryParse(id, out var guid)) throw new ArgumentException("El id no es un GUID válido.");
            var userId = _userContext.GetUserId();
            return await _service.UpdateAsync(guid, dto, (Guid)userId);
        }

        [Authorize]
        [HttpPatch("status/{id}")]
        public async Task<object> changeStatus(
        [FromRoute] string id)
            {
            if (!Guid.TryParse(id, out var guid)) throw new ArgumentException("El id no es un GUID válido.");
            var userId = _userContext.GetUserId();
            return await _service.ChangeStatus(guid, (Guid)userId);
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionPropertyResponse> Create([FromBody] CreatePropertyAdminDto dto)
        {
            var userId = _userContext.GetUserId();
            return await _service.CreateAsync(dto, (Guid)userId);
        }

    }
}
