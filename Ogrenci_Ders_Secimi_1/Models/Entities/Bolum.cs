using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ogrenci_Ders_Secimi_1.Models
{
    public class Bolum
    {
        public int BolumId { get; set; }
        public string BolumAd { get; set; }
        public string BolumBaskani { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
        public List<BolumDers> BolumDersler { get; set; }
    }
}
