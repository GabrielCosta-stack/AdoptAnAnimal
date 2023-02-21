using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Animal> Animals {get; set;}

        public DbSet<Specie> Species {get; set;}

        public DbSet<Photo> Photos {get; set;}
    }
}