using SOA.Features.Location.Repository;

namespace SOA.Features.Location.Services
{
    public class LocationService
    {
        private readonly LocationRepository _repository;

        public LocationService(LocationRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<object>> GetAllAsync(string? type)
        {
            var data = await _repository.GetAllAsync();

            var departments = ((List<dynamic>)data[0]).ToList();
            var provinces = ((List<dynamic>)data[1]).ToList();
            var districts = ((List<dynamic>)data[2]).ToList();

            var departmentsWithType = departments.Select(d => new
            {
                Id = d.Id,
                Name = d.Name,
                Slug = d.Slug,
                Type = "DEPARTMENT"
            }).ToList();

            var provincesWithDepartment = provinces.Select(p =>
            {
                var dept = departments.FirstOrDefault(d => d.Id == p.DepartmentId);
                var deptName = dept != null ? dept.Name : "";
                var deptSlug = dept != null ? dept.Slug : "";

                return new
                {
                    Id = p.Id,
                    Name = $"{deptName}, {p.Name}",
                    Slug = $"{deptSlug}-{p.Slug}",
                    Type = "PROVINCE"
                };
            }).ToList();

            var districtsFull = districts.Select(d =>
            {
                var prov = provincesWithDepartment.FirstOrDefault(p => p.Id == d.ProvinceId);
                var provName = prov != null ? prov.Name : "";
                var provSlug = prov != null ? prov.Slug : "";

                return new
                {
                    Id = d.Id,
                    Name = $"{provName}, {d.Name}",
                    Slug = $"{provSlug}-{d.Slug}",
                    Type = "DISTRICT"
                };
            }).ToList();

            var flatList = new List<object>();
            flatList.AddRange(departmentsWithType);
            flatList.AddRange(provincesWithDepartment);
            flatList.AddRange(districtsFull);

            return FilterByType(flatList, type);
        }

        private List<object> FilterByType(List<object> locations, string? type)
        {
            if (string.IsNullOrEmpty(type) || string.Equals(type, "ALL", StringComparison.OrdinalIgnoreCase))
                return locations;

            var allowedTypes = new[] { "DEPARTMENT", "PROVINCE", "DISTRICT" };

            type = type.ToUpper();

            if (!allowedTypes.Contains(type))
                throw new ArgumentException("Type must be DEPARTMENT, PROVINCE, DISTRICT or ALL.");

            return locations
                .Where(l => string.Equals(((dynamic)l).Type, type, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public async Task<Guid?> ResolveLocationAsync(Guid departmentId, Guid provinceId, Guid districtId)
        {
            var locationId = await _repository.ResolveLocationAsync(departmentId, provinceId, districtId);

            if (locationId == null)
            {
                throw new InvalidOperationException("Ubicación inválida o inexistente.");
            }

            return locationId;
        }


    }
}
