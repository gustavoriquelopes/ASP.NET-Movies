using System;
using System.ComponentModel.DataAnnotations;         //essa linha
using System.ComponentModel.DataAnnotations.Schema;  // essa linha

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }

    [Display(Name = "Release Date")]                 //essa linha
    [DataType(DataType.Date)]                        //essa linha
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }
    [Column(TypeName = "decimal(18, 2)")]           //essa linha
    public decimal Price { get; set; }
}
