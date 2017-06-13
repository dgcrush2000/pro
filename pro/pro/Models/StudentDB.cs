using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace pro.Models
{
    public class StudentDB :DbContext
    {
        public StudentDB():base("DBConnectionString")
        {
            Database.SetInitializer<StudentDB>(new CreateDatabaseIfNotExists<StudentDB>());
        }
        public DbSet<Students> student { get; set; }
        public DbSet<Employees> employee { get; set; }

    }
}