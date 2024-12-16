using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data
{
   
    public class AdatbazisKapcsolat : DbContext 
    {
        public AdatbazisKapcsolat(DbContextOptions<AdatbazisKapcsolat> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LottoAPIContext-e357d016-9434-4ef4-ad05-988a8e6aa4a5;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<ClassLibrary.Models.Lottoszam> Lottoszam { get; set; } = default!;
    }
}
