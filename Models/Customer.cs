using System.ComponentModel.DataAnnotations;

namespace MRent.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Address { get; set; }
        [EmailAddress]
        public string Email { get; set; }   
        public string PhoneNumber { get; set; } 
        public string Sex { get; set; }

        public ICollection<Rental>? Rental{ get; set; }

    }
}
