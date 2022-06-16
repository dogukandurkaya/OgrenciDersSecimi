using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ogrenci_Ders_Secimi_1.Models
{
    public class OgrenciDers
    {
        public int OgrenciDersId { get; set; }
        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }

        public int DersId { get; set; }
        public Ders Ders { get; set; }
    }
}
