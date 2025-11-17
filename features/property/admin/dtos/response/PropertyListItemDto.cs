using SOA.features.properties.enums;
using System.Text.Json.Serialization;

namespace SOA.features.property.admin.dtos.response
{
    public class PropertyListItemDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string Department { get; set; } = null!;
        public string District { get; set; } = null!;
        public double Price { get; set; }
        public Currency Currency { get; set; }
        public PropertyType PropertyType { get; set; }
        public PropertyCategory PropertyCategory { get; set; }
        public string Address { get; set; } = null!;
        public bool Availability { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? MainImage { get; set; }
        public int YearBuilt { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Guid LocationId { get; set; }

        public string FullSlug =>
            $"/inmueble/clasificado/{Department}-{District}-{Slug}"
                .ToLower()
                .Replace(" ", "-")
                .Replace("á", "a")
                .Replace("é", "e")
                .Replace("í", "i")
                .Replace("ó", "o")
                .Replace("ú", "u")
                .Replace("ñ", "n");

    }
}
