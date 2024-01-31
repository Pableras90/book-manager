using Microsoft.AspNetCore.Mvc;
using BookManager.Application.Services;
using BookManager.Application.Models;
using System.Reflection;

namespace BookManager.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly BookService _bookService;
        public BooksController(BookService bookService)
        {
            _bookService = bookService;
        }
        [HttpPost]
        public async Task<IActionResult> AddBook([FromBody] BookModel newBook)
        {
            try
            {
                await _bookService.Create(newBook);
                return Ok($"Libro '{newBook.Title}' añadido con éxito");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al añadir el libro: {ex.InnerException.Message}");
            }
        }
        [HttpPut("title/{id}")]
        public async Task<IActionResult> UpdateTitle(Guid id, string title)
        {
            try
            {
                await _bookService.UpdateTitle(id, title);
                return Ok($"Titulo modificado con éxito");

            }
            catch (Exception ex)
            {
                return BadRequest($"Error al modificar el título libro: {ex.InnerException.Message}");
            }
        }
        [HttpPut("description/{id}")]
        public async Task<IActionResult> UpdateDescription(Guid id, string description)
        {
            try
            {
                await _bookService.UpdateDescription(id, description);
                return Ok($"Descripción modificada con éxito");

            }
            catch (Exception ex)
            {
                return BadRequest($"Error al modificar la descripción del libro: {ex.InnerException.Message}");
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            try
            {
                var books = await _bookService.GetAllBooks();
                return Ok(books);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al obtener la lista de libros: {ex.InnerException.Message}");
            }
        }
    }
}
