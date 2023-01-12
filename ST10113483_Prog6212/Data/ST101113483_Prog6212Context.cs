using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework.Exceptions.SqlServer;
using Microsoft.EntityFrameworkCore;
using ST101113483_Prog6212.Models;

namespace ST101113483_Prog6212.Data
{
    public class ST101113483_Prog6212Context : DbContext
    {
        public ST101113483_Prog6212Context (DbContextOptions<ST101113483_Prog6212Context> options)
            : base(options)
        {
        }

        public DbSet<ST101113483_Prog6212.Models.User> User { get; set; } = default!;

        public DbSet<ST101113483_Prog6212.Models.Module> Module { get; set; }
        public DbSet<ST101113483_Prog6212.Models.StudyDate> StudyDate { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseExceptionProcessor();
        }
    }
}
