using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class AppDbContext :DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=sql.ects;Database=forratdb;User Id=student_05; Password=student_05; TrustServerCertificate = True; "); }
    }
}
