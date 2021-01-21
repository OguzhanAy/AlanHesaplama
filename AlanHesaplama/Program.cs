using System;

namespace AlanHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hesapla sınıfını kullanabilmek için çağırma işlemi
            Hesapla hesapla = new Hesapla();
            Console.WriteLine("Üçgen(1)-Kare(2)-Daire(3)-Dikdörtgen(4)");
            Console.WriteLine("Alan hesaplaması için yukarıdaki şekillerden birinin numarasını yazınız");
            int sekil = int.Parse(Console.ReadLine());
            switch (sekil)
            {
                case 1:
                    //Verilen parametrelere göre üçgenin alanını hesaplama
                    Console.WriteLine("Üçgenin alanı için taban ve yüksekliği giriniz");
                    Console.Write("Tabanı: ");
                    int taban = int.Parse(Console.ReadLine());
                    Console.Write("Yükselikliği: ");
                    int yükseklik = int.Parse(Console.ReadLine());
                    Console.WriteLine("Üçgenin alanı: " + hesapla.UcgenAlani(taban, yükseklik));
                    break;
                case 2:
                    //Verilen parametrelere göre karenin alanını hesaplama
                    Console.WriteLine("Karenin alanı için kenarı giriniz");
                    Console.Write("Kenar: ");
                    int kenarX = int.Parse(Console.ReadLine());                    
                    Console.WriteLine("Karenin alanı: " + hesapla.KareAlani(kenarX));
                    break;
                case 3:
                    //Verilen parametrelere göre dairenin alanını hesaplama
                    Console.WriteLine("Dairenin alanı için yarıçapı giriniz");
                    Console.Write("Yarıçap: ");
                    double yaricap = double.Parse(Console.ReadLine());                    
                    Console.WriteLine("Dairenin alanı: " + hesapla.DaireAlani(yaricap));
                    break;
                case 4:
                    //Verilen parametrelere göre dikdörtgenin alanını hesaplama
                    Console.WriteLine("Dikdörtgenin alanı için iki kenarı giriniz");
                    Console.Write("KenarA: ");
                    int kenarA = int.Parse(Console.ReadLine());
                    Console.Write("KenarB: ");
                    int kenarB = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dikdörgenin alanı: " + hesapla.DikdortgenAlani(kenarA, kenarB));
                    break;
                default:
                    Console.WriteLine("Lütfen yukarıdaki işlem numaralarından birini giriniz");
                    break;
            }
            

        }
    }
}
