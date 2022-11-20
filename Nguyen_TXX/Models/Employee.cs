using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  Nguyen_TXX.Models
{
    public class EmPloyee
    {
        [Key]
        [Required(ErrorMessage ="StudentID không duoc de trong")]
        [MinLength(3)]
        public string? EmPloyeeID {get; set;}

        [Required(ErrorMessage ="empName không duoc de trong")]
        public string? EmPloyeeName {get; set;}
        
        public string? Address {get; set;}

        public string? sdt {get; set;}
        public string? GioiTinh {get; set;}
       
       
        [Display(Name = "Ngaysinh")]
        [DataType(DataType.Date)]
        public DateTime Ngaysinh { get; set; }


        
    }
}