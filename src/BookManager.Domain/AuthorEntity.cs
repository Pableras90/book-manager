﻿namespace BookManager.Domain;

public class AuthorEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string LastName{get; set; } = string.Empty;
    public DateTime Birth { get; set; }
    public string CountryCode { get; set; } = string.Empty;
}
