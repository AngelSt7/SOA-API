using SOA.features.properties.models;
using SOA.features.property.admin.dtos.response;
using SOA.features.property.client.dto.request;
using SOA.features.property.client.dto.response;
using Microsoft.EntityFrameworkCore;

namespace SOA.features.property.client.services
{
    public class ClientQueryFilterService
    {
        private static readonly int[] AllowedLimits = new[] { 5, 10, 15 };

        public IQueryable<Property> ApplyFilters(
            IQueryable<Property> query,
            PropertyClientQueryDto filter)
        {
            if (filter.MinPrice.HasValue)
                query = query.Where(p => p.Price >= (double)filter.MinPrice.Value);

            if (filter.MaxPrice.HasValue)
                query = query.Where(p => p.Price <= (double)filter.MaxPrice.Value);

            if (filter.Currency.HasValue)
                query = query.Where(p => p.Currency == filter.Currency.Value);

            if (filter.PropertyCategory.HasValue)
                query = query.Where(p => p.PropertyCategory == filter.PropertyCategory.Value);

            if (filter.PropertyType.HasValue)
                query = query.Where(p => p.PropertyType == filter.PropertyType.Value);

            if (filter.YearBuilt.HasValue)
                query = query.Where(p => p.YearBuilt >= filter.YearBuilt.Value);

            if (filter.LocationId.HasValue)
                query = query.Where(p => p.LocationId == filter.LocationId.Value);

            if (filter.Availability.HasValue)
                query = query.Where(p => p.Availability == filter.Availability.Value);

            if (filter.MinBedrooms.HasValue)
                query = query.Where(p => p.ResidentialProperty != null && p.ResidentialProperty.Bedrooms >= filter.MinBedrooms.Value);

            if (filter.MaxBedrooms.HasValue)
                query = query.Where(p => p.ResidentialProperty != null && p.ResidentialProperty.Bedrooms <= filter.MaxBedrooms.Value);

            if (filter.MinBathrooms.HasValue)
                query = query.Where(p => p.ResidentialProperty != null && p.ResidentialProperty.Bathrooms >= filter.MinBathrooms.Value);

            if (filter.MaxBathrooms.HasValue)
                query = query.Where(p => p.ResidentialProperty != null && p.ResidentialProperty.Bathrooms <= filter.MaxBathrooms.Value);

            if (filter.MinArea.HasValue)
                query = query.Where(p => p.ResidentialProperty != null && p.ResidentialProperty.Area >= (double)filter.MinArea.Value);

            if (filter.MaxArea.HasValue)
                query = query.Where(p => p.ResidentialProperty != null && p.ResidentialProperty.Area <= (double)filter.MaxArea.Value);

            if(filter.MinParkingSpaces.HasValue)
                query = query.Where(p => p.CommercialProperty != null && p.CommercialProperty.ParkingSpaces >= filter.MinParkingSpaces.Value);

            if (!string.IsNullOrWhiteSpace(filter.Address))
            {
                var words = filter.Address.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    var temp = word; 
                    query = query.Where(p => p.Address.Contains(temp));
                }
            }

            return query;
        }

        public IQueryable<PropertyClientItemDto> ApplyPagination(
            IQueryable<PropertyClientItemDto> query,
            PropertyClientQueryDto filter)
        {
            int limit = AllowedLimits.Contains(filter.Limit) ? filter.Limit : 10;
            int page = filter.Page < 1 ? 1 : filter.Page;

            return query.Skip((page - 1) * limit).Take(limit);
        }

        public IQueryable<PropertyClientItemDto> ProjectToDto(IQueryable<Property> query)
        {
            return query.Select(p => new PropertyClientItemDto
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
                Bedrooms = p.ResidentialProperty != null ? (int)p.ResidentialProperty.Bedrooms : 0,
                Bathrooms = p.ResidentialProperty != null ? (int)p.ResidentialProperty.Bathrooms : 0,
                Area = p.ResidentialProperty != null ? p.ResidentialProperty.Area : 0,
                ParkingSpaces = p.CommercialProperty != null ? (int)p.CommercialProperty.ParkingSpaces : 0,
                MainImage = p.Images
                    .OrderBy(i => i.CreatedAt)
                    .Select(i => i.Url)
                    .FirstOrDefault()
            });
        }
    }
}
