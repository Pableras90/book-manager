using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using BookManager.Domain;
using BookManager.Application.Models;
using BookManager.Application.Services;

namespace BookManager.Controllers
{
    [Route("api/[controller]")]
    public class AuthorsController : ControllerBase
    {
        private readonly AuthorService _authorService;

        // Constructor que inicializa _authors con una nueva lista vacía
        public AuthorsController(AuthorService authorService)
        {
           _authorService = authorService;
        }

        // Método POST para añadir un nuevo autor
        [HttpPost]
        public async Task<IActionResult> AddAuthor([FromBody] AuthorModel newAuthor)
        {
            try
            {
                await _authorService.Create(newAuthor);
                return Ok($"Autor {newAuthor.Name} {newAuthor.LastName} añadido con éxito.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al añadir el autor: {ex.InnerException.Message}");
            }
        }
    }
}
