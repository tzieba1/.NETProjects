using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoom.Models
{
  /// <summary>
  /// Database context used to perform sql commands, procedures, et cetera within web application.
  /// </summary>
  public class AppDbContext : DbContext
  {
    /// <summary>
    /// Default contstructor inheriting from base class, DbContext.
    /// </summary>
    /// <param name="options"></param>
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    /// <summary>
    /// Method needed to build a model for a derived context - during initialization of derived context.
    /// </summary>
    /// <param name="builder">The builder that defines the model for the context being created.</param>
    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
    }

    /// <summary>
    /// Property representing a model for a database table modelled to store entries modelled after a Message object.
    /// </summary>
    public DbSet<Message> Messages { get; set; }

    /// <summary>
    /// Property representing a model for a database table modelled to store entries modelled after a User object.
    /// </summary>
    public DbSet<User> Users { get; set; }

    /// <summary>
    /// Property representing a model for a database table modelled to store entries modelled after a Connection object.
    /// </summary>
    public DbSet<Connection> Connections { get; set; }

    //public DbSet<Room> Rooms { get; set; }
  }
}
