using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ogrenci_Ders_Secimi_1.Models
{
    public class Ders
    {
        public int DersId { get; set; }
        public string DersAd { get; set; }
        public string DersOgretmeni { get; set; }
        public int DersKredi { get; set; }
        public int DersDonemi { get; set; }
        public List<OgrenciDers> OgrenciDersler { get; set; }
        public List<BolumDers> BolumDersler { get; set; }
    }
}
