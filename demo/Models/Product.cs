using System.ComponentModel.DataAnnotations;

namespace demo.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        //[Required]
        //[MinLength(3)]
        //[MaxLength(30)]
        [StringLength(30, MinimumLength = 3, 
            ErrorMessage = "Product name must be 3 to 30 characters")]
        //ErrorMessage: optional => customize message
        public string Name { get; set; }

        //public double Price { get; set; }
        [Range(100, 3000, ErrorMessage = "Product price must be from 100$ to 3000$")]
        public decimal Price { get; set; }

        public string Image { get; set; }
    }
}
