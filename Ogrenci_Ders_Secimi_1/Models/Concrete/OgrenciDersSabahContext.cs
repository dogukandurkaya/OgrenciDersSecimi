using Microsoft.EntityFrameworkCore;
using Ogrenci_Ders_Secimi_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ogrenci_Ders_Secimi.Models
{
    public class OgrenciDersSabahContext : DbContext
    {
        public OgrenciDersSabahContext()
        {

        }

        public OgrenciDersSabahContext(DbContextOptions<OgrenciDersSabahContext> options) : base(options)
        {

        }

        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<OgrenciDers> OgrenciDersler { get; set; }
        public DbSet<BolumDers> BolumDersler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-OVE5E20\\SQLEXPRESS; Database=OgrenciDersSabah; Trusted_Connection=True;");
            }
        }
    }

}