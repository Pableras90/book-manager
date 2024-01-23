using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using BookManager.Domain;

namespace BookManager.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly List<BookEntity> _books;
        private readonly List<AuthorEntity> _authors;

        // Constructor que inicializa _books y _authors con nuevas listas vacías
        public BooksController()
        {
            _books = new();
            _authors = new();
        }

        // Método POST para añadir un nuevo libro
        [HttpPost]
        public IActionResult AddBook([FromBody] BookEntity newBook)
        {
            try
            {
                // Validar que el Id del autor no sea nulo
                if (newBook.AuthorId == null)
                {
                    return BadRequest("El Id del autor no puede ser nulo.");
                }

                // Buscar el autor en la lista
                AuthorEntity author = _authors.FirstOrDefault(a => a.Id == newBook.AuthorId);

                // Si el autor no existe, devolver un BadRequest
                if (author == null)
                {
                    return BadRequest("El autor especificado no existe.");
                }

                // Asociar el libro con el autor y agregarlo a la lista de libros
                newBook.Author = author;
                _books.Add(newBook);

                // Devolver un mensaje de éxito
                return Ok($"Libro '{newBook.Title}' añadido con éxito, asociado al autor '{author.Name} {author.LastName}'.");
            }
            catch (Exception ex)
            {
                // Manejar errores y devolver un BadRequest con un mensaje de error
                return BadRequest($"Error al añadir el libro: {ex.Message}");
            }
        }
 
    }
}
