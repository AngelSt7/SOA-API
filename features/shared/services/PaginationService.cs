using SOA.features.shared.dto;

namespace SOA.features.shared.services
{
    public class PaginationService
    {
        public (int skip, int take) GetPagination(int page = 1, int limit = 10)
        {

            int take = limit;
            int skip = (page - 1) * limit;
            return (skip, take);
        }

        public PaginationMeta BuildMeta(int totalItems, int skip, int take)
        {
            int currentPage = (skip / take) + 1;

            return new PaginationMeta
            {
                TotalPages = (int)Math.Ceiling((double)totalItems / take),
                ItemsPerPage = take,
                ItemsInPage = Math.Max(0, Math.Min(take, totalItems - skip)),
                CurrentPage = currentPage,
                TotalItems = totalItems,
                NextPage = skip + take < totalItems,
                PrevPage = skip > 0
            };
        }
    }
}
