using System;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreWebApplication.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
