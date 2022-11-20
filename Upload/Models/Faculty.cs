using System.ComponentModel.DataAnnotations;

namespace Upload.Models
{
    public class Faculty
    {
        [Key]
        public string? FacultyID {get; set;}
        public string? FacultyName {get; set;}

    }
}