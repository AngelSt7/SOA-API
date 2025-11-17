using Microsoft.EntityFrameworkCore;
using SOA.features.auth.services;
using SOA.features.property.admin.dtos.request;
using SOA.features.property.admin.dtos.response;
using SOA.features.property.admin.repository;
using SOA.features.shared.services;
using SOA.Features.Location.Services;
using System.Text.RegularExpressions;

namespace SOA.features.property.admin.services
{
    public class PropertyAdminService(
        PropertyAdminRepository repository,
        LocationService locationService,
        QueryFilterService queryFilterService,
        PaginationService paginationService
        )
    {
        private readonly PropertyAdminRepository _repository = repository;
        private readonly LocationService _locationService = locationService;
        private readonly QueryFilterService _queryFilterService = queryFilterService;
        private readonly PaginationService _paginationService = paginationService;

        public async Task<PropertyAdminListResponseDto> FilterAsync(PropertyQueryDto query, Guid userId)
        {
            var baseQuery = _repository.GetListQuery(userId);

            var filteredQuery = _queryFilterService.ApplyFilters(baseQuery, query);
            int totalItems = await filteredQuery.CountAsync();

            var (skip, take) = _paginationService.GetPagination(query.Page, query.Limit);
            var paginatedQuery = filteredQuery.Skip(skip).Take(take);
            var data = await paginatedQuery.ToListAsync();
            var meta = _paginationService.BuildMeta(totalItems, skip, take);

            return new PropertyAdminListResponseDto()
            {
                meta = meta,
                data = data,
            };
        }

        public async Task<object> ChangeStatus(Guid propertyId, Guid userId)
        {
            await _repository.ChangeStatusAsync(propertyId, userId);

            return new
            {
                Message = "Estado de la propiedad actualizado correctamente"
            };
        }

        public async Task<ActionPropertyResponse> UpdateAsync(
            Guid id,
            UpdatePropertyAdminDto dto,
            Guid userId)
        {
            var property = await FindOneAsync(id, userId);
            if (property == null) throw new KeyNotFoundException("Propiedad no encontrada");

            var slug = GenerateSlug(dto.Name ?? property.Name);
            var locationId = await _locationService.ResolveLocationAsync(
                dto.DepartmentId ?? property.DepartmentId,
                dto.ProvinceId ?? property.ProvinceId,
                dto.DistrictId ?? property.DistrictId
            );

            var preparedProperty = GenerateInstance.PrepareProperty(property, dto, slug, (Guid)locationId);

            var updatedProperty = await _repository.UpdateAsync(preparedProperty, userId);

            return new ActionPropertyResponse()
            {
                Message = "Propiedad actualizada correctamente",
                Data = updatedProperty
            };
        }

        public async Task<PropertySingleResponseDto> FindOneAsync(Guid id, Guid userId)
        {
            var result = await _repository.FindOneAsync(id, userId);

            if (result == null)
                throw new KeyNotFoundException("Propiedad no encontrada");

            return result;
        }

        public async Task<ActionPropertyResponse> CreateAsync(CreatePropertyAdminDto dto, Guid userId)
        {
            var locationId = await _locationService.ResolveLocationAsync(dto.DepartmentId, dto.ProvinceId, dto.DistrictId);
            var slug = GenerateSlug(dto.Name);
            var createdProperty = await _repository.CreateAsync(dto, userId, locationId.Value, slug);
            return new ActionPropertyResponse()
            {
                Message = "Propiedad creada correctamente",
                Data = createdProperty
            };
        }

        private static string GenerateSlug(string text)
        {
            text = text.ToLowerInvariant().Trim();
            text = Regex.Replace(text, @"[^a-z0-9\s-]", "");
            text = Regex.Replace(text, @"\s+", "-");
            text = Regex.Replace(text, @"-+", "-");
            return text;
        }

    }
}
