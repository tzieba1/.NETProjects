using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncDBExamples.Data
{
  class AppDbContext : DbContext
  {
    private const string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=PersonDb;Trusted_Connection=True;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(connectionString);
    }

    public DbSet<Person> Persons { get; set; }
  }
}
