using Microsoft.AspNetCore.Mvc;

namespace SOA.features.location.dtos
{
    /// <summary>
    /// DTO para filtrar ubicaciones en la ruta.
    /// </summary>
    public class LocationFilterDto
    {
        /// <summary>
        /// Tipo de ubicación a filtrar (opcional).
        /// Valores permitidos: DEPARTMENT, PROVINCE, DISTRICT, ALL
        /// Si no se especifica, se devolverán todas las ubicaciones.
        /// </summary>
        [FromRoute(Name = "type")]
        public string? Type { get; set; }
    }
}
