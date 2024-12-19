using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;
using Netivot.Core.Entities;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Netivot.Data
{
    public class DataContext:DbContext
    {
        public DbSet<AvrechEntity> avrechim { get; set; }
        public DbSet<DonationEntity> donations { get; set; }
        public DbSet<DonorEntity> donors { get; set; }
        public DbSet<MeetingEntity> meetings { get; set; }
        public DbSet<MitchazekEntity> mitchazkim { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-JIPBU2P\MSSQLSERVER02;Database=netivot_db;Integrated Security=True;");
        } 
    }
   
    
}
