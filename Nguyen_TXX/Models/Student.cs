using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  Nguyen_TXX.Models
{
    public class Student
    {
        [Key]
        [Required(ErrorMessage ="StudentID không duoc de trong")]
        [MinLength(3)]
        public string? StudentID {get; set;}

        [Required(ErrorMessage ="empName không duoc de trong")]
        public string? Name {get; set;}
        
        public string? Address {get; set;}
        public string? sdt {get; set;}
        
    }
}