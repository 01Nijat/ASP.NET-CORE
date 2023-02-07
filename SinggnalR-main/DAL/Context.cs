using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SinggnalR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinggnalR.DAL
{
    public class Context:IdentityDbContext
    {
        public Context(DbContextOptions<Context>options):base(options)
        {

        }

        public DbSet<AppUser> AppUsers { get; set; }
    }
}
