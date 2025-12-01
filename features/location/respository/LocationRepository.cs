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
            var deparmentsII = await _context.Locations
                .Select(l => new { l.Id, l.Department.Name, l.Type, l.Slug })
                .Where(l => l.Type == "DEPARTMENT")
                .ToListAsync();
                
            var provincesII = await _context.Locations
                .Select(l => new { l.Id, l.Province.Name, l.Type, l.Slug })
                .Where(l => l.Type == "PROVINCE")
                .ToListAsync();

            var districtsII = await _context.Locations
                .Select(l => new { l.Id, l.District.Name, l.Type, l.Slug })
                .Where(l => l.Type == "DISTRICT")
                .ToListAsync();

            return new List<dynamic>
            {
                deparmentsII.Cast<dynamic>().ToList(),
                provincesII.Cast<dynamic>().ToList(),
                districtsII.Cast<dynamic>().ToList()
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
