namespace _42_OOP_Inheritance_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sınıflar Sadece bir sınıftan miras alabilir birden fazla sınıftan miras alamaz

            Kahve kahve = new Kahve();
            kahve.SekerliMi=false;
            kahve.AlkolluMu=false;
            kahve.CekirdekTuru="Arabica";
            kahve.SogukMu=true;
            kahve.SutluMu=true;
            kahve.GazliMi=false;

            Cay cay = new Cay();
            cay.SekerliMi=false;
            cay.AlkolluMu=false;
            cay.KacakMi=true;
            cay.SogukMu=false;
            //cay.SutluMu=false;Kahve sınıfının özelliği olduğu için bu yapı Çayda kullanılamaz

            Kola kola = new Kola();
            kola.SekerliMi=true;
            kola.AlkolluMu=false;
            kola.GazliMi=true;
            kola.Marka="Le Cola";
            kola.SogukMu=true;



        }
    }
}
