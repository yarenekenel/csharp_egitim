using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Egitim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region YazdırmaKomutları

            //Console.WriteLine("**** YEMEK KATEGORİLERİ ****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("**** YEMEK KATEGORİLERİ ****");

            #endregion


            #region Değişkenler

            // string
            //string name;
            //name = "Yaren";
            //Console.WriteLine(name);


            //string customerName, surname, phone;
            //string customerEmail, district , city;

            //customerName = "Berkay";
            //surname = "Özenel";
            //phone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri : " + customerName + " " + surname);  
            //Console.WriteLine("İletişim : "+ phone );
            //Console.WriteLine("EMail Adresi : " + customerEmail);
            //Console.WriteLine("Adres : " + district + " / " + city);
            //Console.WriteLine();

            //customerName = "Yaren";
            //surname = "Ekenel";
            //phone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "İnegöl";
            //city = "Bursa";

            //Console.WriteLine("Müşteri : " + customerName + " " + surname);
            //Console.WriteLine("İletişim : " + phone);
            //Console.WriteLine("EMail Adresi : " +customerEmail);
            //Console.WriteLine("Adres : " +  district + " / " + city);


            #endregion


            #region İnt Değişkenler

            //int 
            int number = 24;
            Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restorant Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger :" + hamburgerPrice+ "TL");
            Console.WriteLine("-----Kola :" + cokePrice+ "TL");
            Console.WriteLine("-----Su :" + waterPrice + "TL");
            Console.WriteLine("-----Kızartma : " + friesPrice + "TL");
            Console.WriteLine("-----Pizza Menü : " + pizzaPrice + "TL");
            Console.WriteLine("-----Limonata : " + lemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restorant Menü Fiyatı ****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;


            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("İçecek Tutarı: " +totalCokePrice + "TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");
            Console.WriteLine("Kızartma Tutarı:" + totalFriesPrice + "TL");
            Console.WriteLine("Pizza Tutarı:"+ totalPizzaPrice + "TL");
            Console.WriteLine("Limonata Tutarı:" + totalLemonadePrice + "TL");

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalPizzaPrice +totalFriesPrice + totalHamburgerPrice + totalLemonadePrice;
            Console.WriteLine("Toplam Tutar:" + totalPrice + "TL");

            #endregion


            Console.Read();
        }
    }
} 


