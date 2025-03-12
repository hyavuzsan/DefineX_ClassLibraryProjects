using AttributeLibrary;

namespace AttributeConsoleApp
{
    public class Ogrenci
    {
        [ZorunluAlan]
        public string Adi;
        [ZorunluAlan]
        public string Soyadi;
        [ZorunluAlan]
        public string Bolum;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();

            // Konsoldan kullanıcıdan veri al
            Console.Write("Adınızı giriniz: ");
            ogrenci.Adi = Console.ReadLine();

            Console.Write("Soyadınızı giriniz: ");
            ogrenci.Soyadi = Console.ReadLine();

            Console.Write("Bölümünüzü giriniz: ");
            ogrenci.Bolum = Console.ReadLine();

            
            if (!ZorunluAlanAttribute.Dogrula(ogrenci))
            {
                Console.WriteLine("\nÖğrenci bilgileri doğrulamadan geçemedi! Lütfen tüm alanları doldurun.");
            }
            else
            {
                Console.WriteLine("\nForm başarılı! Öğrenci kaydı tamamlandı.");
            }

            
            Console.WriteLine("\nÇıkmak için bir tuşa basın...");
            Console.ReadKey();
            Console.WriteLine("Çıkılıyor...");
        }
    }
}

