using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Upload.Models
{
    public class Employee
    {
        public string? Id {get; set;}
        public string? Name {get; set;}
        public string? Address {get; set;}
        public string? FacultyID {get; set;}
        [ForeignKey("FacultyID")]
        public string? sdt {get; set;}
    }
}