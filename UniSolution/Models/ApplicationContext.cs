
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace UniSolution.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Tanque> Tanque { get; set; }

        public ApplicationContext() { }

        // para usar o migration
        //public ApplicationContext(DbContextOptions options) : base(options) { }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Tanque>().HasKey(t => t.Deposito);
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }
    }

    //// é necessário para usar o migration
    //public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    //{
    //    public ApplicationContext CreateDbContext(string[] args)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
    //        string conn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
    //        optionsBuilder.UseSqlServer(conn);
    //        return new ApplicationContext(optionsBuilder.Options);
    //    }
    //}
}