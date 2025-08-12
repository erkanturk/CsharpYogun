namespace _02_Degisken_VeriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler 
            /*
             Değişken:Programlama tarafında data(veri) tutmak,taşımak veya bir işlem 
            uygulamak için kullanılan yapılardır. 
            */
            //erkan bu şekilde bir veri tutamam.
            //string ad = "Erkan";  //string metinsel ifadeleri taşıyan bir veri tipidir.
            ////string bir değişkene veri aktarmak için "" çift tırnak arasına yazmamız gerekir.
            //Console.WriteLine(ad);
            ////string ad = "Türk";//Aynı değişkeni birden fazlakez tanımlayamayız ama güncelleyebiliriz.
            //ad="Onur";//ad değerini tekrardan değer atayarak içindeki veriyi değiştirdik.
            //Console.WriteLine(ad);

            //char harf = 'A';//char tek bir değer taşıyan bir yapıdır. bu yapı tek tırnaklar içine yazılır.
            //Console.WriteLine(harf);
            //string Ad = "Altan Emre"; bu Ad değişkeni yukarıdaki değerden farklıdır 
            //Ascii table da karakterlerin rakamsal değeri bulunduğu için yazılım tarafıda 
            //büyük küçük duyarlılığı vardır.

            int sayi = 10;//int tam sayı tipinde 10 haneye kadar değer tutabilen rakamsal veri tipidir.
            byte sayi2 = 255;//0 ila 255 değeri arasında  en küçük tam sayı tutan veri tipidir.
            long sayi3 = 10;//tam sayı tipinde en uzun rakamsal veri yapısıdır.
            float sayi4 = 10.5f;//float ondalıklı sayılar için kullanılan bir veri tipidir sonuna f ifadesi verilir
            double sayi5 = 20.5;//double ondalıklı sayılar için kullanılan orta büyüklükte veri tipidir.
            decimal sayi6 = 30.5m;//decimal en büyük ondalıklı sayılar için kullanılan veri tipidir.
            //değişkenler çağrılmadığı yada işlem yapılmadığı sürece sadece tanımlı halde kalır.
            bool dogru = false;//mantıksal değer tutan true veya false olarak veri tutan veri tipidir.
            //1 ifadesi true 0 ifadesi ise false olarak temsil edilir.
            Console.WriteLine("Value type stack(Ram'in Sol bölgesi)");
            Console.WriteLine($"int max: {int.MaxValue} min: {int.MinValue}");//$ işareti string interpolation bu ifade ile metinsel bir yapıda 
                                                                              //yazılımsan bir veri tanımlanmasını sağlar.
                                                                              //Console.WriteLine("int max: {int.MaxValue} min: {int.MinValue}");
                                                                              //bu alanda $ işareti olmadığı için değerleri yukarıdaki örnekteki gibi göstermez bize.
            Console.WriteLine($"byte max: {byte.MaxValue} min: {byte.MinValue} ");
            Console.WriteLine($"long max: {long.MaxValue} min: {long.MinValue} ");
            Console.WriteLine($"float max: {float.MaxValue} min: {float.MinValue} ");
            Console.WriteLine($"double max: {double.MaxValue} min: {double.MinValue} ");
            Console.WriteLine($"decimal max: {decimal.MaxValue} min: {decimal.MinValue} ");
            Console.WriteLine(dogru);

            var degisken = 10;//Verdiğimiz değere göre şekillenen bir veri tipidir.
            var degisken2 = "metin";
            var harf2 = 'A';
            Console.WriteLine("Referance type'lar heap ram'in sağ bölgesi");
            object nesne = 10.5;//her değer birer objedir her veri tipini içerisinde barındırır.
            object nesne2 = "10.5";
            const double sabit = 3.14;//sabit yapılardır bu yapı değiştirilemez tanımlanma kısmında 
            //atanan değeri içinde barındırır.
            //sabit=3.15;//Hata verir const olarak tanımlanmıştır.
            //string ve object heap tarafında tutulur.
            /*Syntax 
            SnakeCase=ad_soyad;
            CamelCase=adSoyad;
            KebapCase=ad-soyad;
            UpperCase=ADSOYAD;
            LowerCase=adsoyad;
            yanlış tanımlama biçimi
            2sayi,?sayi,!sayi,ad soyad,ad!soyad,sayi? v.b. türkçe karakterlerde kullanmamız gerekir
            İ,ı,ü,Ü,ğ,Ğ,ö,Ö,ç,Ç,ş,Ş gibi karakterler de kullanmamamız gerekir ingilizce olarak tanımlamalıyız.
            Doğru yanımlar
            sayi2,_sayi, adsoyad,ad_soyad,sayi_,
            Yazılım dillerinde kabul edilen tek özel karakter _ alt çizgidir.

                
            
            */

        }
    }
}
