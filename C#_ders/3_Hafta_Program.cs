using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YBSHafta_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if kontrolleri

            // aşağıdaki formül ile bir if yapısı açılır
            // if (yapmak_istediğiniz_kontrol)
            // {eğer cevap true ise yapmak istediğiniz işlemler}

            string isim = "burdur mehmet akif ersoy üniversitesi";
            Console.WriteLine(isim);

            // Remove metodunda ilk parametre, silinecek karakterin
            // index numarası. İkinci parametre ise, silinecek karakter
            // dahil olmak üzere toplam kaç karakter silineceği

            isim = isim.Remove(9,8);
            Console.WriteLine(isim);

            Console.WriteLine("----------------------------------");

            // Replace() metodunda 2 parametre kullanımı söz konusudur.
            // ilk parametre eski değer, ikinci paramtre 
            // yeni değere karşılık gelir.



            string isim_2 = "burdur mehmet akif ersoy üniversitesi";
            isim_2 = isim_2.Replace('u', 'ü');
            isim_2 = isim_2.Replace("bürdür", "Burdur");
            Console.WriteLine(isim_2);

            Console.WriteLine("----------------------------------");

            // tüm karakterleri büyük harf yapar

            isim_2.ToUpper();

            // kullanıcıdan önce isim, sonra soyisim bilgisini alın
            // ve iki string tipli değişkende tutun

            // Kullanıcının isminin ilk harfi büyük harf değilse
            // bunu büyük harfe dönüştürün

            // kullanıcının soyisminin tamamı büyük harf değilse
            // tamamını büyük harfe dönüştürün

            // bu işlemleri yaptıktan sonra ekrana
            // Merhaba, isim Soyisim yazdırın
            // Örneğin; Merhaba, Furkan ATLAN

            Console.WriteLine("Lütfen adınızı giriniz: ");
            string isimm = Console.ReadLine();

            Console.WriteLine("Lütfen soyadınızı giriniz: ");
            string soyisim = Console.ReadLine();

            // furkan==furkan
            // furkan!=Furkan
            
            // girilen isim bilgisini zoraki olarak hepsini
            // küçük harflerle yazılacak şekle dönüştürdük

            // Furkan
            isimm = isimm.ToLower(); // Furkan->furkan
            if ((isimm.ToLower() == isimm) | (soyisim.ToUpper()!=soyisim))
            {
                
                // tek karakter olan, ismin baş harfini
                // string'e dönüştürdük ve karakter isimli değişkene attık
                // şöyle düşünün şu an bu değişkende "f"
                string karakter = isimm[0].ToString();

                // küçük harf olan "f"yi "F"ye dönüştürüyoruz
                karakter = karakter.ToUpper();


                // hatırlarsanız Replace metodu ya ikisi de char olan
                // ya da ikisi de string olan parametre alıyordu
                // şuan bizim elimizde bir char var(orijinal ilk harf)
                // bir de string var (F yaptığımız ilk karakter)

                // string olan "F" harfini (işlem yaptığımız harfi)
                // char olan 'F' harfine dönüştürüyoruz.
                // C#'ta tip dönüşümleri 2 yoldan sıklıkla yapılır
                // Convert sınıfı ve ilgili tipin Parse metodu
                char karakter_2 = char.Parse(karakter);

                // son olarak isimm[0] aslında char döndüren ve
                // ilk harf olan 'f'yi temsil ediyor
                // karakter_2 değişkeni ise önce string olarak
                // "F" yaptığımız sonra da tip uyumu için 'F' yaptığımız
                // yeni harfimizi temsil ediyor.

                isimm = isimm.Replace(isimm[0], karakter_2);

                // isim ile ilgili işlemleri bitirdik. Şimdi de soyisim
                // ile ilgili işlemlere başlıyoruz

                // soyisim bilgisinin yeni hali, tamamı büyük
                // harflerle yazılmış hali olsun diyoruz.
                soyisim = soyisim.ToUpper();
            }

            Console.WriteLine($"Merhaba, {isimm} {soyisim}");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("1. Sayıyı giriniz: ");
            int sayi_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. Sayıyı giriniz: ");
            int sayi_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz matematiksel işlemin numarasını yazınız");
            Console.WriteLine("1: Toplama, 2: Çıkarma, 3: Bölme, 4: çarpma, 5: Kalan Bulma");
            string islem_no = Console.ReadLine();

            if (islem_no == "1")
            {
                Console.WriteLine($"{sayi_1}+{sayi_2} = {sayi_1 + sayi_2}");
            }
            else if (islem_no == "2") 
            {
                Console.WriteLine($"{sayi_1}-{sayi_2} = {sayi_1 - sayi_2}");
            }
            else if (islem_no == "3")
            {   double new_sayi_1 = Convert.ToDouble(sayi_1);
                double new_sayi_2 = Convert.ToDouble(sayi_2);
                double sonuc = new_sayi_1 / new_sayi_2;
                Console.WriteLine($"{sayi_1}/{sayi_2} = {sonuc}");
            }
            else if (islem_no == "4")
            {Console.WriteLine($"{sayi_1}*{sayi_2} = {sayi_1 * sayi_2}");}
            else if (islem_no == "5")
            {Console.WriteLine($"{sayi_1}%{sayi_2} = {sayi_1 % sayi_2}");}
            // if - else if ve else ile bu duruma uygun kodları yazınız
            // toplama işlemi if içerisinde değerlendirilecek
            // diğer 4 işlem else if içerisinde
            // eğer kullanıcı 1-5 aralığı haricinde bir işlem numarası
            // girmişse else bloku içerisinde bir uyarı mesajı verin
            // NOT: Bölme işleminin sonucunu ondalıklı olarak verin

            Console.WriteLine("---------------------------------------");

            Console.ReadLine();
        }
    }
}
