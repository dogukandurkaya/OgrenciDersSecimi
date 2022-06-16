using Ogrenci_Ders_Secimi.Models;
using Ogrenci_Ders_Secimi_1.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ogrenci_Ders_Secimi_1.Models.Concrete.EFCore
{
    public class EFCoreGenericDAL<T> : IRepository<T> where T : class, new()
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            using (var context = new OgrenciDersSabahContext())
            {
                return context.Set<T>().ToList();
            }

        }

        public T GetById(int id)
        {
            using (var context = new OgrenciDersSabahContext())
            {
                return context.Set<T>().Find(id);
            }
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
