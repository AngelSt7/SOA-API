using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SOA.features.property.admin.dtos.response;
using SOA.features.property.client.dto.request;
using SOA.features.property.client.dto.response;
using SOA.features.property.client.services;

namespace SOA.features.property.client.controllers
{
    [Route("api/property")]
    [ApiController]
    public class PropertyClientController : ControllerBase
    {
        private readonly PropertyClientService _propertyService;

        public PropertyClientController(PropertyClientService propertyService)
        {
            _propertyService = propertyService;
        }

        [HttpGet]
        public async Task<PropertyClientListResponseDto> GetFilters([FromQuery] PropertyClientQueryDto query)
        {
            return await _propertyService.FilterAsync(query);
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<PropertyClientSingleResponseDto> GetOne([FromRoute] string id)
        {
            if (!Guid.TryParse(id, out var guid))
                throw new ArgumentException("El id no es un GUID válido.");
            return await _propertyService.GetOne(guid);
        }
    }
}
