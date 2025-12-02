using Microsoft.EntityFrameworkCore;
using SOA.features.properties.models;
using SOA.features.property.admin.dtos.request;
using SOA.features.property.admin.dtos.response;

namespace SOA.features.property.admin.repository
{
    public class PropertyAdminRepository
    {
        private readonly ApplicationDbContext _context;

        public PropertyAdminRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Property> GetBaseQuery()
        {
            return _context.Properties.AsQueryable();
        }
        
        public async Task<IEnumerable<Property>> ExecuteQueryAsync(IQueryable<Property> query)
        {
            return await query.ToListAsync();
        }

        public async Task ChangeStatusAsync(Guid propertyId, Guid userId)
        {
            await _context.Properties
                .Where(p => p.Id == propertyId && p.UserId == userId)
                .ExecuteUpdateAsync(p => p
                    .SetProperty(x => x.Availability, x => !x.Availability)
                    .SetProperty(x => x.UpdatedAt, x => DateTime.UtcNow));
        }



        public async Task<PropertySingleResponseDto?> FindOneAsync(Guid id, Guid userId)
        {
            return await _context.Properties
                .Where(p => p.Id == id && p.UserId == userId)
                .Select(p => new PropertySingleResponseDto
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

                    LocationId = p.LocationId,

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
                    ServicesId = p.ServicesToProperties
                        .Select(s => s.ServiceId)
                    .ToList(),
                })
                .FirstOrDefaultAsync();
        }


        public IQueryable<PropertyListItemDto> GetListQuery(Guid userId)
        {
            return _context.Properties
                .Where(p => p.UserId == userId)
                .Select(p => new PropertyListItemDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Slug = p.Slug,
                    Price = p.Price,
                    Currency = p.Currency,
                    PropertyType = p.PropertyType,
                    PropertyCategory = p.PropertyCategory,
                    Address = p.Address,
                    Availability = p.Availability,
                    CreatedAt = p.CreatedAt,
                    YearBuilt = p.YearBuilt ?? 0,
                    Department = p.Location.Department.Name,
                    District = p.Location.District.Name,

                    MainImage = p.Images
                        .OrderBy(i => i.CreatedAt)
                        .Select(i => i.Url)
                        .FirstOrDefault()
                });
        }


        public async Task<PropertyUpdateDto> UpdateAsync(
         PropertyUpdateDto preparedPropertyDto,
         Guid userId)
        {
            var entity = new Property { Id = preparedPropertyDto.Id };
            _context.Properties.Attach(entity);
            _context.Entry(entity).CurrentValues.SetValues(preparedPropertyDto);

            await _context.SaveChangesAsync();

//SERVICTUOS
            var currentServices = _context.ServicesToProperties
                .Where(s => s.PropertyId == preparedPropertyDto.Id);

            if (currentServices.Any())
                _context.ServicesToProperties.RemoveRange(currentServices);

            var newServices = preparedPropertyDto.Services.Select(sid => new ServiceToProperty
            {
                Id = Guid.NewGuid(),
                PropertyId = preparedPropertyDto.Id,
                ServiceId = sid
            }).ToList();

            await _context.ServicesToProperties.AddRangeAsync(newServices);

            var residential = await _context.ResidentialProperties
                .FirstOrDefaultAsync(r => r.Id == preparedPropertyDto.Id);
            if (residential != null)
            {
                residential.Bedrooms = preparedPropertyDto.Bedrooms;
                residential.Bathrooms = preparedPropertyDto.Bathrooms;
                residential.Area = preparedPropertyDto.Area;
                residential.Furnished = preparedPropertyDto.Furnished;
                residential.HasTerrace = preparedPropertyDto.HasTerrace;
            }

            var commercial = await _context.CommercialProperties
                .FirstOrDefaultAsync(c => c.Id == preparedPropertyDto.Id);
            if (commercial != null)
            {
                commercial.Floor = preparedPropertyDto.Floor;
                commercial.HasParking = preparedPropertyDto.HasParking;
                commercial.ParkingSpaces = preparedPropertyDto.ParkingSpaces;
            }

            await _context.SaveChangesAsync();

            return preparedPropertyDto;
        }

        public async Task<Property> CreateAsync(CreatePropertyAdminDto dto, Guid userId, Guid locationId, string slug)
        {
            var property = new Property
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                Slug = slug,
                PropertyType = dto.PropertyType,
                PropertyCategory = dto.PropertyCategory,
                Currency = dto.Currency,
                Price = (double)dto.Price,
                Address = dto.Address,
                Description = dto.Description,
                UserId = userId,
                Phone = dto.Phone,
                YearBuilt = dto.YearBuilt ?? DateTime.UtcNow.Year,
                Latitude = dto.Latitude,
                Longitude = dto.Longitude,
                ExtraInfo = dto.ExtraInfo ?? string.Empty,
                LocationId = locationId,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await _context.Properties.AddAsync(property);

            var servicesToInsert = dto.ServicesId.Select(sid => new ServiceToProperty
            {
                Id = Guid.NewGuid(),
                PropertyId = property.Id,
                ServiceId = sid
            }).ToList();
            await _context.ServicesToProperties.AddRangeAsync(servicesToInsert);

            var residential = new ResidentialProperty
            {
                Id = property.Id,
                Bedrooms = dto.Bedrooms,
                Bathrooms = dto.Bathrooms,
                Area = dto.Area,
                Furnished = dto.Furnished ?? false,
                HasTerrace = dto.HasTerrace ?? false,
                Property = property
            };
            await _context.ResidentialProperties.AddAsync(residential);

            var commercial = new CommercialProperty
            {
                Id = property.Id,
                Floor = dto.Floor ?? 1,
                HasParking = dto.HasParking ?? false,
                ParkingSpaces = dto.ParkingSpaces,
                Property = property
            };
            await _context.CommercialProperties.AddAsync(commercial);

            await _context.SaveChangesAsync();

            return property;
        }



    }
}
