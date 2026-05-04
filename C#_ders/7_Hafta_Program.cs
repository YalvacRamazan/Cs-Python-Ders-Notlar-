using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YBS_Hafta_7_Fonksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hafta-7: Fonksiyonlar
            // Fonksiyonlar, bir kod yapısının/bütününün/birlikteliğinin
            // bir arada tanımlandığı ve çağrıldığı yapılardır

            // Kullanımı, aslında tıpkı matematikteki gibidir.
            // Önce bir sınır tanımlarsınız, sonra o sınır içerisinde
            // hareket eden/çalışan işlevler tanımlarsınız

            // 2'den başlayıp 30'a kadar ikişer ikişer artan her çift sayının
            // 4 katının 3 fazlasını hesaplayan/yazdıran kod

            int deger = 2;
            int formul = (deger * 4) + 3;
            Console.WriteLine($"Sonuç = {formul}");

            // Sadece kod kullanarak yukarıdaki işlemi for döngüsüyle
            // yapabiliriz.

            Console.WriteLine("--------------------------------------");

            for (int i = 2; i <=30; i+=2) {
                Console.WriteLine($"({i}*4)+3 = {(i*4)+3}");
            }
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("islem_1 fonksiyonunun çalıştırılması");

            // fonksiyonu aşağıda main metodunun kapsamı (scope) dışında
            // doğru yerde tanımladık. Bu kısım, bir fonksiyonun tanımlanması
            // kısmıydı. Şimdi de bir fonsiyonun çalıştırılması yani
            // içerisine yazılan kodların işlevinin yerine getirilmesi için
            // aşağıda çağırıyoruz

            // bir fonksiyonu çalıştırmak/çağırmak için adını yazıp
            // yanına parantez aç kapa yapmanız yeterlidir.

            islem_1();
            Console.WriteLine("--------------------------------------");
            islem_2();
            Console.WriteLine("--------------------------------------");
            islem_3(5,6);
            Console.WriteLine("--------------------------------------");
            faktoriyel(5);
            Console.WriteLine("--------------------------------------");
            not_hesaplama_1(10, 25);
            Console.WriteLine("--------------------------------------");

            // Bu defa not ortalamasını tek bir öğrencinin notlarıyla değil
            // 5 öğrencinin vize ve final notlarını ayrı ayrı tutan
            // 2 tane List veri yapısından okuyup o şekilde değerlendiren
            // fonksiyon

            List<double> list_vize = new List<double>()
            {65,73,88,26,15,45};

            List<double> list_final = new List<double>()
            {28,92,55,39,78,58};

            List<string> ogrenciler = new List<string>() 
            {"Ahmet","Mehmet","Ayşe","Eda","Yusuf","Hakan"};

            double gecici = 15.56;
            //Console.WriteLine(ogrenciler.Count);
            not_hesaplama_2(ogrenciler,list_vize, list_final);

            // 1'den 10'a kadar (10'da dahil) sayıların karesini
            // yazdıran fonksiyon
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("LİSTE KONTROL");
            liste_kontrol(list_vize);
            Console.ReadLine();
        }

        // public static anahtar kelimesiyle fonksiyon tanımlamak
        
        // islem_1 adında geriye değer döndürmeyen (void yazdığı için)
        // ve 2-30 arasındaki çift sayıların 4 katının 3 fazlasını hesaplayan
        // fonksiyon
        // public olarak yazdığımız için bu fonksiyona bu proje içerisinden
        // her yerden erişebiliriz/çağırabiliriz
        // static yazdığımız için bu fonksiyon için bir sınıf yazmamıza
        // ve ona erişmek için o sınıftan bir örnek türetmemize gerek
        // olmadığı anlamına gelir

        // parametresiz ve geriye değer döndürmeyen fonksiyon örneği
        // parametresiz olması, fonksiyonun adını yazıp parantez açtıktan
        // sonra o parantez içerisine herhangi bir parametre yazmamamız,
        // geriye değer döndürmemesi de void anahtar kelimesini 
        // kullanmamızdan kaynaklanıyor.

        public static void islem_1()
        {
            for (int i = 2; i <= 30; i += 2)
            {
                Console.WriteLine($"({i}*4)+3 = {(i * 4) + 3}");
            }
        }

        public static void islem_2()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i} sayısının karesi = {i*i}");
            }
        }

        // Geriye değer döndürmeyen ama parametre alan fonksiyon örneği
        // geriye değer döndürmediği için yine void anahtar kelimesini
        // kullanırız ama parametre aldığı için bu defa fonksiyonun
        // adını yazdıktan sonra parantez içerisine kaç tane parametre
        // isteniyorsa o kadar parametreyi temsil eden geçici değişken
        // adı yazıp virgüllerle birbirinden ayırırız

        // Örneğin, girilen iki sayıdan büyük olanını yazdıran fonksiyon

        public static void islem_3(int sayi_1, int sayi_2) 
        {
            if (sayi_1 > sayi_2)
            {
                Console.WriteLine($"{sayi_1} sayısı {sayi_2} sayısından büyüktür");
            }
            else if (sayi_2 > sayi_1)
            {
                Console.WriteLine($"{sayi_2} sayısı {sayi_1} sayısından büyüktür");
            }
            else
            {
                Console.WriteLine($"{sayi_1} = {sayi_2}");
            }
        }

        // Dışarıdan parametre olarak girilen sayının faktöriyelini
        // hesaplayıp yazdıran fonksiyon
        public static void faktoriyel(int sayi)
        {
            int faktoriyel = 1;

            for(int i = 1; i <= sayi; i++)
            {
                faktoriyel = faktoriyel * i;
            }

            Console.WriteLine($"{sayi} sayısının faktöriyeli = {faktoriyel}");
        }

        // ilk parametre olarak vize, ikinci parametre olarak da final notunu
        // alan ve vize notunun %40'ı ile final notunun %60'ını toplayıp
        // bu puan 50 ve üzeri ise GEÇTİ, değilse KALDI yazan fonksiyon örneği

        public static void not_hesaplama_1(double vize, double final)
        {
            double toplam = (vize * 0.4) + (final * 0.6);
            if (toplam >= 50)
            {
                Console.WriteLine($"GEÇTİNİZ \t Notunuz = {toplam}");
            }
            else
            {
                Console.WriteLine($"KALDINIZ \t Notunuz = {toplam}");
            }
        }

        public static void not_hesaplama_2(List<string> list_isim,List<double> list_1, List<double> list_2)
        {
            double ort_vize = 0.4;
            double ort_final = 0.6;
            
            // ilk iş olarak vize ve final ortalamalarını hesaplayıp
            // içerisinde saklayacağımız yeni bir boş liste oluşturmak

            List<double> list_ortalamalar = new List<double>();

            // Şimdi for döngüsüyle bize dışarıdan verilecek olan
            // vize ve final notlarını saklayan listelerin içerisine erişim
            // sağlıyoruz

            for (int i = 0; i < list_1.Count; i++)
            {
                // vize notlarını tutan listedeki ilgili elemana erişiyoruz
                double my_vize = list_1[i];
                // final notlarını tutan listedeki ilgili elemana erişiyoruz
                double my_final = list_2[i];
                // vize ve final notunun ortalamasını hesaplıyoruz
                double ortalama = (my_vize * ort_vize) + (my_final * ort_final);
                // içi boş listeye bu ortalama notunu ekliyoruz
                list_ortalamalar.Add(ortalama);
            }

            
            for (int i = 0; i < list_ortalamalar.Count; i++)
            {
                double not_gecici = list_ortalamalar[i];
                string ogrenci = list_isim[i];

                if (not_gecici>=50)
                {
                    Console.WriteLine($"Öğrenci {ogrenci} {not_gecici} notuyla GEÇTİ");
                }
                else
                {
                    Console.WriteLine($"Öğrenci {ogrenci} {not_gecici} notuyla KALDI");
                }
            }
            

            

        }

        public static void liste_kontrol(List<double> notlar)
        {
            /*
            for (int i = 0; i < notlar.Count; i++)
            {
                Console.WriteLine($"indeks = {i} \t not = {notlar[i]}");

                if (notlar[i] >= 50)
                {
                    Console.WriteLine("GEÇTİNİZ");
                }
                else { Console.WriteLine("KALDINIZ"); }
            }
            */
            // for döngüsüyle erişim
            // double not = notlar[i]
            
            // foreach ile erişim
            // var item in notlar => item burada
            // double not = notlar[i] ile aynı işlevi görür

            foreach(var item in notlar)
            {
                if (item >= 50)
                {
                    Console.WriteLine($"notunuz = {item} \t GEÇTİNİZ");
                }
            }
        }
        


    }
}
