using Constructor.Storage.Models;
using Constructor.Storage.Containers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Constructor.Storage
{
    public class DbContent:DbContext
    {
        protected readonly IConfiguration Configuration;

        public DbContent(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            options.UseMySql(
               connectionString,
               new MySqlServerVersion(new Version(8, 0, 11))
           );
        }
        public DbSet<CpuFan> CpuFans
        { get; set; }
        public DbSet<Case> Cases
        { get; set; }
        public DbSet<CPU> CPUs
        { get; set; }
        public DbSet<Drive> Drives
        { get; set; }
        public DbSet<FAN> FANs
        { get; set; }
        public DbSet<FSP> FSPs
        { get; set; }
        public DbSet<GPU> GPUs
        { get; set; }
        public DbSet<Motherboard> Motherboards
        { get; set; }
        public DbSet<RAM> RAMs
        { get; set; }
        public DbSet<Assembly> Assemblies
        { get; set; }
        public DbSet<DriveAndAssemblyPair> DAPairs
        { get; set; }
        public DbSet<FanAndAssemblyPair> FAPairs
        { get; set; }
        public DbSet<RamAndAssemblyPair> RAPairs
        { get; set; }
    }
}
