using BookManager.Application.Mappers;
using BookManager.Application.Models;
using BookManager.Persistence.SqlServer;


namespace BookManager.Application.Services
{
    public class BookService
    {
        private readonly BooksDbContext _dbContext;
        public BookService(BooksDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(BookModel book)
        {
            var bookEntity = book.MapToEntity();
            _dbContext.Books.Add(bookEntity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
