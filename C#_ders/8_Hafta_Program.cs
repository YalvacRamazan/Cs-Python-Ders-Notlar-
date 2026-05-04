using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_8_Fonksiyonlar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fonksiyonlar-2: Geriye değer döndüren fonksiyonlar
            // geriye değer döndürmeyen fonksiyonları tanımlarken
            // anahtar kelime olarak void kullanıyorduk
            // Geriye değer döndüren fonksiyonları tanımlarken
            // anahtar kelime olarak mutlaka bir veri yapısı ve veri tipi
            // adı kullanıl, void kullanmayız!!!!
            // ve fonksiyon içerisinde return anahtar kelimesini
            // mutlaka kullanırız!!!

            // dışarıdan int tipinde 2 sayı alıp bu sayıların çarpımını
            // geriye değer döndürmeyen ve geriye değer döndüren fonksiyonlarla
            // yapalım

            carpim_1(5, 12);
            Console.WriteLine("-------------------------------------------");
            // geriye değer döndürmeyen fonksiyonu çalıştırırken sadece
            // adını ve eğer varsa parametrelerini yazıp bitiriyorduk
            // yukarıda olduğu gibi.
            // Ancak, geriye değer döndüren bir fonksiyonu çalıştırıp
            // sonucunu görmek istiyorsanız, ilk olarak o fonksiyondan dönen
            // değeri, uygun tipe almak zorundasınız. carpim_2 fonksiyonu
            // tanımlanırken public static int olarak tanımlandığı için
            // bu fonksiyonun sonucunu yani geriye döndürdüğü değeri aırken de
            // int tipinde oluşturduğumuz bir değişken üzerinden almak
            // zorundayız.
            // Bu durum bize sonucu yine göstermez. Bunun için bir de bu
            // sonucu Console.WriteLine() ile göstermek durumundayız

            // sonucu (yani dönen değeri aşağıda int tipinde deger_sonuc isimli
            // değişken içerisine aktardık ama henüz ekrana yazdırmadık)
            int deger_sonuc = carpim_2(5, 12);
            
            // Şimdi sonucu ekrana yazdırıyoruz

            Console.WriteLine($"5*12 = {deger_sonuc}");
            Console.WriteLine("-------------------------------------------");

            string sonuc_str = carpim_3(5, 12);
            Console.WriteLine(sonuc_str);
            Console.WriteLine("-------------------------------------------");

            // ilk olarak geriye değer döndüren fonksiyon ile döndürmeyen
            // fonksiyonun farkını görelim

            // geriye değer döndürmeyen fonksiyonda sonucu Console.WriteLine()
            // içerisinde yazdırmıştık
            Console.WriteLine((carpim_2(5, 12) * 2)/3);

            Console.WriteLine("-------------------------------------------");
            int sayi_1 = 15;
            int sayi_2 = 28;
            
            string sonuc_1 = tek_cift(sayi_1);
            string sonuc_2 = tek_cift(sayi_2);

            Console.WriteLine($"sonuc_1 = {sonuc_1} \t sonuc_2 = {sonuc_2}");

            Console.WriteLine("-------------------------------------------");

            int sonuc_kat_1 = kat_alma(sonuc_1, sayi_1);
            int sonuc_kat_2 = kat_alma(sonuc_2, sayi_2);
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine($"Sonuç_1 = {sonuc_kat_1}");
            Console.WriteLine($"Sonuç_1 = {sonuc_kat_2}");
            Console.WriteLine("-------------------------------------------");

            double not_1 = 58;
            double not_2 = 63;

            double sonuc_new_1 = not_hesaplama_1(not_1, not_2);

            Console.WriteLine($"vize = {not_1} \t final = {not_2} \t ortalama = {sonuc_new_1}");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"vize = {not_1} \t final = {not_2} \t ortalama = {sonuc_new_1} sonuç = {gecti_kaldi(sonuc_new_1)}");
            Console.WriteLine("-------------------------------------------");

            List<decimal> notlar_1 = new List<decimal>
            {58,78,74,43,15,36,52};

            List<decimal> notlar_2 = new List<decimal>
            {52,43,20,16,89,92,73};

            // Burada, fonksiyonun sonucunu uygun veri yapısına aktarıyoruz
            List<string> sonuc_notlar = not_hesaplama_2(notlar_1, notlar_2);

            // Şimdi de sonuçları ekrana yazdırıyoruz

            int sayac = 0;

            foreach(string item in sonuc_notlar)
            {
                Console.WriteLine($"{sayac+1}. öğrenci {item}");
                sayac++;
            }

            Console.WriteLine("------------------------------------------");

            // aynı işlemi for döngüsüyle yapalım

            for (int i = 0; i < sonuc_notlar.Count; i++)
            {
                //string eleman = sonuc_notlar[i];
                Console.WriteLine($"{i+1}. Öğrenci {sonuc_notlar[i]}");
            }
            Console.WriteLine("------------------------------------------");

            List<int> personel_maaslar = new List<int> 
            {23500,56800,35000,25000,18900,75000,17650,100000,63250};

            List<double> personel_zamli_maas = zamli_maas(personel_maaslar);

            for (int i = 0; i < personel_zamli_maas.Count; i++)
            {
                double eski_maas = personel_maaslar[i];
                double new_maas = personel_zamli_maas[i];

                Console.WriteLine($"{i+1}. Personelin Eski Maaşı = {eski_maas} TL \t Yeni Maaşı = {new_maas} TL");
            }


            Console.ReadLine();
        }

        // ilk olarak 2 sayıyı çarpan fonksiyonu geriye değer döndürmeyen
        // fonksiyon olarak yazıyoruz

        public static void carpim_1(int sayi_1, int sayi_2)
        {
            Console.WriteLine($"{sayi_1}*{sayi_2} = {sayi_1 * sayi_2}");

        }

        public static int carpim_2(int sayi_1, int sayi_2)
        {
            int sonuc = sayi_1 * sayi_2;
            return sonuc;
        }

        // yukarıdaki fonksiyon ile aynı işlemi yapan ama sonucu
        // string olarak  tıpkı Console.WriteLine($"{sayi_1}*{sayi_2} = {sayi_1 * sayi_2}");
        // şeklinde kullanıcıya döndüren fonksiyonu yazınız.

        public static string carpim_3(int sayi_1, int sayi_2)
        {
            return $"{sayi_1}*{sayi_2} = {sayi_1 * sayi_2}";
        }

        // Bir fonksiyonun sonucunu diğer fonksiyona parametre olarak
        // verme

        // aşağıdaki fonksiyonda bir sayının tek mi çift mi olduğu
        // belirlenecek, eğer çiftse 2 katı, tekse 3 katı alınacak

        public static string tek_cift(int sayi)
        {
            string yanit = "";
            if (sayi % 2 != 0)
            {
                yanit = "TEK";
            }
            else
            {
                yanit = "ÇİFT";
            }
            return yanit;
        }
        // bu kat alınma meselesini de 2. bir fonksiyon yapacak

        public static int kat_alma(string sonuc, int sayi)
        {
            if (sonuc == tek_cift(sayi))
            {
                sayi = sayi * 3;
            }
            else
            {
                sayi = sayi * 2;
            }
            return sayi;
        }

        // Dışarıdan vize ve final notlarını alıp
        // vizenin %40'ıyla finalin %50'sini hesaplayıp toplayıp bu sonucu
        // ondalıklı olarak geriye döndüren fonksiyonu yazınız

        public static double not_hesaplama_1(double vize, double final)
        {
            double sonuc = (vize * 0.4) + (final * 0.6);
            return sonuc;
        }

        // yukarıdaki fonksiyonun sonucunu aşağıdaki
        // fonksiyona parametre olarak verip öğrencinin GEÇTİ ya da KALDI
        // bilgisini geriye döndüreceğiz

        public static string gecti_kaldi(double sonuc)
        {
            string yanit = "";
            if (sonuc < 50)
            {
                yanit = "KALDINIZ";
            }
            else
            {
                yanit = "GEÇTİNİZ";
            }
            return yanit;
        }

        // Şu ana kadar yazdığımız fonksiyonlar primitive (ilkel)
        // veri tipleriyle tek değişkenle yapılan işlemleri kapsıyordu.
        // Birden fazla veriyle çalışıp, fonksiyon içerisinde bunlara
        // müdahale etmek için parametre olarak ya da return edilen değer
        // olarak veri yapılarının kullanıldığı fonksiyonlar yazacağız

        // Kullanıcıdan parametre olarak vize ve final notlarını iki
        // farklı liste olarak alan bu listedeki notları hesaplayıp
        // 50 ve üzeri olan notlar için GEÇTİ, diğerleri için KALDI yazan
        // bunları da bir listeye ekleyip bu listeyi geriye döndüren fonksiyon

        public static List<string> not_hesaplama_2(List<decimal> vize, List<decimal> final)
        {
            List<string> sonuclar = new List<string>();

            // döngüyle birlikte, parametre olarak verilen vize ve final
            // notlarına erişim sağlıyoruz. Her iki liste içerisinde aynı
            // sayıda not olduğu için for döngüsüyle birden fazla listenin
            // içerisine gireceğiz...

            for (int i = 0; i < vize.Count; i++)
            {
                decimal not_1 = vize[i];
                decimal not_2 = final[i];

                // 4 ve 6'nın yanındaki m harfi, o işlemin
                // decimal olduğunu belirtir.

                decimal ortalama = (not_1 * 0.4m) + (not_2 * 0.6m);

                if (ortalama < 50)
                {
                    sonuclar.Add("KALDINIZ");
                }
                else
                {
                    sonuclar.Add("GEÇTİNİZ");
                }
            }
            return sonuclar;
        }

        // Dışarıdan maaş bilgilerinin olduğu bir listeyi parametre olarak
        // alıp, 25000 TL'nin altındaki maaşlara %35, 25000 TL ve üzeri
        // maaşlara yüzde 18 zam yapan ve zamlı maaşları yeni bir listeye
        // ekleyip bu listeyi geriye döndüren fonksiyonu yazınız

        public static List<double> zamli_maas(List<int> maaslar)
        {
            List<double> maas_zamli_hali = new List<double>();

            // bize parametre olarak verilen orijinal maaşların içerisine
            // girip her bir maaşa tek tek erişiyoruz

            for (int i = 0;i < maaslar.Count; i++)
            {
                double orijinal_maas = maaslar[i];

                if(orijinal_maas < 25000)
                {
                    orijinal_maas = orijinal_maas * 1.35;
                    maas_zamli_hali.Add(orijinal_maas);
                }
                else
                {
                    orijinal_maas = orijinal_maas * 1.18;
                    maas_zamli_hali.Add(orijinal_maas);
                }
            }
            
            return maas_zamli_hali;
        }



    }
}
