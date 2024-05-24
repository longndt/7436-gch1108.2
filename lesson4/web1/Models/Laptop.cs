using System.ComponentModel.DataAnnotations;

namespace web1.Models
{
    public class Laptop
    {
        //primary key
        public int Id { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Tên tối thiểu 5 ký tự")]
        [MaxLength(50, ErrorMessage = "Tên tối đa 50 ký tự")]
        public string Name { get; set; }

        [Required]
        [Range(100, 2000, ErrorMessage = "Giá tiền phải từ 100$ đến 2000$")]
        public decimal Price { get; set; }

        [StringLength(5000)]
        [Url]
        public string Image { get; set; }

        //? : nullable (optional)
        public string? Description { get; set; }
    }
}
