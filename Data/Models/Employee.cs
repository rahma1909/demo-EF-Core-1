using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Data.Models
{
    //poco class
    //plain old c# (clr) obj

    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } //pk


        [Column(TypeName = "varchar")]
        [StringLength(100, MinimumLength = 10)]
        //[MaxLength(100)]
        //[MinLength(10)]// use as application validation
        public required string Name { get; set; } //reference type


        [Range(22, 60)]
        [AllowedValues(20,22,32)]
        [DeniedValues(50,60,70)]
        public int? Age { get; set; }


        [Column(TypeName = "decimal(12,2)")]
        [DataType(DataType.Currency)]
        public double Salary { get; set; }//nullable value type =>allow null


        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string? PhoneNum { get; set; }

        [DataType(DataType.Password)]
        public string? Password { get; set; }
    
}
