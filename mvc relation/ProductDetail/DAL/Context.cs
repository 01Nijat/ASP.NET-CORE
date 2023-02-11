using Microsoft.EntityFrameworkCore;
using ProductDetail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDetail.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { 
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Picture> Pictures { get; set; }
    }
}

