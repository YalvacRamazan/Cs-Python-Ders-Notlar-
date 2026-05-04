using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace YBS_OOP_Hafta_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Hafta-1:Veri Tipleri:
            // C#'ta nümerik veriler (rakam,sayılar) için
            // int-long (tam sayı), double-float(ondalıklı sayı)
            // mantıksal veriler (boolean) ve karakter temelli
            // veriler (string-char) tipleri vardır
            // NOT: Karakter temelli veriler için tek bir değer
            // tutmak istiyorsanız char veri tipi, birden fazla
            // değer tutmak istiyorsanız string veri tipini kullanmalısınız

            // Çünkü, string aslında char topluluğudur.
            // NOT: char veri tipini tanımlarken tek tırnak kullanılır
            // string veri tipini tanımlarken çift tırnak kullanılır

            // C#, tip bağımlı bir dildir. Yani, herhangi bir değişken
            // tanımlamadan önce mutlaka ama mutlaka o değişkenin
            // hangi tipte olduğunu belirtmeniz lazım

            // Veri tipleri 2 üssü şeklinde hesaplanır.
            // 8 bit = 1 byte olduğu için 2 üssü 8'e göre değerlendirilir
            // hafızada da buna göre yer kaplarlar
            // u harfi bir veri tipinin başında yer alıyorsa eğer
            // (ushort, uint gibi) unsigned kelimesinden gelir.
            // Bu da, aynı değerin negatif halini de tutabildiğini
            // gösterir.

            byte sayi_6 = 127;
            short sayi_5 = 32000;
            int sayi_1 = 15;
            long sayi_2 = 3500000000;

            double sayi_3 = 15.86;
            float sayi_4 = 15.89365f;

            char harf_1 = 'A';
            string kelime_1 = "Burdur Mehmet Akif Ersoy Üniversitesi";

            Console.WriteLine(kelime_1[10]);

            bool mantiksal_1 = false;
            bool mantiksal_2 = true;

            // Tip dönüşümlerine örnek

            // bool veri tipini string olarak değiştirdik
            string mantiksal_3 = "false";

            Console.WriteLine("-----------------------------");

            bool mantiksal_4 = Convert.ToBoolean("false");
            bool mantiksal_5 = Convert.ToBoolean(1);

            // C#'ta string formatlama yapmak için çift tırnak
            // işaretinin başına dolar işareti ($) eklenir
            // ve özellikle belirtilmek istenen değişken
            // süslü parantez içerisine yazılır.

            Console.WriteLine($"mantiksal_4 = {mantiksal_4}");
            Console.WriteLine($"mantiksal_5 = {mantiksal_5}");

            // string, double ve float tiplerinde nümerik 3 adet
            // değer tanımlayıp yukarıdaki tiple tanımlanmış 
            // değişkenlere aktarın
            // sonra bunların hepsini int tipine dönüştürüp
            // ilk hallerini (orijinal hallerini) ve son hallerini
            // ekrana yazdırın (string formatlama kullanarak yazdırın)

            string deger_1 = "86";
            double deger_2 = 38.956;
            float deger_3 = 12.5485f;

            int deger_4 = Convert.ToInt32(deger_1);
            int deger_5 = Convert.ToInt32(deger_2);
            int deger_6 = Convert.ToInt32(deger_3);

            Console.WriteLine("**********************************");
            Console.WriteLine($"deger_1 (ilk) = {deger_1}");
            Console.WriteLine($"deger_2 (ilk) = {deger_2}");
            Console.WriteLine($"deger_3 (ilk) = {deger_3}");

            Console.WriteLine($"deger_4 = {deger_4}");
            Console.WriteLine($"deger_5 = {deger_5}");
            Console.WriteLine($"deger_6 = {deger_6}");

            Console.WriteLine("**********************************");

            // Matematiksel İşlemler


            double sonuc = Convert.ToDouble(16.0 / 3.0);
            Console.WriteLine($"16+4 = {16 + 4}");
            Console.WriteLine($"16-4 = {16 - 4}");
            Console.WriteLine($"16*4 = {16 * 4}");
            Console.WriteLine($"16/4 = {16 / 4}");
            Console.WriteLine($"16/3 (double) = {sonuc}");
            Console.WriteLine($"16%3 = {16 % 3}");
            Console.WriteLine("**********************************");

            // Üs alma işlemi
            double sonuc_2 = Math.Pow(2, 5);

            // 2.2'nin 5. kuvveti
            double sonuc_3 = Math.Pow(2.2, 5);

            Console.WriteLine($"2^5 (2 üssü 5) = {sonuc_2}");
            Console.WriteLine("**********************************");

            // ekrandan (kullanıcıdan) değer alma
            // Kullanıcıdan veri girişi almak için Console.ReadLine()
            // fonksiyonu kullanılır. Uyarı, Console.ReadLine() ile
            // alınan her bir değer varsayılan olarak string tipinde olur

            // Kullanıcıdan veri girişi alma:
            Console.WriteLine("Lütfen bir tam sayı giriniz:");
            string alinan_deger_1 = Console.ReadLine();

            // Değeri aldıktan sonra tip dönüşümü yapmak:
            int alinan_deger_2 = Convert.ToInt32(alinan_deger_1);

            Console.WriteLine($"{alinan_deger_2} sayısının 2 katı = {alinan_deger_2*2}");

            Console.WriteLine("**********************************");
            // Kullanıcıdan alınan sayının 4 katının 5 eksiğinin 7 fazlasının
            // 4'e bölümünden kalanını bulan kodu yazınız

            // NOT: kullanıcıdan girişi alırken tip dönüşümü yapmak:
            Console.WriteLine("Lütfen işlem için bir sayı giriniz:");
            int kullanici_sayi_1 = Convert.ToInt32(Console.ReadLine());

            int kullanici_sonuc = (((kullanici_sayi_1 * 4) - 5) + 7) % 4;
            Console.WriteLine($"{kullanici_sayi_1} sayısının işlem sonucu = {kullanici_sonuc}");
            Console.ReadLine();
        }
    }
}
