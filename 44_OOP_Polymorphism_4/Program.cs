namespace _44_OOP_Polymorphism_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev
            //Ödev
            /* 
                Tekstil:Ad,Fiyat,KumasTuru,Beden,UreticiFirma = KDVUygular(%20)
                CepTelefonu:Ad,Fiyat,Özellik,Marka = KDVUygular(%120)
                Ekmek:Tür,Fiyat,Gramaj = KDVUygular(%10)

            Nesne özelliklerini constructor methodu ile alın.
            Sepet: Alınan ürünleri bir listeye kaydetsin toplam tutarı söylesin
            
            */
            #endregion

            Daire daire = new Daire(10);
            Daire daire2 = new Daire(100);
            Daire daire3 = new Daire(1000);
            Daire daire4 = new Daire(122);
            Console.WriteLine(daire.Alan());
            Console.WriteLine(daire2.Alan());
            Console.WriteLine(daire3.Alan());
            Console.WriteLine(daire4.Alan());
            DikDortgen dikDortgen = new DikDortgen(20, 10);
            Console.WriteLine(dikDortgen.Alan());
        }
    }
    public class Sekil
    {
        public const double PI = Math.PI;
        protected double x;
        protected double y;

        public Sekil(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual double Alan()
        {
            return x*y;
        }
    }
    public class DikDortgen : Sekil
    {
        //Dikdörtgen yapısı base class a bağımlı olduğu için bu alandaki bağımlılığı 
        //gerçekleştirmesi gerekir bu yapı nesne oluşturulduğu zaman base classdaki
        //özelliklere atanmalıdır.
        public DikDortgen(double x, double y) : base(x, y)
        {
        }
    }
    public class Daire : Sekil
    {
        public Daire(double r) : base(r, 0)
        {
        }
        public override double Alan()
        {
            return PI*x*x;
        }
    }
    public class Kure : Sekil
    {
        public Kure(double r) : base(r, 0)
        {

        }
        public override double Alan()
        {
            return 4*PI*x*x;
        }
    }
}
