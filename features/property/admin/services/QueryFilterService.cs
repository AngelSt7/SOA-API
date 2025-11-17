using SOA.features.properties.models;
using SOA.features.property.admin.dtos.request;
using SOA.features.property.admin.dtos.response;

namespace SOA.features.property.admin.services
{
    public class QueryFilterService
    {
        private static readonly int[] AllowedLimits = new[] { 5, 10, 15 };

        public IQueryable<PropertyListItemDto> ApplyFilters(
            IQueryable<PropertyListItemDto> q,
            PropertyQueryDto query)
        {
            if (query.Availability is not null)
                q = q.Where(p => p.Availability == query.Availability);

            if (query.PropertyCategory is not null)
                q = q.Where(p => p.PropertyCategory == query.PropertyCategory);

            if (query.Currency is not null)
                q = q.Where(p => p.Currency == query.Currency);

            if (query.PropertyType is not null)
                q = q.Where(p => p.PropertyType == query.PropertyType);

            if (query.YearBuilt is not null)
                q = q.Where(p => p.YearBuilt == query.YearBuilt);

            return q;
        }


        public IQueryable<Property> ApplyPagination(IQueryable<Property> q, PropertyQueryDto query)
        {
            int limit = AllowedLimits.Contains(query.Limit) ? query.Limit : 10;
            int page = query.Page < 1 ? 1 : query.Page;
            return q
                .Skip((page - 1) * limit)
                .Take(limit);
        }
    }
}
