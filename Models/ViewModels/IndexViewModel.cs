using System.Diagnostics.Eventing.Reader;

namespace mission_11_burrows.Models.ViewModels
{
    public class IndexViewModel
    {
        public IQueryable<Book> Books { get; set; }
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
