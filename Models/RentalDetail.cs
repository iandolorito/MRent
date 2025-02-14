using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MRent.Models
{
    public class RentalDetail
    {
        [Key] 
        public int Id { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public Customer? Customer { get; set; }

        public int MovieId { get; set; }
        [ForeignKey(nameof(MovieId))]
        public Movie? Movie { get; set; }

        public int RentalId { get; set; }
        [ForeignKey(nameof(RentalId))]
        public Rental? Rental { get; set; }

    }
}
