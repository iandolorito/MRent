using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MRent.Models
{
    public class Rental
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public Customer? Customer { get; set; }
       
        public int MovieId { get; set; }
        [ForeignKey(nameof(MovieId))]
        public Movie? Movie { get; set; }

        public DateOnly RentDate { get; set; }

        public DateOnly ReturnDate { get; set; }
        public ICollection<RentalDetail>? RentalDetail { get; set; }

    }
}
