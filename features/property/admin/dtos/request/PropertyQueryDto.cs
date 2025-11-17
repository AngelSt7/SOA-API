using System.ComponentModel.DataAnnotations;
using SOA.features.properties.enums;

namespace SOA.features.property.admin.dtos.request
{
    public class PropertyQueryDto
    {
        public bool? Availability { get; set; }

        public PropertyCategory? PropertyCategory { get; set; }

        public Currency? Currency { get; set; }

        public PropertyType? PropertyType { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "YearBuilt debe ser un número positivo.")]
        public int? YearBuilt { get; set; }

        // Pagination
        [Range(1, int.MaxValue, ErrorMessage = "Page debe ser mínimo 1.")]
        public int Page { get; set; } = 1;

        [Range(5, 15, ErrorMessage = "Limit solo puede ser 5, 10 o 15.")]
        public int Limit { get; set; } = 10;
    }
}
