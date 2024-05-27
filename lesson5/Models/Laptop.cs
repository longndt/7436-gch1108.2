using System.ComponentModel.DataAnnotations;

namespace lesson5.Models
{
    public class Laptop
    {
        //primary key
        [Key]
        public int Id { get; set; }
        //public int LaptopId { get; set; }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public string Image {  get; set; }
    }
}
