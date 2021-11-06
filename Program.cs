using System;

namespace switchCase
{
    class Program
    {
         static void Main(string[] args)
        {
            // Güncel ayı DateTime ile sistemden alıp mount değişkenine atıyoruz 
            int mount = DateTime.Now.Month;


            // Kodu test etmek isterseniz kendi mount değerinizi verebilirsiniz. Aşağıdaki kodu yorum satırından çıkartın.
            // Üstteki mount değişkenini yorum satırına alın ve istediğiniz gibi int değeri girerek kontrol edebilirsiniz.
            //int mount = 1;

            // Atadığımız mount değişkenini switch-case döngüsü için switch içerisinde atıyoruz
            switch (mount)
            {
                // case değerlerinde çalışacak kodları yazıyoruz. değerin 1 -2-3 v.b gelmesi durumlarını değerlendiriyoruz.
                case 1:
                Console.WriteLine("Ocak Ayındasınız!");
                break;
                case 2:
                Console.WriteLine("Şubat Ayındasınız!");
                break;
                case 3:
                Console.WriteLine("Mart Ayındasınız!");
                break;
                case 4:
                Console.WriteLine("Nisan Ayındasınız!");
                break;
                case 5:
                Console.WriteLine("Mayıs Ayındasınız!");
                break;
                case 6:
                Console.WriteLine("Haziran Ayındasınız!");
                break;
                case 7:
                Console.WriteLine("Temmuz Ayındasınız!");
                break;
                case 8:
                Console.WriteLine("Ağustos Ayındasınız!");
                break;
                case 9:
                Console.WriteLine("Eylül Ayındasınız!");
                break; 
                case 10:
                Console.WriteLine("Ekim Ayındasınız!");
                break;
                case 11:
                Console.WriteLine("Kasım Ayındaısnız!");
                break;
                case 12:
                Console.WriteLine("Aralık Ayındasınız!");
                break;

                // Default değer atıyoruz yukarıdaki değerlerden hiçbirisinin çalışmaması durumunda çalışacak kod
                default:
                Console.WriteLine("Girilen Değerde Hata Mevcut Lütfen Kontrol Ediniz!");
                break;
            }


            switch (mount)
            {
                // Mevsimleri kontrol ettiğimiz case kontolü--- 1 den fazla case in 1 kodu çalıştırmasını sağlayabiliriz.
                case 12:
                case 1:
                case 2:
                Console.WriteLine("Kış Mevsimindesiniz!");
                break;

                case 3:
                case 4:
                case 5:
                Console.WriteLine("İlk Bahar Mevsimindesiniz!");    
                break;

                case 6:
                case 7:
                case 8:
                Console.WriteLine("Yaz Mevsimindesiniz!");
                break;

                case 9:
                case 10:
                case 11:
                Console.WriteLine("Son Bahar Mevsimindesiniz!");
                break;            



                default:
                Console.WriteLine("Girilen değerler hatalı.");

                break;
            }

        }
    }
}
