using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using HarrisContactManager.NETCore.Models;
using System.Threading.Tasks.Dataflow;

namespace HarrisContactManager.NETCore.Data
{
    public class HarrisDbContext : DbContext 
    {
        public HarrisDbContext(DbContextOptions<HarrisDbContext> options) : base(options)
        {
        }

        public DbSet<PersonalContact> personalContacts { get; set; }
        public DbSet<BusinessContact> businessContacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
        
    }
}
