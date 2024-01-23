using BookManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Application.Models
{
    public class BookModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime PublishedOn { get; set; }
        public string Description { get; set; } = string.Empty;

        public int AuthorId { get; set; }

    }
}
