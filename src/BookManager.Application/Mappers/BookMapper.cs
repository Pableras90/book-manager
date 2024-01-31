using BookManager.Application.Models;
using BookManager.Domain;


namespace BookManager.Application.Mappers
{
    public static class BookMapper
    {
        public static BookEntity MapToEntity(BookModel model)
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
        public static List<BookModel> MapToModel(List<BookEntity> entities)
        {
            List<BookModel> models = new List<BookModel>();
            foreach(var entity in entities)
            {
                var model = MapToModel(entity);
                models.Add(model);
            }
            return models;

        }
        public static BookModel MapToModel(BookEntity entity)
        {
            return new BookModel
            {
                Id = entity.Id,
                Title = entity.Title,
                PublishedOn = entity.PublishedOn,
                Description = entity.Description,
                AuthorId = entity.AuthorId
            };
        }
    }
    
}
