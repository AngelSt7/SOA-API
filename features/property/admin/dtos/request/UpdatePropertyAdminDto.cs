using System.ComponentModel.DataAnnotations;
using SOA.features.properties.enums;

namespace SOA.features.property.admin.dtos.request
{
    public class UpdatePropertyAdminDto
    {
        [Required]
        [StringLength(50, MinimumLength = 8)]
        public string? Name { get; set; }

        [Required]
        [EnumDataType(typeof(PropertyType))]
        public PropertyType? PropertyType { get; set; }

        [Required]
        [EnumDataType(typeof(PropertyCategory))]
        public PropertyCategory? PropertyCategory { get; set; }

        [Required]
        [EnumDataType(typeof(Currency))]
        public Currency? Currency { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "El precio debe ser mayor que 0.")]
        public decimal? Price { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 8)]
        public string? Address { get; set; }

        [Required]
        [StringLength(300, MinimumLength = 8)]
        public string? Description { get; set; }

        [Required]
        public Guid? DepartmentId { get; set; }
        [Required]
        public Guid? ProvinceId { get; set; }
        [Required]
        public Guid? DistrictId { get; set; }

        [Required]
        [Range(1, 10)]
        public int? Bedrooms { get; set; }

        [Required]
        [Range(1, 10)]
        public int? Bathrooms { get; set; }

        [Required]
        [Range(1, double.MaxValue)]
        public double? Area { get; set; }

        [Required]
        public bool? Furnished { get; set; }

        [Required]
        [Range(1, 50)]
        public int? Floor { get; set; }

        [Required]
        public bool? HasParking { get; set; }

        [Required]
        [Range(1, 5)]
        public int? ParkingSpaces { get; set; }

        [Required]
        [Range(-90, 90)]
        public double? Latitude { get; set; }

        [Required]
        [Range(-180, 180)]
        public double? Longitude { get; set; }

        [Required]
        public bool? HasTerrace { get; set; }

        [Required]
        [Range(1900, 2100)]
        public int? YearBuilt { get; set; }

        [Required]
        [StringLength(300, MinimumLength = 8)]
        public string? ExtraInfo { get; set; }

        [Required]
        [RegularExpression(@"^9[0-9]{8}$", ErrorMessage = "El teléfono debe tener 9 dígitos y comenzar con 9.")]
        public string? Phone { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "Debe incluir al menos un servicio si envía este campo.")]
        public List<Guid>? ServicesId { get; set; }
    }
}
