using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YBS_Hafta_10_OOP_1
{
    
    internal class Students
    {
        // Sınıf (Class), bir nesneye ait özelliğin (property) ya da
        // işlevin (fonksiyonun) bir arada tanımlandığı yapıdır.

        // O zaman diyebiliriz ki bir sınıf EN AZ bir tane özellikten
        // ve bir tane de fonksiyondan oluşmalıdır!!!

        // Nesne (Object), sınıfın kendisinden türetilen örnektir.
        // Nesne, sınıfa dair her şeydir.
        // Sınıfın kendisi şablondur, nesne; o şablondan üretilen özel
        // üründür.

        // Bir nesnenin, bir class içerisinde en az bir özelliğe ve
        // bir işleve (fonksiyon/metot) sahip olması gerektiğini söylemiştik

        // Özellik tanımlama:
        // Stundets sınıfı içerisinde her bir öğrencinin ortak
        // özelliğini tanımlıyoruz. Özellik, sınıfa dair ortak olarak
        // üretilecek olan tüm nesnelerin kullanacağı şeylerdir.

        // özellik tanımlanırken önce erişim belirteci sonra tipi sonra da
        // o özelliğin adı verilir.

        public string ogrenci_isim;
        public string ogrenci_soyisim;
        public string bolum;
        public int yas;
        public long ogrenci_no;
        public static List<string> ogrenci_dersler = new List<string>();





        // Bir sınıf hem özellikten hem de fonksiyondan oluşur demiştik
        // Özelliği (5 adet) yukarıda tanımladık. Şimdi de fonksiyon tanımlayacağız
        // Bir fonksiyon, özellikleri kullanarak neler yapılabileceğine karar verir

        // Yani, özellik: nesnenin sahip olduğu ortak-benzer bilgiler
        // Fonksiyon: bu özelliklerle neler yapılabileceği

        public void bolum_yazdir()
        {
            Console.WriteLine($"{ogrenci_isim} {ogrenci_soyisim} {bolum} bölümünde okumaktadır");
        }

        public void dogum_yili()
        {
            int dogum_yil = DateTime.Now.Year - yas;
            Console.WriteLine($"{ogrenci_isim} {ogrenci_soyisim} {dogum_yil} yılında doğmuştur");
        }

        // Parametre olarak string tipinde ders adı alan ve bu parametreyi
        // ogrenci_dersler isimli listeye ekleyen fonksiyonu yazınız

        public void ders_ekle(string ders_adi)
        {
            ogrenci_dersler.Add(ders_adi);
        }

        // Bir de, mevcut ders_listesini gösteren fonksiyonu yazınız

        public void ders_goruntule()
        {
            for (int i = 0; i < ogrenci_dersler.Count; i++)
            {
                Console.WriteLine(ogrenci_dersler[i]);
            }
            Console.WriteLine($"{ogrenci_no} no'lu öğrencinin {ogrenci_dersler.Count} adet dersi bulunmaktadır.");
        }


    }
}
