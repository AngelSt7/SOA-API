using SOA.features.properties.enums;

namespace SOA.features.property.client.dto.request
{
    public class PropertyClientQueryDto
    {
        // Precio
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public Currency? Currency { get; set; }
        public PropertyCategory? PropertyCategory { get; set; }
        public PropertyType? PropertyType { get; set; }

        // Dormitorios y baños
        public int? MinBedrooms { get; set; }
        public int? MaxBedrooms { get; set; }
        public int? MinBathrooms { get; set; }
        public int? MaxBathrooms { get; set; }

        // Área
        public decimal? MinArea { get; set; }
        public decimal? MaxArea { get; set; }

        // Estacionamientos
        public int? MinParkingSpaces { get; set; }

        // Antigüedad
        public int? YearBuilt { get; set; }

        // Dirección (busqueda multi-palabra)
        public string? Address { get; set; }

        // Ubigeo
        public Guid? LocationId { get; set; }

        // Disponibilidad
        public bool? Availability { get; set; }

        // Paginación
        public int Page { get; set; } = 1;
        public int Limit { get; set; } = 10;
    }

}
