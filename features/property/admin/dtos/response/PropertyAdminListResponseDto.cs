
using SOA.features.shared.dto;

namespace SOA.features.property.admin.dtos.response
{
    public class PropertyAdminListResponseDto
    {
        public PaginationMeta meta { get; set; } = null!;
        public List<PropertyListItemDto> data { get; set; } = null!;
    }
}
