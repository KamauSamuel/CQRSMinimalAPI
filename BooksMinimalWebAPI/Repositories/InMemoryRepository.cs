using BooksMinimalWebAPI.Entities;

namespace BooksMinimalWebAPI.Repositories
{
    public static class InMemoryRepository
    {
        public static readonly Dictionary<Guid, Book> Books = new();
      
    }
}
