using BookManager.Application.Mappers;
using BookManager.Application.Models;
using BookManager.Domain;
using BookManager.Persistence.SqlServer;
using Microsoft.EntityFrameworkCore;


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
            var bookEntity = BookMapper.MapToEntity(book);
            _dbContext.Books.Add(bookEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateTitle(Guid id, string title)
        {
            BookEntity entity = _dbContext.Books.Find(id);
            entity.Title = title;
            _dbContext.Books.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateDescription(Guid id, string description)
        {
            BookEntity entity = _dbContext.Books.Find(id);
            entity.Description = description;
            _dbContext.Books.Update(entity);
            await _dbContext.SaveChangesAsync();
        }


        public async Task<List<BookModel>> GetAllBooks()
        {
            
            var bookEntityList = await _dbContext.Books.ToListAsync();
            var bookModelList = BookMapper.MapToModel(bookEntityList);
            return bookModelList;
        }


    }
}
