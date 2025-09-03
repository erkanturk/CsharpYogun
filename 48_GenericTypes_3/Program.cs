namespace _48_GenericTypes_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new BaseClass<int>().Value= 1;
            new BaseClass<string>().Value= "1";
            new ChildClass().Value=20.5;//hata verir.
            new ChildClass2<int>().Value2=20;
            new ChildClass2<int>().Value=20;
            new ChildClass3<int>().Value="10";
            new ChildClass3<DateTime>().Value="10";
            new ChildClass3<bool>().Value="10";
            new ChildClass3<bool>().Value3=true;


        }
    }
    class BaseClass<T>
    {
        public T Value { get; set; }
    }
    class ChildClass : BaseClass<int>//Generic bir sınıf yapısı olmadığı için bu alanda T değeri veremeyiz.
    {
        //Base classtaki propertye gelecek değeri mutlaka miras alınırken generic bir sınıf değilse bildirmeliyiz.
    }
    //Child class generic bir yapıda olduğı için base class da T olarak adlandırabiliriz
    //Bu yapıda kullanın T tanımlanırken belirtilebilir.
    class ChildClass2<T> : BaseClass<T>
    {
        public T Value2 { get; set; }
    }
    class ChildClass3<T> : BaseClass<string>
    {
        public T Value3 { get; set; }    
    }
}
