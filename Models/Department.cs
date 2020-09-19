using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCore.Models
{
    public class Department
    {
        [Key]
        public int Department_Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(250)")]
        public string DepartmentName { get; set; }

        [Column(TypeName = "bit")]
        public Boolean Status { get; set; }
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
