namespace _47_OOP_Interface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //interfaceler public olmalıdır.
        }
    }
   public abstract class Elektronik//:ISarjli Bir sınıf interfaceden miras alabilir ama bir interface sınıftan miras alamaz
        //Her sınıfın arka planında bir ctor çalışır fakat arabirimlerde bu özellik yoktur bu yüzden sınıfı miras alamazlar
    {
        public abstract string Name { get; }
        public abstract string Price { get; }
        public int SarjSayisi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MiliAmper { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
   public interface ISarjli
    {
         int SarjSayisi { get; set; }
         int MiliAmper { get; set; }
    }
   public interface IElektrikli:ISarjli
    {
         int Volt { get; set; }
         string Enerji { get; set; }

    }
   public class Laptop : Elektronik, IElektrikli
   {
        public override string Name => throw new NotImplementedException();

        public override string Price => throw new NotImplementedException();

        public int Volt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Enerji { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SarjSayisi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MiliAmper { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
