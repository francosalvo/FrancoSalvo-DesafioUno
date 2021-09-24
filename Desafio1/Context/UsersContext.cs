using Desafio1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Desafio1.Context
{
    public class UsersContext : DbContext
    {
        public const string Schema = "Users";

        public UsersContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema(Schema);

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Posteo> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
