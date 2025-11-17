namespace SOA.features.shared.dto
{
    public class PaginationMeta
    {
        public int TotalPages { get; set; }
        public int ItemsPerPage { get; set; }
        public int ItemsInPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalItems { get; set; }
        public bool NextPage { get; set; }
        public bool PrevPage { get; set; }
    }
}