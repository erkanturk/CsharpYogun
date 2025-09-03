using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _48_GenericTypes_4
{
    internal class InsanKaynaklari : Personel, IPersonel<InsanKaynaklari>
    {
        //Generic yapı bu sınıf özelinde işlem yapmasını sağlayacaktır 
        //Interface de tanımlanmış bir generic yapı burada implemete edilmek zorunda ve bu 
        //methodların gövdelerini kullanmak zordundadır
        //Gövdesiz methodlar bu alanda somutlaştırılarak sınıf özelinde yapmak istenilen işleri yapacaktır.
        public int PersonelSayisi {  get; set; }
        public void Delete(InsanKaynaklari entity)
        {
            throw new NotImplementedException();
        }

        public InsanKaynaklari Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(InsanKaynaklari entity)
        {
            throw new NotImplementedException();
        }

        public List<InsanKaynaklari> List()
        {
            throw new NotImplementedException();
        }

        public List<InsanKaynaklari> List(Expression<Func<InsanKaynaklari, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(InsanKaynaklari entity)
        {
            throw new NotImplementedException();
        }
    }
}
