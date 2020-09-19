using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCore.Models
{
    public class Student
    {
        //prop double tab
        //install package 1-Microsoft.EntityFrameworkCore.SqlServer 2-Microsoft.EntityFrameworkCore.Tools 3-Microsoft.EntityFrameworkCore

        [Key]
        public int Id { get; set; }
        [Column(TypeName ="varchar(250)")]
        [Required]
        public string Student_Code  { get; set; }
       
        [Column(TypeName = "varchar(250)")]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "int")]
        public int City { get; set; }
        [Column(TypeName = "int")]
        public int Branch { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string DOB { get; set; }

        [Column(TypeName = "bit")]
        public bool Gender { get; set; }

        [Column(TypeName = "bit")]
        public Boolean Statuts { get; set; }
        [Column(TypeName = "int")]

        public int Created_By { get; set; }
        [Column(TypeName = "DateTime")]
        public DateTime Created_Date { get; set; }
        [Column(TypeName = "int")]
        public int Modified_By { get; set; }
        [Column(TypeName = "DateTime")]
        public DateTime Modified_Date { get; set; }

    }
}
