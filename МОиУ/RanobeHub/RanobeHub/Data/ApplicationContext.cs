using Microsoft.EntityFrameworkCore;
using RanobeHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RanobeHub.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<TranslatedText> TranslatedTexts { get; set; }
    }
}
