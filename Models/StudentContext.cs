using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCore.Models
{
    public class StudentContext :DbContext
    {

      //ctor  DbContextOptions provid which type of Database like sql, orical etc 
        public StudentContext(DbContextOptions<StudentContext> options) :base(options)
        {
          

        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Department> Departments { get; set; }
    }

}
