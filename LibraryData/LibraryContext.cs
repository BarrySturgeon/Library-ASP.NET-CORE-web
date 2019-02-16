using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LibraryData
{
    public class LibraryContext: DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options) { }

        public DbSet<Patron> Patrons { get; set;  }


    }
}
