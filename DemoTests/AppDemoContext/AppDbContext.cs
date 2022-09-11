using DemoTests.Demo;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoTests.AppDemoContext
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration _configuration;
        public AppDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<DemoModel> DemoModels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<DemoModel>().ToTable("DemoModel");
            builder.Entity<DemoModel>().HasKey(p => p.Id);
            builder.Entity<DemoModel>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<DemoModel>().Property(p => p.isAuthenticated);


            builder.Entity<DemoModel>().HasData(
    new DemoModel
    {
        Id = 3,
        isAuthenticated = false
    }
);
        }

    }
}
