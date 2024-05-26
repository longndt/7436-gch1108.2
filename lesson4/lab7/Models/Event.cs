using System.ComponentModel.DataAnnotations;

namespace eventures.Models
{
    public class Event
    {
        //primary key
        public int Id { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Event name must be at least 10 characters")]
        public string Name { get; set; }

        [Required]
        public string Place { get; set; }

        [Required]
        public DateOnly Start { get; set; }

        [Required]  
        public DateOnly End { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int TotalTickets { get; set; }

        [Required]
        [Range(10, 200)]
        public decimal PricePerTicket { get; set; }

    }
}
