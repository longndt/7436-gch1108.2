using System.ComponentModel.DataAnnotations;

namespace web2.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name can not be blank")]
        public string Name { get; set; }

        public DateOnly BirthDate { get; set; }
    }
}
