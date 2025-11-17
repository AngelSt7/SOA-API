using SOA.features.property.client.dto.response;
using SOA.features.shared.dto;

namespace SOA.features.property.admin.dtos.response
{
    public class PropertyClientListResponseDto
    {
        public PaginationMeta meta { get; set; } = null!;
        public List<PropertyClientItemDto> data { get; set; } = null!;
    }
}
