namespace _46_OOP_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Abstract Nedir ?
             * Abstract class'lar oluşturulması istenen class'ların sadece base class olarak davranması
             * ve üzerinden bir instance (örneklem/nesneleme) oluşturulmamasını istediğimiz durumlarda kullanılır
             * C# da bu fonksiyonaliteyi sağlamak için abstract keywordu kullanımı yeterlidir.
             * Abstract sınıflar  içerisinde gövdesiz methodlar tanımlayabiliriz 
             * Bu methodlar miras alınan sınıf içerisinde mutlaka gövdeleri doldurulmalıdır.
             * Abstract sınıflar alt sınıflara abstract olan yapıları kullanmaya zorlar.
             * Bu işleme biz implemete deriz.
             * Abstract olarak işaretlenen yapılar override edilebilirler.
             * Sadece methodlar değil Propertyler de abstrac olabilirler.

            */
            ////Insan insan = new Insan();//Soyut bir yapıdan nesne üretilemez.
            //Veli veli = new Veli();
            //veli.Create();
            //veli.Update();
            //veli.Delete();
            //veli.List();
            //veli.Find(10);
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Create();

        }
    }


    abstract class Insan //Bu yapıdan nesne üretilemez Base Class olarak işaretledik
    {
        public abstract long Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public abstract void Create();//Gövdesiz method 
        //Eğer bir sınıf yapısı Insan sınıfından miras alacaksa bu yapıyı implemete etmek zorundadır.
        public abstract void Update();
        public abstract void List();
        public abstract void Delete();
        public void Find(int id)
        {
            Console.WriteLine(id);//Gövdeli method.
        }
    }
    class Ogrenci : Insan
    {
        public string DersAdi { get; set; }
        public int DersSayisi { get; set; }
        public int OkulNo { get; set; }
        public override long Tc { get ; set ; }
       

        public override void Create()
        {
          
            Console.WriteLine("Tc:");
            Tc=long.Parse(Console.ReadLine());
            Console.WriteLine("Ders sayısı");
            DersSayisi=int.Parse(Console.ReadLine());
            Console.WriteLine("Ders Adı");
            DersAdi=Console.ReadLine();
            Console.WriteLine("Okul Numarası");
            OkulNo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Listelemek ister misin ? (E/H)");
            string secim = Console.ReadLine();
            if (secim.ToUpper()=="E")
            {
                List();
            }
            else
            {
                Console.WriteLine("Sen bilirsin !!!!");
            }

        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void List()
        {
           //base.List(); Polymorphismde base yapıyı kullanabiliriz çünkü yapının gövdesi mevcuttur
           //fakat abstract yapıda gövdesiz methoda bir işlem yaptıramayız soyuttur.
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }

    }
    class Ogretmen : Insan
    {
        public override long Tc { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void List()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
    class Veli : Insan
    {
        public string Tel { get; set; }
        public override long Tc { get ; set; }

        public override void Create()
        {
            Console.WriteLine("Adınız");
            Ad=Console.ReadLine();
            Console.WriteLine("Soyadınız");
            Soyad=Console.ReadLine();
            Console.WriteLine("Tc:");
            Tc=long.Parse(Console.ReadLine());
            Console.WriteLine("Telefon No:");
            Tel=Console.ReadLine();

            Console.WriteLine("Listelemek ister misin ? (E/H)");
            string secim = Console.ReadLine();
            if (secim.ToUpper()=="E")
            {
                List();
            }
            else
            {
                Console.WriteLine("Sen bilirsin !!!!");
            }

        }

        public override void Delete()
        {
            Ad="";
            Soyad="";
            Tc=0;
            Tel="";
        }

        public override void List()
        {
            Console.WriteLine(Ad+" "+Soyad+" "+Tc+" "+Tel);
        }

        public override void Update()
        {
            Create();
        }
    }
}
