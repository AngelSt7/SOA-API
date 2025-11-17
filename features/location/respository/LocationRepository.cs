using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace SOA.Features.Location.Repository
{
    public class LocationRepository
    {
        private readonly ApplicationDbContext _context;
            private readonly ILogger<LocationRepository> _logger;

        public LocationRepository(ApplicationDbContext context, ILogger<LocationRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<List<dynamic>> GetAllAsync()
        {
            var departments = await _context.Departments
                .Select(d => new { d.Id, d.Name, d.Slug })
                .ToListAsync();

            var provinces = await _context.Provinces
                .Select(p => new { p.Id, p.Name, p.Slug, p.DepartmentId })
                .ToListAsync();

            var districts = await _context.Districts
                .Select(d => new { d.Id, d.Name, d.Slug, d.ProvinceId })
                .ToListAsync();

            return new List<dynamic>
            {
                departments.Cast<dynamic>().ToList(),
                provinces.Cast<dynamic>().ToList(),
                districts.Cast<dynamic>().ToList()
            };
        }

        public async Task<Guid?> ResolveLocationAsync(Guid departmentId, Guid provinceId, Guid districtId)
        {
            try
            {
                _logger.LogInformation("🔍 Buscando Location con DepartmentId={DepartmentId}, ProvinceId={ProvinceId}, DistrictId={DistrictId}",
                    departmentId, provinceId, districtId);

                var location = await _context.Locations
                    .AsNoTracking()
                    .FirstOrDefaultAsync(l =>
                        l.DepartmentId == departmentId &&
                        l.ProvinceId == provinceId &&
                        l.DistrictId == districtId);

                return location?.Id ?? null; 
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "❌ Error en ResolveLocationAsync");
                return null;
            }
        }


    }
}
