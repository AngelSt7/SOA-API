using SOA.features.property.admin.dtos;
using SOA.features.property.admin.repository;
using SOA.Features.Location.Services;

namespace SOA.features.property.admin.services
{
    public class PropertyAdminService
    {
        private readonly PropertyAdminRepository _repository;
        private readonly LocationService _locationService;
        private readonly ILogger<PropertyAdminService> _logger;


        public PropertyAdminService(
            PropertyAdminRepository repository,
            LocationService locationService,
            ILogger<PropertyAdminService> logger)
        {
            _repository = repository;
            _locationService = locationService;
            _logger = logger;
        }

        public async Task<object> CreateAsync(CreatePropertyAdminDto dto, Guid userId)
        {
            var locationId = await _locationService.ResolveLocationAsync(dto.DepartmentId, dto.ProvinceId, dto.DistrictId);
            var createdProperty = await _repository.CreateAsync(dto, userId, locationId.Value);
            return createdProperty;
        }

    }
}
