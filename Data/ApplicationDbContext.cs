using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcWebApplicationMucisStore.Models;

namespace MvcWebApplicationMucisStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MvcWebApplicationMucisStore.Models.Music> Music { get; set; }
        public DbSet<MvcWebApplicationMucisStore.Models.Songs> Songs { get; set; }
    }
}
