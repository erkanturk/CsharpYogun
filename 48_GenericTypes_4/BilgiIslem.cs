using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _48_GenericTypes_4
{
    internal class BilgiIslem : Personel, IPersonel<BilgiIslem>
    {
        public int ProgramSayisi { get; set; }
        public void Delete(BilgiIslem entity)
        {
            
        }

        public BilgiIslem Find(int id)
        {
            if (id==Id)
            {
                Console.WriteLine("Listede bu Kullanıcı mevcut");
            }
            else
            {
                Console.WriteLine("Böyle bir kullanıcı bulunamadı");
            }
            return this;
        }

        public void Insert(BilgiIslem entity)
        {
            Console.WriteLine("ID");
            entity.Id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ad:");
            entity.Ad=Console.ReadLine();
            Console.WriteLine("Soyad");
            entity.Soyad=Console.ReadLine();
            Console.WriteLine("Tc");
            entity.Tc=Console.ReadLine();
            Console.WriteLine("Program Sayısı");
            entity.ProgramSayisi=Convert.ToInt32(Console.ReadLine());

            Ekle(entity);

        }
        private void Ekle(BilgiIslem bilgi)
        {
            List<BilgiIslem> listele = new List<BilgiIslem>();
            listele.Add(bilgi);
            foreach (var item in listele)
            {
                Console.WriteLine(bilgi.Ad+" "+bilgi.Soyad+" "+bilgi.Tc);
            }
        }
        public List<BilgiIslem> List()
        {
            throw new NotImplementedException();
        }

        public List<BilgiIslem> List(Expression<Func<BilgiIslem, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(BilgiIslem entity)
        {
            throw new NotImplementedException();
        }
    }
}
