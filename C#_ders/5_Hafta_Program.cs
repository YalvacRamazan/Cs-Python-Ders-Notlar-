using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace YBS_Hafta_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Veri yapıları-1: Array
            // Mevcut veri yapıları arasında en zayıf, en ilkel olanı
            // denilebilir. Sabit boyutludur (en önemli özelliği)
            // herhangi bir özelliği yoktur (eleman uzunluğunu verir sadece)
            // belli başlı sıralama işlemleri yapılmasına olanak sağlar
            // eleman ekleme, silme işlemlerine izin vermez
            // ilk başta nasıl tanımlanırsa o şekilde devam edilir/geliştirilir
            // Sabit değerler için (haftanın günleri vb)
            // kullanılabilir

            // Aşağıda bir array tanımlamasına örnek verilmektedir

            // Array Tanımlama-1: sadece boyutunu belirtip bırakmak
            int[] sayilar = new int[5];

            sayilar[0] = 55;
            sayilar[1] = 70;
            sayilar[2] = 483;
            sayilar[3] = 256315;
            sayilar[4] = 28;

            // Array Tanımlama-2: boyut bilgisini direkt eleman üzerinden vermek
            int[] sayilar_2 = new int[] {10,20,30,40,50};

            // for döngüsü üzerinden bir veri yapısının elemanlarına erişmek

            for (int i=0;i<sayilar.Length;i++)
            {
                Console.WriteLine($"index = {i} \t değer = {sayilar[i]}");
            }

            
            Array.Sort(sayilar);
            Console.WriteLine(sayilar);
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"index = {i} \t değer = {sayilar[i]}");
            }

            sayilar[4] = 0;
            Console.WriteLine(sayilar[4]);
            Console.WriteLine("-----------------------------------------");

            // List veri yapısı:
            // Tip bağımlı (aynı tipte olması zorunlu olan) ve dinamik (Değişken)
            // verilerin tutulmasında eklenmesinde silinmesinde kullanılır

            // Tanımlamaya Örnek
            List<String> sehirler = new List<String>()
            {
                "Burdur",
                "İstanbul"
            };

            sehirler.Add("Antalya");
            sehirler.Add("İzmir");
            sehirler.Add("Ankara");
            sehirler.Add("Diyarbakır");

            //foreach döngüsüyle bir veri yapısının elemanlarına erişim

            foreach (String item in sehirler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------");

            // Elemanın var olup olmadığını sorgulama
            Console.WriteLine(sehirler.Contains("İstanbul"));
            Console.WriteLine("-----------------------------------------");

            // liste içerisindeki tüm elemanları siler clear() metodu
            //sehirler.Clear();

            // eleman sayısını verir
            int uzunluk = sehirler.Count;
            Console.WriteLine($"Toplam Şehir sayısı = {uzunluk}");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine(sehirler[0]);

            // Remove metodu ile eleman-değer bazlı silme işlemi yapılır
            sehirler.Remove("Burdur");
            Console.WriteLine(sehirler[0]);

            // insert ile istediğiniz indekse istediğiniz değeri eklersiniz
            sehirler.Insert(0,"Zonguldak");
            Console.WriteLine(sehirler[0]);

            // IndexOf ile parametre olarak verdiğiniz değerin indeks
            // numarasını getirir
            Console.WriteLine(sehirler.IndexOf("İstanbul"));

            // indeks bazlı eleman silme
            // örneğin, 3. indeksteki elemanı silmek istesek aşağıdaki
            // kodu yazarız
            // sehirler.RemoveAt(3);

            Console.WriteLine(sehirler[3]);
            
            // eleman güncellemek için de indeks numarasına göre
            // işlem yapılır
            sehirler[3] = "İzmir Yeni";

            Console.WriteLine(sehirler[3]);
            Console.WriteLine("-----------------------------------------");

            // Veri Yapıları-3: ArrayList
            // List'in yaptığı her şeyi yapabilir. Tek farkı, tip bağımlı
            // olmak yerine tüm elemanları object olarak değerlendirip
            // farklı tipteki elemanların bir arada saklanmasına izin vermesidir

            ArrayList my_arraylist = new ArrayList()
            {
                "İstanbul",34,"Makü",false,1654.4569,
                5236,"Bucak ZTYO","YBS",true
            };

            my_arraylist.Add(2456);
            my_arraylist.Add(102.5469);
            my_arraylist.Add("2569.458");

            Console.WriteLine(typeof(String));
            // foreach döngüsü ile my_arraylist değişkenindeki
            // tüm elemanlara erişin
            // bu elemanlar arasında tipi System.String olan
            // elemanların sonuna "A" harfi ekleyin
            // deneyin

            foreach (var item in my_arraylist)
            {
                // o anki elemanın tipi string ise
                
                if (item.GetType() == typeof(String))
                {
                    string item_2 = (string)item;
                    item_2 = item_2 + "A";
                    Console.WriteLine(item_2);
                }
            }
            // NOT: if(item is string) sorgusu da o elemanın tipinin
            // string olup olmadığını verebiliyor


            // if(eleman.GetType()==typeof(String))
            Console.WriteLine("-----------------------------------------");

            List<int> maaslar = new List<int>()
            { 25000,18750,106000,56850,63200,23000,29740,19850,
            76300,108500};

            // Yukarıda bir firmanın personel maaş listesi verilmektedir.
            // Aynı tipte içi boş bir List'e oluşturun

            // Sonrasında foreach döngüsü ile maaslar listesinin içine girin
            // eğer o anki maaş 25000 ve aşağısı ise %55 zam yapın

            // 25001 ve 65000 arasında ise (65000'de dahil)
            // %35 zam yapın

            // 65001 ve üzeri ise %15 zam yapın
            // zamlı halleri yeni veri yapısına aynı sırada ekleyin
            // işiniz bittikten sonra önce maaslar veri yapısını
            // sonra da sizin içini doldurduğunuz veri yapısını

            // döngüyle ekrana yazdırın

            // ilk olarak içi boş ve double (yüzdelik için) bir liste tanımlıyoruz

            List<double> zamli_maaslar = new List<double>();

            // ikinci olarak foreach döngüsüyle maaslar veri yapısının içine
            // girip her  bir elemana erişiyoruz

            for (int i = 0; i < maaslar.Count; i++)
            { 
                double maas = Convert.ToDouble(maaslar[i]);

                if (maas<=25000.0)
                {
                    maas = maas * 1.55;
                }
                else if(maas>=25001.0 & maas<=65000)
                {
                    maas = maas * 1.35; // %35 zam hesaplama 1. yol
                    // maas = maas+(maas*0.35) %35 zam hesaplama 2. yol
                }
                else if (maas >= 65001.0)
                {
                    maas = maas * 1.15;
                }
                zamli_maaslar.Add(maas);
            }

            for (int i = 0; i < zamli_maaslar.Count; i++)
            {
                Console.WriteLine($"Maaş={maaslar[i]} \t Zamlı={zamli_maaslar[i]}");
            }

            Console.WriteLine("-----------------------------------------");

            // Veri Yapıları-4: HashSet (Kümeler)
            // Matematikteki kümelerle bire bir aynı özellikleri ve metotları taşır

            // En önemli farkı, aynı verilerin yalnızca bir adet tutulmasıdır
            // yani diyelim ki 8 tane 3 var ama o bunların hepsine tek bir tane 3
            // gibi davranır. Tıpkı matematikteki kümelerde olduğu gibi

            HashSet<int> my_hashset = new HashSet<int>() {
            8,13,56,8,8,7,65,65,19,45,86,87,75,86
            };

            HashSet<int> my_hashset_2 = new HashSet<int>() {
            19,7,25,30,25,19,19,7,56,59,59,60
            };

            Console.WriteLine("HashSet-1 Elemanlar: ");
            foreach (var item in my_hashset)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*************************************");
            Console.WriteLine("HashSet-2 Elemanlar: ");
            foreach (var item in my_hashset_2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*************************************");

            // Set (Kümelerde) birleşim işlemi

            Console.WriteLine("Birleşim İşlemi");
            my_hashset.UnionWith(my_hashset_2);
            foreach (var item in my_hashset)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(my_hashset);

            // Set (Kümelerde) Kesişim İşlemi
            Console.WriteLine("*************************************");
            Console.WriteLine("Kesişim İşlemi");
            my_hashset.IntersectWith(my_hashset_2);
            foreach (var item in my_hashset)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(my_hashset);

            // Fark İşlemi
            Console.WriteLine("*************************************");
            Console.WriteLine("Fark İşlemi");
            my_hashset.Except(my_hashset_2);
            foreach (var item in my_hashset)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(my_hashset);

            // NOT: Birleşim ve kesişim işlemlerinde kümelerin sırasının
            // önemi yoktur. Sonuç aynıdır

            // Ancak, fark işlemin küme sıralaması kesinlikle önemlidir
            // İşlemler arka arkaya yapıldığında birleşim işleminden sonra
            // tüm işlemler üst üste biner !!!

            Console.WriteLine("*************************************");

            // Veri Yapıları-5: Dictionary
            // Sözlük anlamına gelir. Nasıl ki sözlükte bir kelimeyi çevirip
            // onun karşılığına bakıyorsak aynen veri yapısında da
            // bir anahtar (key) belirleyip bu anahtarın içerisine
            // değerler (value) yazıyoruz ve bu değerlere her erişmek
            // istediğimizde bu anahtar ismiyle erişiyoruz
            // NOT: anahtarların ismi kesinlikle benzersiz olmalı ama
            // değerler aynı olabilir.

            // key-value birlikteliğine dayanır. Dolayısıyla en az 2
            // tip alır başlangıçta

            Dictionary<int, string> my_dictionary = new Dictionary<int, string>()
            {
                {10,"Furkan"},
                {18,"Ahmet"},
                {110,"Veysel"}

            };
            my_dictionary.Add(123,"Enes");

            // foreach döngüsüyle dictionary veri yapısındaki elemanlara erişmek
            // diğer veri yapılarına göre bir tık daha zor ve karmaşıktır. Çünkü,
            // bu veri yapısında item değeri tek bir elemandan oluşmuyor
            // bir tane key olmak zorunda ve en az bir tane de value değeri olmak
            // zorunda. Dolayısıyla biz aynı anda hem key hem de value değerine
            // erişmek zorundayız. Bunun için özel bir metot vardır

            foreach (KeyValuePair<int,string> item in my_dictionary)
            {
                Console.WriteLine($"anahtar = {item.Key} \t değer = {item.Value}");
            }
            Console.ReadLine();


        }
    }
}
