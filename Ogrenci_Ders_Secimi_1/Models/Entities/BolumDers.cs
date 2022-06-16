using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ogrenci_Ders_Secimi_1.Models
{
    public class BolumDers
    {
        public int BolumDersId { get; set; }
        public int BolumId { get; set; }
        public Bolum Bolum { get; set; }
        public int DersId { get; set; }
        public Ders Ders { get; set; }
    }
}
