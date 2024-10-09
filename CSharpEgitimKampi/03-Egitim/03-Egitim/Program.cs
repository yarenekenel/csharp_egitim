using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Egitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.WriteLine("Lütfen Şifreyi Giriniz.");
            //string password;
            //password = Console.ReadLine();   // konsol ekranı üzerinde okunan yazı passworde atansın.

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}

            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}



            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("veriler doğrulandı");
            //}

            //else
            //{
            //    Console.Write("hatalı bilgi");
            //}


            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = Convert.ToInt16(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}



            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Sınav 1: ");
            //exam1 = Convert.ToInt16(Console.ReadLine());

            //Console.Write("Sınav 2: ");
            //exam2 = Convert.ToInt16(Console.ReadLine());

            //Console.Write("Sınav 3: ");
            //exam3 = Convert.ToInt16(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average > 84 & average <= 100)
            //{
            //    result = "Sonuç Çok İyi";
            //}
            //Console.Write(result);   // result'a bir değer atamayınca bir başlangıç değeri olmadığı için hata verir 2 seçenek var --> 1: ilk başta alınan değeri null olarak gönder. 2: else olarak durumu kontrol et.



            //string city;
            //Console.WriteLine("Lütfen Bir Şehir Giriniz: ");
            //city = Console.ReadLine();   // kullanıcının konsoldan girdi yapmasını sağlar. Program bu satıra geldiğinde, kullanıcının klavyeden bir giriş yapmasını bekler ve giriş yapıldıktan sonra bu girdiyi bir string olarak döner. Genellikle kullanıcıdan veri almak için kullanılır.

            //if (city == "adana" | city=="ankara" | city=="bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}


            //Console.WriteLine("Lütfen Kullanıcı Adınızı Giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")   // eşit değilse yani adminden farklıysa
            //{
            //    Console.WriteLine("Bu Kullanıcı Adı Kabul Edilemez.");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            //Console.Write("Lütfen 1.Sayıyı Giriniz: ");
            //int number1 = Convert.ToInt16(Console.ReadLine());

            //Console.Write("Lütfen 2.Sayıyı Giriniz: ");
            //int number2 = Convert.ToInt16(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1.sayının 2.sayıya bölümünden kalan: " + result);




            //Console.Write("Lütfen Bir Sayı Giriniz: ");
            //int number = Convert.ToInt16(Console.ReadLine());

            //if ( number % 2 == 0)
            //{
            //    Console.WriteLine("Girilen Sayı Çift");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen Sayı Tek");
            //}

            #endregion

            #region Char Değişkenleri İle Karar Yapıları

            //char team;
            //Console.Write("Lütfen Takım Sembolünü Giriniz: ");
            //team = Convert.ToChar(Console.ReadLine());

            //if (team ==  'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f'  | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b'  | team == 'B') 
            //{
            //    Console.WriteLine("Beşiktaş");
            //}


            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("*** C# Eğitim Kampı Restoran ****");
            //Console.WriteLine();
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Lütfen Bir Seçim Yapınız: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Ana Yemekler");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Soslu Makarna");
            //    Console.WriteLine("2-Köri Soslu Tavuk");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Kızartma Tabağı");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Çorbalar");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Domates Çorbası");
            //    Console.WriteLine("2-Tavuk Çorbası");
            //    Console.WriteLine("3-Mantar Çorbası");
            //    Console.WriteLine("4-Mercimek Çorbası");
            //    Console.WriteLine("5-Ezogelin Çorbası");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Pizzalar");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Karışık Pizza");
            //    Console.WriteLine("2-Margaritha Pizza");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("İçecekler");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Cola");
            //    Console.WriteLine("2-Gazoz");
            //    Console.WriteLine("3-Ayran");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Tatlılar");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Magnolia");
            //    Console.WriteLine("2-Yaş Pasta");
            //    Console.WriteLine("3-Triliçe");
            //}

            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = Convert.ToInt32(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //    Console.WriteLine("Ocak");
            //        break;
            //    case 2:
            //    Console.WriteLine("Şubat");
            //        break;
            //    case 3:
            //    Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //    Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı Veri Girişi");
            //        break;
            //}
            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.WriteLine("1.Sayıyı Giriniz:");
            //number1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2.Sayıyı Giriniz:");
            //number2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Lütfen Yapacağınız İşlemin Sembolünü Giriniz:");
            //symbol = Convert.ToChar(Console.ReadLine());

            //switch(symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

            //    default:
            //        Console.WriteLine("Hatalı Tuş Girişi,Lütfen Tekrar Deneyiniz.");
            //        break;
            //}
            //Console.ReadLine();
            #endregion
        }
    }
}
