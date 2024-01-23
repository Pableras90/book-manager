using BookManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Application.Models
{
    public class AuthorModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime Birth { get; set; }
        public string CountryCode { get; set; } = string.Empty;
    }

}
