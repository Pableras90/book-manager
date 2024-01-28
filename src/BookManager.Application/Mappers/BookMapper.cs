using BookManager.Application.Models;
using BookManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Application.Mappers
{
    public static class BookMapper
    {
        public static BookEntity MapToEntity(this BookModel model)
        {
            return new BookEntity
            {
                Id = model.Id,
                Title = model.Title,
                PublishedOn = model.PublishedOn,
                Description = model.Description,
                AuthorId = model.AuthorId
            };
        }
    }
}
