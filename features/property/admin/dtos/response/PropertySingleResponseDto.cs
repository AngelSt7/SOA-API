using SOA.features.properties.enums;
namespace SOA.features.property.admin.dtos.response
{
    public class PropertySingleResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public double Price { get; set; }
        public string Phone { get; set; }
        public string ExtraInfo { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Description { get; set; } = null!;

        public Guid DistrictId { get; set; }
        public Guid ProvinceId { get; set; }
        public Guid DepartmentId { get; set; }

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
    }
}
