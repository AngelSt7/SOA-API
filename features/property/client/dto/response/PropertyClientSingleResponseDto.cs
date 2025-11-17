    using SOA.features.properties.enums;

namespace SOA.features.property.client.dto.response
{
    public class PropertyClientSingleResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public double Price { get; set; }
        public string Phone { get; set; }
        public string ExtraInfo { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Description { get; set; } = null!;

        public string District { get; set; }
        public string Province { get; set; }
        public string Department { get; set; }

        public bool Availability { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int YearBuilt { get; set; }
        public int? Bathrooms { get; set; }
        public int? Bedrooms { get; set; }
        public double Area { get; set; }
        public bool Furnished { get; set; }
        public bool HasTerrace { get; set; }
        public bool HasParking { get; set; }
        public int? ParkingSpaces { get; set; }
        public int Floor { get; set; }

        public List<Guid> Services { get; set; } = new();
        public Currency Currency { get; set; }
        public PropertyType PropertyType { get; set; }
        public PropertyCategory PropertyCategory { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

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
