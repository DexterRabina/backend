using System.ComponentModel.DataAnnotations;

namespace backenddotnet.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set;}

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string? Address { get; set; }

        public string? SUitType { get; set; }

        public DateOnly CheckIn { get; set; }

        public DateOnly CheckOut { get; set; }

        public int? NumOfKids { get; set; }

        public int? NumOfAdults { get; set; }

        public string? Request { get; set; }

    }
}
