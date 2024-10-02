using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Egitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double değişkenler

            //double number;

            //number = 4.85;
            //Console.WriteLine(number);



            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----Elma Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("----Portakal Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("----Çilek Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("----Patates Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("----Domates Fiyatı: " + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();


            //double appleGram, orangeGram, strawberryGram, potatoGram,tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat:"+ applePrice+ "  -- Gramj:" + appleGram + " --Toplam Fiyat: " + appleTotalPrice + " TL");

            //double orangeTotalPrice = orangePrice * orangeGram;
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat:"+ orangePrice + "  --Gramaj:"+ orangeGram+ "  -- Toplam Fiyat:" + orangeTotalPrice + "TL");

            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat:" + strawberryPrice + "  --Gramaj:" + strawberryGram + "  --Toplam Fiyat:"+ strawberryTotalPrice+ "TL");

            //double potatoTotalPrice = potatoPrice * potatoGram;
            //Console.WriteLine("Alınan Ürün: Patates - "+ "Birim Fiyat:" + potatoPrice + "  --Gramaj:" + potatoGram + "  --Toplam Fiyat:" + potatoTotalPrice +   "TL");

            //double tomatoTotalPrice = tomatoPrice * tomatoGram;
            //Console.WriteLine("Alınan Ürün: Domates - " +"Birim Fiyat:" +tomatoPrice + "  --Gramaj:" + tomatoGram + "  --Toplam Fiyat:" + tomatoTotalPrice+ "TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Toplam Alışveriş Tutarı:" + shoppingTotalPrice + " TL");


            #endregion

            #region Char değişkenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String

            //Console.WriteLine("*** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();  // klavyeden giriyoruz.

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("Yolcu TC Kimlik No: "+ passengerIdentityNumber + " --Yolcu Ad ve Soyad -" +passengerName + " " + passengerSurname+ " "+ "--Yolcu İlçe ve İl:"+ passengerDistrict + " " + passengerCity + " " + " --Yolcu Yaş:" +passengerAge );  // klavyeden girilen değeri gösterir.

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen aldığınız tv sayısını giriniz: ");
            //tvCount = Convert.ToInt32(Console.ReadLine());


            //int totalPrice = (shoesCount * shoesPrice) + (computerCount * computerPrice) + (chairCount * chairPrice) + (tvPrice * tvCount);

            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: " +  totalPrice);


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunuzu giriniz: ");
            //exam1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunuzu giriniz: ");
            //exam2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunuzu giriniz: ");
            //exam3 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine();

            //result = (exam1 + exam2 + exam3 ) / 3;
            //Console.WriteLine("Sınav Ortalamanız:" + result);

            #endregion

            #region  Klavyeden Karakter Girişleri

            //char gender;  //(cinsiyet)
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = Convert.ToChar(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion


            Console.Read();
        }
    }
}
