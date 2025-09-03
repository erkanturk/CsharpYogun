using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _48_GenericTypes_4
{
    //where koşul ifadesidir bu T type yapısının zorunlu olarak sınıf tipi barındıracağını belirtiriz.
    internal interface IPersonel<T> where T : class
    {

        void Insert(T entity);//Create
        void Update(T entity);//Update
        void Delete(T entity);//Delete
        List<T> List();//Read
        //Linq sorgusunda bize tüm yapıyı getirecek (Listeleyecek ve bu list yapısı koşullu olacak.)
        //Örnek olarak Arabalardan kırmızı olan varsa true dönecek ve getirme işlemi yapacak.

        List<T> List(Expression<Func<T, bool>> expression);
        T Find(int id);
    }
}
