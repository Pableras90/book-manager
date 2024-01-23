using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManager.Persistence.SqlServer;
using BookManager.Domain;
using BookManager.Application.Models;
using BookManager.Application.Mappers;

namespace BookManager.Application.Services
{
    public class AuthorService
    {
        private readonly BooksDbContext _dbContext;
        public AuthorService(BooksDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Create(AuthorModel author)
        {
            var authorEntity = author.MapToEntity();
            _dbContext.Authors.Add(authorEntity);
            await _dbContext.SaveChangesAsync();
        }

    }
}
