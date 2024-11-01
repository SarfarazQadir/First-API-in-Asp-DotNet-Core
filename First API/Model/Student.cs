using System.ComponentModel.DataAnnotations;

namespace First_API.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Batch { get; set; }
    }
}
