using Microsoft.EntityFrameworkCore;
using SOA.features.property.admin.dtos.response;
using SOA.features.property.client.dto.request;
using SOA.features.property.client.dto.response;
using SOA.features.property.client.repository;
using SOA.features.shared.services;

namespace SOA.features.property.client.services
{
    public class PropertyClientService
    {
        private readonly PropertyClientRepository _repository;
        private readonly ClientQueryFilterService _filterService;
        private readonly PaginationService _paginationService;

        public PropertyClientService(
            PropertyClientRepository repository,
            ClientQueryFilterService filterService,
            PaginationService paginationService)
        {
            _repository = repository;
            _filterService = filterService;
            _paginationService = paginationService;
        }

        public async Task<PropertyClientSingleResponseDto?> GetOne(String id)
        {
            return await _repository.FindOneAsync(id);
        }

        public async Task<PropertyClientListResponseDto> FilterAsync(PropertyClientQueryDto query)
        {
            var baseQuery = _repository.GetQuery();
            var filteredQuery = _filterService.ApplyFilters(baseQuery, query);
            var totalItems = await filteredQuery.CountAsync();

            var (skip, take) = _paginationService.GetPagination(query.Page, query.Limit);

            var paginatedQuery = _filterService.ProjectToDto(filteredQuery)
                .Skip(skip)
                .Take(take);

            var data = await paginatedQuery.ToListAsync();
            var meta = _paginationService.BuildMeta(totalItems, skip, take);

            return new PropertyClientListResponseDto
            {
                meta = meta,
                data = data
            };

        }
    }
}
