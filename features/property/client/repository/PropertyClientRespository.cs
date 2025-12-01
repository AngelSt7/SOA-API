using Microsoft.EntityFrameworkCore;
using SOA.features.properties.models;
using SOA.features.property.admin.dtos.response;
using SOA.features.property.client.dto.response;

namespace SOA.features.property.client.repository
{
    public class PropertyClientRepository
    {
        private readonly ApplicationDbContext _context;

        public PropertyClientRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Property> GetQuery()
        {
            return _context.Properties
                .Include(p => p.ResidentialProperty)
                .Include(p => p.Location)
                    .ThenInclude(l => l.District)
                .Include(p => p.Location)
                    .ThenInclude(l => l.Department)
                .Include(p => p.Images);
        }

        public async Task<PropertyClientSingleResponseDto?> FindOneAsync(String id)
        {
            return await _context.Properties
                .Where(p => p.Id.ToString().EndsWith(id))
                .Select(p => new PropertyClientSingleResponseDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Address = p.Address,
                    Description = p.Description,
                    YearBuilt = p.YearBuilt ?? 0,
                    Latitude = p.Latitude,
                    Longitude = p.Longitude,
                    Availability = p.Availability,
                    Phone = p.Phone,
                    ExtraInfo = p.ExtraInfo,

                    District = p.Location.District.Name,
                    Province = p.Location.Province.Name,
                    Department =  p.Location.Department.Name,

                    Bathrooms = p.ResidentialProperty != null ? p.ResidentialProperty.Bathrooms : null,
                    Bedrooms = p.ResidentialProperty != null ? p.ResidentialProperty.Bedrooms : null,
                    Area = p.ResidentialProperty != null ? p.ResidentialProperty.Area : 0,
                    Furnished = p.ResidentialProperty != null && p.ResidentialProperty.Furnished,
                    HasTerrace = p.ResidentialProperty != null && p.ResidentialProperty.HasTerrace,

                    Floor = p.CommercialProperty != null ? p.CommercialProperty.Floor : 0,
                    HasParking = p.CommercialProperty != null && p.CommercialProperty.HasParking,
                    ParkingSpaces = p.CommercialProperty != null ? p.CommercialProperty.ParkingSpaces : null,

                    UpdatedAt = p.UpdatedAt,
                    Slug = p.Slug,
                    Currency = p.Currency,
                    PropertyType = p.PropertyType,
                    PropertyCategory = p.PropertyCategory,
                    CreatedAt = p.CreatedAt,
                    Services = p.ServicesToProperties
                        .Select(s => s.ServiceId)
                    .ToList(),
                })
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<PropertyListItemDto>> ExecuteQueryAsync(IQueryable<PropertyListItemDto> query)
        {
            return await query.ToListAsync();
        }
    }
}
