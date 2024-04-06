namespace mission_11_burrows.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
