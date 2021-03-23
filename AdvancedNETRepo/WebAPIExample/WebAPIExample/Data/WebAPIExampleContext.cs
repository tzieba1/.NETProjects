using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIExample.Models;

namespace WebAPIExample.Data
{
    public class WebAPIExampleContext : DbContext
    {
        public WebAPIExampleContext (DbContextOptions<WebAPIExampleContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPIExample.Models.Person> Person { get; set; }
    }
}
