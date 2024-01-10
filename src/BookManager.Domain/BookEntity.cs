

namespace BookManager.Domain
{
    public class BookEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime PublishedOn { get; set; }
        public string Description { get; set; } = string.Empty;

        public int AuthorId { get; set; }  // Clave foránea
        public AuthorEntity? Author { get; set; }//Sirve para facilitar el acceso al Autor

      
    }
}
