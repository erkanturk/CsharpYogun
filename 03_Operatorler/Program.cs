namespace _03_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operatörler
            #region Aritmatik operatörler
            /* Aritmatik oparatörler.
                +,-,*,/,%, %mod alma operatörü bir sayının bölümünden kalan değeri bize verir örneğin 10 sayısının 3 e modu  1 dir 3 e tam bölünmez ve kalanı bize iletir.
            
            */
            //int sayi = 10;
            //int sayi2 = 20;

            //Console.WriteLine(sayi + sayi2);//Toplama işlemi
            //Console.WriteLine(sayi * sayi2);//Çarpma işlemi
            //Console.WriteLine(sayi2 / sayi);//bölme işlemi
            //Console.WriteLine(sayi - sayi2);//Çıkarma işlemi

            //int sayi3 = 10;
            //double sayi4 = 3;
            //double sonuc = sayi3 % sayi4;
            //Console.WriteLine("Mod alma sonucu:" + sonuc);
            //string number = "10";
            //int sayi6 = 10;
            //Console.WriteLine(number + sayi6);//metinsel bir değerde + birleştirme işlemi yapar.

            //int sayi = 10;
            ////Console.WriteLine(sayi);
            ////sayi++;//Sayı değerini 1 artırma işlemi
            ////Console.WriteLine(sayi);
            ////sayi--;//Sayı değerini 1 azaltma işlemi
            ////Console.WriteLine(sayi);

            //int sayi2 = 20;
            //int sayi3 = 30;

            //sayi += sayi2;//+= toplama işlemi için kullanılır bir değişken burada toplamları tutar ve içerisinde barındırır.
            //sayi += sayi3;

            //sayi -= sayi2;//-= ise azaltma işlemi yapar.
            //sayi -= sayi3;
            //Console.WriteLine(sayi);

            #endregion

            #region Atama Operatörleri
            /*
                = sağdaki değeri soldaki değişkene atama yapar.
                += artırma
                -= azaltma
                /= bölme
                *= çarpma
                .Erişim oparatörü
            
            */
            #endregion

            #region Karşılaştırma Operatörleri
            /* karşılaştırma operatörleri sadece true veya false cevap dönderir.
            > Büyüktür
            < Küçüktür
            >= Büyük Eşittir
            <= Küçük eşittir
            == Eşit mi ?
            != eşit değil mi ?
            ! değil true ise sonuc false dönderir false ise true dönderir.
            
            
            */
            //int sayi = 10;
            //int sayi2 = 5;
            //bool sonuc = sayi > sayi2;//T
            //bool sonuc2 = sayi < sayi2;//F
            //bool sonuc3 = sayi >= sayi2;//T
            //bool sonuc4 = sayi <= sayi2;//F
            //bool sonuc5 = sayi == sayi2;//F
            //bool sonuc6 = sayi != sayi2;//T

            //Console.WriteLine(sonuc);
            //Console.WriteLine(sonuc2);
            //Console.WriteLine(sonuc3);
            //Console.WriteLine(sonuc4);
            //Console.WriteLine(sonuc5);
            //Console.WriteLine(sonuc6);
            //bool a = true;
            //Console.WriteLine(!a);
            #endregion
            #region Mantıksal Operatörler
            /* And(Ve)&& 
               or(veya)||
               Birden fazla koşulun kontrol edilmesi ve hepsinin true olması durumunda true dönecek yapıdır
            True=1; False=0; 
            Başlangıç  bitiş sonuç && 
             1          0      0
             0          1      0
             1          1      1
             0          0      0

            Birden fazla koşulun kontrol edilmesi ve en az bir koşulun olumlu olması durumunda true döner
            || veya
            Baş Bit Son 
             1   0   1
             0   1   1
             0   0   0
             1   1   1
            */
            #endregion

            //int sayi = 10;
            //int sayi2 = 5;

            //bool sonuc = sayi > sayi2 && sayi >= sayi2;//T
            //bool sonuc2 = sayi == sayi2 && sayi >= sayi2;//F
            //bool sonuc3 = sayi >= sayi2 && sayi <= sayi2;//F
            //bool sonuc4 = sayi < sayi2 && sayi >= sayi2;//F

            //Console.WriteLine(sonuc);
            //Console.WriteLine(sonuc2);
            //Console.WriteLine(sonuc3);
            //Console.WriteLine(sonuc4);

            //bool sonuc = sayi > sayi2 || sayi >= sayi2;//T
            //bool sonuc2 = sayi == sayi2 || sayi <= sayi2;//F
            //bool sonuc3 = sayi >= sayi2 || sayi <= sayi2;//T
            //bool sonuc4 = sayi < sayi2 || sayi >= sayi2;//T

            //Console.WriteLine(sonuc);
            //Console.WriteLine(sonuc2);
            //Console.WriteLine(sonuc3);
            //Console.WriteLine(sonuc4);

        }
    }
}
