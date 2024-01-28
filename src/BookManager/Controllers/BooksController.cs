using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using BookManager.Domain;
using BookManager.Application.Services;
using BookManager.Application.Models;

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
                return BadRequest($"Error al añadir el libro: {ex.Message}");
            }
        }

    }
}
