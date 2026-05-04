using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YBS_Hafta_10_OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C#'ta bir sınıfı harici şekilde oluşturmak için
            // sağ-üst taraftaki menüde yer alan proje simgesine
            // (yeşil renkle C# yazan yere) sağ tıklayıp
            // Ekle(Add)->Sınıf(Class) diyip o class'a bir isim veririz.
            // Bu sayede içi boş bir class (sınıf) oluşturulur.

            // Class'ı istediğiniz yerde tanımlayabilirsiniz. Ancak, onu sadece
            // Main metodunun altından çağırarak erişebilirsiniz

            // Bir class'tan bir nesne türetmek için aşağıdaki formül izlenir

            // Class_adı nesne_adı = new Class_Adı();
            // NOT: Class'tan türetilen nesneye "instance" adı verilir.

            // Yukarıdaki formülü izleyip Students class'ından bir instance
            // üretelim

            Students student_1 = new Students();

            // Students class'ından student_1 isimli nesne (instance) ürettik
            // Bizim class'ımızın içerisinde hem özellik hem de metot yer
            // alıyordu. Bir sınıfın içerisinde yer alan özellik ve metotlara
            // instance üzerinden erişmek için instance'nin adını yazarsınız
            // hemen yanına nokta koyarsınız ve karşınıza o sınıfın sahip
            // olduğu özellik ve metotlar gelir.

            // öğrencinin bilgilerini, özellikler sayesinde dolduruyoruz

            student_1.ogrenci_no = 1312503018;
            student_1.ogrenci_isim = "Furkan";
            student_1.ogrenci_soyisim = "ATLAN";
            student_1.bolum = "Yönetim Bilişim Sistemleri";
            student_1.yas = 32;

            student_1.bolum_yazdir();
            student_1.dogum_yili();

            student_1.ders_ekle("Genel Matematik");
            student_1.ders_ekle("İşletme-1");
            student_1.ders_ekle("Dijital Pazarlama");
            student_1.ders_ekle("Nesnesel Tasarım ve Programlama");

            student_1.ders_goruntule();
            // Students class'ı içerisine gidin ve orada ogrencinin yas
            // bilgisini kullanarak doğum yılını ekrana yazdıran fonksiyonu yazın
            Console.ReadLine();



        }
    }
}
