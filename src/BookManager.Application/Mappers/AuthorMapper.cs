using BookManager.Application.Models;
using BookManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Application.Mappers;

public static class AuthorMapper
{
    public static AuthorEntity MapToEntity(this AuthorModel model)
    {
        return new AuthorEntity
        {   
            Id = model.Id,
            Name = model.Name,
            LastName = model.LastName,
            Birth = model.Birth,
            CountryCode = model.CountryCode
        };
    }
}
