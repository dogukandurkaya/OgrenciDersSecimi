using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ogrenci_Ders_Secimi_1.Models
{
    public class Ogrenci
    {
        public int OgrenciId { get; set; }
        public int OgrenciNo { get; set; }
        public string OgrenciAd { get; set; }
        public string OgrenciSoyAd { get; set; }
        public DateTime? OgrenciDogumTarihi { get; set; }
        public DateTime? OgrenciKayitTarihi { get; set; }
        public int OgrenciDonemi { get; set; }
        public List<OgrenciDers> OgrenciDersler { get; set; }
        public int BolumId { get; set; }
        public virtual Bolum Bolum { get; set; }

    }
}
