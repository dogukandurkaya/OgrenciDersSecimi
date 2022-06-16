using Microsoft.EntityFrameworkCore;
using Ogrenci_Ders_Secimi.Models;
using Ogrenci_Ders_Secimi_1.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ogrenci_Ders_Secimi_1.Models.Concrete.EFCore
{
    public class EFCoreOgrenciDAL : EFCoreGenericDAL<Ogrenci>, IOgrenciRepository
    {
        public Ogrenci GetByIdWithDersler(int id)
        {
            using (var context = new OgrenciDersSabahContext())
            {
                return context.Ogrenciler
                    .Where(x => x.OgrenciId == id)
                    .Include(x => x.OgrenciDersler)
                    .ThenInclude(x => x.Ders)
                    .FirstOrDefault();
            }
        }

        public Ogrenci GetByIdWithDersler()
        {
            throw new NotImplementedException();
        }

        public void GetWithBolum()
        {
            throw new NotImplementedException();
        }
    }
}
