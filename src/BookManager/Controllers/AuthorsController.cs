using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using BookManager.Domain;

namespace BookManager.Controllers
{
    [Route("api/[controller]")]
    public class AuthorsController : ControllerBase
    {
        private readonly List<AuthorEntity> _authors;

        // Constructor que inicializa _authors con una nueva lista vacía
        public AuthorsController()
        {
            _authors = new List<AuthorEntity>();
        }

        // Método POST para añadir un nuevo autor
        [HttpPost]
        public IActionResult AddAuthor([FromBody] AuthorEntity newAuthor)
        {
            try
            {
                // Puedes agregar validaciones adicionales antes de añadir el autor a la lista
                // Por ejemplo, validar que los datos sean válidos

                _authors.Add(newAuthor);

                // Puedes devolver una respuesta indicando el éxito
                return Ok($"Autor {newAuthor.Name} {newAuthor.LastName} añadido con éxito.");
            }
            catch (Exception ex)
            {
                // Manejo de errores, puedes personalizar según tus necesidades
                return BadRequest($"Error al añadir el autor: {ex.Message}");
            }
        }
    }
}
