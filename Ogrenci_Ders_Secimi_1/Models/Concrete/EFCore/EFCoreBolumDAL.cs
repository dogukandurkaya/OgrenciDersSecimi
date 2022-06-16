using Ogrenci_Ders_Secimi_1.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ogrenci_Ders_Secimi_1.Models.Concrete.EFCore
{
    public class EFCoreBolumDAL: EFCoreGenericDAL<Bolum>, IBolumRepository
    {
    }
}
