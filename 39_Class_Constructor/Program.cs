namespace _39_Class_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Constructor(Yapıcı method)
             * Constructor ctor olarakta tanımlanır bir sınıftan
             * instance oluşturulduğunda ilk çalışacak yapıdır
             * Eğer bir sınıfta constructor tanımlanmazsa
             * Arka planda boş bir constructor tanımlanır
             * biz bu yapıyı görmeyiz fakat her new keywordünde bu yapı çalışır
             * this keywordü constructor yapısını tetikler.
             * Constructor yapısı overload edilebilir
             * Constructor yapısı daima class ile aynı isme sahip olmalıdır
             * Constructor yapısında int void gibi bir dönüş tipi kullanılmaz
             * Garbage collector yapısı tarafından yönetilir 
             * Garbage collector yapısı sistem çalıştığı anda tüm bilgileri ram belleğine atarır
             * Constructor yapısı da bu bilgiler arasında yer alır
             * C C++ gibi dillerde destructor yapısı kullanılır bu yapıda yıkıcı method olarak geçer
             * Garbage collector en kolay tanımlanan en eski az kullanılan yapıları ramden siler
            */
            //OverLoad Constructor
            //Kisi kisi2 = new Kisi();//boş constructor
            //Kisi kisi = new Kisi("Erkan", "Türk", 31);//parametreli constructor
            //kisi.Yazdir();

            //Ogrenci ogrenci = new Ogrenci("ErkanTürk", 1);

            //Ogrenci ogrenci1;


            //ogrenci1= new Ogrenci("Erkan",1);
            //ogrenci1.Bilgi();
        }
    }
}
