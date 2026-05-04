using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YBSHafta_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Döngüler:
            // 1) While Döngüsü

            // for döngüsüne göre biraz daha karmaşıktır
            // farklı bir syntax yapısı vardır:

            // önce şartı belirtiriz. Döngünün ne zamana kadar çalışacağını
            // belirtiriz. Bunun için değişkeni önceden tanımlamamız gerekir

            int kriter = 0;

            while (kriter<10)
            {
                Console.WriteLine(kriter);
                // işlemi yaptıktan sonra artış ya da azalış
                // işlemini yapıyoruz. Aksi halde, duruma göre 
                // döngü ya hiç çalışmaz ya da hiç durmaz
                kriter = kriter + 1;
                //NOT: birer birer artırmanın 2 farklı yolu daha vardır
                // kriter ++;
                // kriter += 1;

            }
            Console.WriteLine("----------------------------------");

            // Sonsuz döngü (infinity loop) örneği:
            // Şart, ilk olarak doğru tanımlanmıştır ama artış ya da azalış
            // kriteri yerine getirilmemiştir.

            //int kriter_2 = 0;

            //while (kriter_2 < 10)
            //{
            //    Console.WriteLine("MAKÜ ZTYO YBS");
            //    // işlemi yaptıktan sonra artış ya da azalış
            //    // işlemini yapıyoruz. Aksi halde, duruma göre 
            //    // döngü ya hiç çalışmaz ya da hiç durmaz
            //    // kriter = kriter + 1;
            //    // NOT: birer birer artırmanın 2 farklı yolu daha vardır
            //    // kriter ++;
            //    // kriter += 1;

            //}

            Console.WriteLine("----------------------------------");

            // Hiç çalışmayan döngü örneği
            // NOT: ilk örnekte, çalışan while döngüsünü yapmıştık
            // önce kriteri tanımladık, sonra şarta bağladık
            // bu tanımlama ve şart arasında mantıksal olarak True cevabı
            // döndüğü için döngü içerisine girdi ve işlemleri yaptı
            // şimdi tanımlama ve şart arasında mantıksal açıdan False
            // cevabı üretecek bir ilişki kuracağız. Bu sayede, döngü hiç
            // çalışmayacak

            Console.WriteLine("Hiç Çalışmayan Döngü Örneği");
            int kriter_3 = 0;

            while (kriter_3 > 10)
            {
                Console.WriteLine(kriter_3);
                kriter_3 = kriter_3 + 1;
            }
            Console.WriteLine("----------------------------------");

            // for döngüsü, while döngüsüne tanımlanması aynı
            // satırda olduğu için daha nettir.

            // 1'den 10'a kadar olan (10'da dahil) sayıları ekrana yazdıran
            // for döngüsü kodu
            
            for (int i=1;i<11;i++)
            {
                Console.WriteLine($"Sayı  = {i}");
            }

            Console.WriteLine("----------------------------------");

            // Çarpım tablosundaki 3'lerin çarpım işleminin for döngüsü
            // ve sabit bir sayı ile gösterilmesi

            int carpan_1 = 3;

            for (int i=0;i<=10;i++)
            {
                int sonuc = carpan_1 * i;
                Console.WriteLine($"3x{i} = {sonuc}");
            }

            Console.WriteLine("----------------------------------");

            // İç içe döngüler (Nested Loops):
            // İç içe döngülerde önce içerdeki döngünün şartı tamamlanır,
            // sonra dışarıdaki döngüye geçilir

            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <=3 ; j++)
                {
                    Console.WriteLine($"j={j}   i={i}");
                }
                Console.WriteLine("*********************************");
            }

            Console.WriteLine("----------------------------------");
            
            // 10x10 çarpım tablosunu iç içe döngüyle yapınız
            // tüm çarpma işlemini ve sonucunu da ekrana yazdırınız

            for(int i = 0; i <= 10; i++)
            {
                for(int j = 0;j <= 10 ; j++)
                {
                    Console.WriteLine($"{i}x{j} = {i*j}");
                }
                Console.WriteLine("**************************");
            }
            Console.WriteLine("----------------------------------");

            // Yukarıdaki örnekte, dış döngüde 0'dan 10'a kadar çift sayılar
            // ile iç döngüde 1'den 9'a kadar olan tek sayıların çarpımını
            // yapınız (bitiş değerleri dahildir)

            for (int i = 0; i <= 10; i+=2)
            {
                for (int j = 1; j <= 10; j+=2)
                {
                    Console.WriteLine($"{j}x{i} = {i * j}");
                }
                Console.WriteLine("**************************");
            }

            Console.WriteLine("----------------------------------");


            // Kullanıcıdan 2 cümle girişi alınız:

            // Birinci cümlenin tek indekslerini
            // ikinci cümlenin çift indekslerini birleştirerek
            // yeni bir cümle oluşturunuz...
            // NOT string'lerde indeksleme:
            // string isim = "Furkan";
            // isim[0] yazınca F harfini getirir.
            // her bir karakter, bir indeks ile temsil edilir
            // ilk karakterin indeks numarası 0'dır ve birer birer artar

            Console.WriteLine("1. İfadeyi giriniz: ");
            string ifade_1 = Console.ReadLine();

            Console.WriteLine("2. İfadeyi giriniz: ");
            string ifade_2 = Console.ReadLine();

            //1. ifadenin karakter uzunluğu
            int kelime_boyut_1 = ifade_1.Length;

            //2. ifadenin karakter uzunluğu
            int kelime_boyut_2 = ifade_2.Length;

            string ifade_tek_indeks = "";
            string ifade_cift_indeks = "";

            for (int i = 1; i < kelime_boyut_1; i+=2)
            {
                ifade_tek_indeks = ifade_tek_indeks + ifade_1[i];
            }

            for (int i = 0; i < kelime_boyut_2; i+=2)
            {
                ifade_cift_indeks = ifade_cift_indeks + ifade_2[i];
            }

            string kelime_final = ifade_tek_indeks + ifade_cift_indeks;

            Console.WriteLine($"İfadenin Son Hâli = {kelime_final}");




            Console.ReadLine();
        }
    }
}
