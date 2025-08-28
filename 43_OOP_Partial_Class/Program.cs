namespace _43_OOP_Partial_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Partial class fiziksel olarak Personel ve Personel1 adında oluşturulan 2 farklı classın adını Personel olarak 
            //Verip Partial keywordünü kulanarak birleştirip tek bir class gibi davranmalarını sağlamak.
            //Her ikisinde de bulunan üyeler derleyici tarafından birleştirilecek.

            Personel personel = new Personel();
            personel.Id=2;
            personel.Yas=20;
            personel.Name="Halil";
            personel.BilgiVer();
            personel.BilgiVer(10);
            personel.Test();
            personel.Deneme();

            Personel personel1 = new Personel("Erkan Türk");
        }
    }
}
