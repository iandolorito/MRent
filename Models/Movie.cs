using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace MRent.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; } 
        public string Title{ get; set; }
        public string Director{ get; set; }
        public string Genre { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public double Price     { get; set; }
        public ICollection<Rental>? Rental { get; set; }
        public ICollection<RentalDetail>? RentalDetail { get; set; }
    }
}
