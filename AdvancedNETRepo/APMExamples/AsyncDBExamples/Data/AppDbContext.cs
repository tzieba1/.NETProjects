using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncDBExamples.Data
{
  // This DbContext was created prior to initial migration.
  class AppDbContext : DbContext
  {
    // String used to connect to a local database.
    private const string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=PersonDb;Trusted_Connection=True;";

    // Must override OnConfiguring to configure DbContextOptionsBuilder to UseSqlServer with the connectionString above.
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(connectionString);
    }

    // Classes that are models for the database are represented as DbSets
    public DbSet<Person> Persons { get; set; }
  }
}
