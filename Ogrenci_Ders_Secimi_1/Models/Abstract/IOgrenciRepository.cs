using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ogrenci_Ders_Secimi_1.Models.Abstract
{
    public interface IOgrenciRepository : IRepository<Ogrenci>
    {
        public void GetWithBolum();
        public Ogrenci GetByIdWithDersler();
    }
}
