namespace _45_Etut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(10);
            //list.Add(100);
            //list.Add(1000);
            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //List<Araba> arabaListesi = new List<Araba>();
            //Araba araba = new Araba();
            //try
            //{
            //    //araba.Marka="Ford";
            //    //araba.Model="Mustang";
            //    //araba.Sekment='C';
            //    //araba.ParkSensoru=true;
            //    //araba.UretimYili=2025;
            //    //Console.WriteLine("Id Yi belirtin");
            //    //araba.Id=Convert.ToInt32(Console.ReadLine());
            //    //arabaListesi.Add(araba);
            //    //Araba araba2 = new Araba();
            //    //araba2.Marka="Nissan";
            //    //araba2.Model="GTR34";
            //    //araba2.Sekment='C';
            //    //araba2.ParkSensoru=true;
            //    //araba2.UretimYili=2018;
            //    //araba2.Id=2;
            //    //arabaListesi.Add(araba2);

            //    foreach (Araba item in arabaListesi)
            //    {
            //        Console.WriteLine(item.Marka+" "+item.Model+" "+item.Sekment+" "+item.UretimYili+" "+item.CıkısYili+" "+item.ParkSensoru+" "+item.Id);
            //    }
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    arabaListesi.Add(araba);
            //}
            string ad = "erkan";
            ad="Ali";

            #endregion

            #region Enum
            List<Araba> arabaListesi = new List<Araba>();
            Araba araba3 = new Araba();
            araba3.Marka="Ford";
            araba3.Model="Mustang";
            araba3.Sekment='C';
            araba3.ParkSensoru=true;
            araba3.UretimYili=2025;
            Console.WriteLine("Id Yi belirtin");
            araba3.Id=Convert.ToInt32(Console.ReadLine());
            araba3.Vites=Vites.Otomatik;
            arabaListesi.Add(araba3);



            foreach (Araba item in arabaListesi)
            {
                Console.WriteLine(item.Vites+" "+item.Marka+" "+item.Model+" "+item.Sekment+" "+item.UretimYili+" "+item.CıkısYili+" "+item.ParkSensoru+" "+item.Id);
            }
            Console.WriteLine(typeof(Vites));
            #endregion
        }
    }
    enum Vites { Otomatik=1, Manuel, YarıOto }
    class Araba
    {
        public int Id;
        public Vites Vites;
        public int UretimYili { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public bool ParkSensoru { get; set; }
        public char Sekment { get; set; }
        //Datetime now kısmından değerleri alacağını söyledik
        public DateTime CıkısYili { get; set; } = DateTime.Now;

        //public int _Id
        //{
        //    get { return Id; }

        //    set
        //    {
        //        if (IsValidInteger(value.ToString()))
        //        {
        //           Id = value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Hatalı Id girişi");
        //        }
        //    }
        //}
        //private bool IsValidInteger(string value)
        //{
        //    return int.TryParse(value, out Id);
        //}
        public virtual void Kdv()
        {
            const double kdv = 1.20;
        }

    }
    class test:Araba
    {
        public override void Kdv()
        {
           const double kdv = 1.35;
        }
    }
}
