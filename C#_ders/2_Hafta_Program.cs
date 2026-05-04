using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YBSHafta_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte sayi_1 = 125;
            short sayi_2 = 256;
            int sayi_3 = 35000;
            long sayi_4_uzun = 650000000000000;
            decimal sayi_7 = 516315652165465;

            double sayi_5 = 35.6596235;
            float sayi_6 = 3654.4512656f;

            char harf_1 = 'A';
            char harf_2 = 'b';
            //char harf_3 = "c";

            string ifade_1 = "Furkan";
            string ifade_2 = "f";

            // Matematiksel işlemler
            // string formatlama
            // Python'da f simgesinin işlevini C#'ta $ simgesi görür
            // geriye kalan formatlama işlemi aynıdır.

            short new_sayi_1 = 50;
            short new_sayi_2 = 10;

            Console.WriteLine($"{new_sayi_1}+{new_sayi_2} = {new_sayi_1+new_sayi_2}");
            Console.WriteLine($"{new_sayi_1}-{new_sayi_2} = {new_sayi_1 - new_sayi_2}");
            Console.WriteLine($"{new_sayi_1}*{new_sayi_2} = {new_sayi_1 * new_sayi_2}");
            Console.WriteLine($"{new_sayi_1}/{new_sayi_2} = {new_sayi_1 / new_sayi_2}");
            
            // Üs alma işlemi
            Console.WriteLine($"{new_sayi_1}^{new_sayi_2} = {Math.Pow(new_sayi_1,new_sayi_2)}");

            // Mod alma işlemi
            Console.WriteLine($"{new_sayi_1}%{new_sayi_2} = {new_sayi_1%new_sayi_2}");


            Console.WriteLine("-----------------------------------");

            // Kullanıcıdan değer girişi alma

            Console.WriteLine("Lütfen bir sayı giriniz:");
            string kullanici_deger_1 = Console.ReadLine();

            int kullanici_sayi_1 = Convert.ToInt32(kullanici_deger_1);

            // NOT: Kullanıcıdan değer girişi alırken varsayılan olarak
            // tüm giriş değerleri string tipindedir.

            if (kullanici_sayi_1 % 2 == 0)
            {
                Console.WriteLine($"Girmiş olduğunuz {kullanici_sayi_1} sayı çifttir");
            }
            else
            {
                Console.WriteLine($"Girmiş olduğunuz {kullanici_sayi_1} sayı tektir");
            }

            string new_ifade_1 = "Burdur Mehmet Akif Ersoy Üniversitesi Bucak ZTYO";

            int deger = new_ifade_1.Length;

            int son_indeks = deger - 1;

            Console.WriteLine($"Toplam Eleman Sayısı = {deger}");
            if (deger % 2 != 0)
            {
                Console.WriteLine(new_ifade_1[0]);
            }
            else
            {
                Console.WriteLine(new_ifade_1[son_indeks]);
            }

            // new_ifade_1 değişkeninin aynısını siz de tanımlayın
            // değişkenin toplam eleman sayısını hesaplayın
            // eğer bu eleman sayısı tek ise
            // bu cümledeki ilk harfi yazdırsın ekrana
            // yok çift ise
            // bu cümledeki son harfi (karakteri) yazdırsın
            // Bunu yapan kodu yazınız

            Console.WriteLine("----------------------------------");

            // yukarıdaki ifadenin toplam eleman sayısını hesapladıktan sonra
            // ortanca indeksindeki elemanı bulup ekrana yazdırın


            // Daha önce toplam eleman sayısını deger değişkeninde tutmuştuk
            // Bunun ortancasını bulmak için şu formülü yazacağız
            // (değer+0)%2==0 yani çift ise 1 eksiği ya da 1 fazlasını alırız
            // değilse direkt o indeksin kendisini alırız ve ilgili
            // indeksteki değeri yazdırırız
            Console.WriteLine($"Tam ifade = {new_ifade_1}");
            if ((deger + 0) % 2 == 0)
            {
                int gecici = ((deger + 0) / 2) - 1; // solundaki indeks
                Console.WriteLine($"Ortanca değer = {new_ifade_1[gecici]}");
                //int gecici = ((deger + 0) / 2) + 1; // sağındaki indeks
            }
            else
            {
                int gecici = (deger + 0) / 2;
                Console.WriteLine($"Ortanca değer = {new_ifade_1[gecici]}");
            }

               Console.ReadLine();

        }
    }
}
