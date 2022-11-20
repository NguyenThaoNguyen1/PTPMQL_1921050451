using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Id_tu_dong.Models
{
    public class Student
    {
        [Key]
        [Required(ErrorMessage ="StudentID không duoc de trong")]
        [MinLength(3)]
        public string? StudentID {get; set;}

        [Required(ErrorMessage ="empName không duoc de trong")]
        public string? Name {get; set;}
        public string? FacultyID {get; set;}
         
        public string? Address {get; set;}
        public string? sdt {get; set;}
        
    }
}