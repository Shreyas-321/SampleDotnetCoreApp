using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDotnetCoreApp.PatientRecordManagement

{
    [Table("PatientRecord")]
    internal class PatientComponent
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? DateOfBirth { get; set; }
        [Required]
        public int Age { get; set; }
        public string? BloodGroup { get; set; }

    }
    class PatientContext : DbContext
    {
        public DbSet<PatientComponent> Patients { get; set; }

        public IConfigurationRoot? Configuration { get; set; }

        private void ConfigureServices()
        {
            var conf = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false).Build();
            if ((conf == null))
            {
                throw new Exception("config is failed");
            }
            Configuration = conf;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            ConfigureServices();
            var connectionString = Configuration["connectionStrings"];
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
