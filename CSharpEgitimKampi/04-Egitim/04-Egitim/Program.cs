using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Egitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  For Döngüsü
            // Döngüler 1+2+3+4+5+6
            // 3+3=6+4=10+5=15+6=21  --> yazılım mantığı

            // For (x,y,z)
            // x: başlangıç 
            // y:bitiş
            // z:artış-azalış

            //int i;
            //for(i=1; i<=5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 0; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i=3; i<=50; i+=3)
            //{
            //    Console.WriteLine(i);   
            //}


            //Console.Write("Lütfen Ekrana Yazılmasını İstediğiniz Adedi Giriniz: ");   // ben ekrana yazdığım değer kadar tekrar edecek.
            //int finishValue = Convert.ToInt32(Console.ReadLine());

            //for (int i= 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 0; i <= 100; i+=5)
            //{
            //    Console.WriteLine(i);   
            //}


            //for (int i = 1 ;i <= 100; i++)
            //{
            //    if (i % 5  == 0)
            //    {
            //        Console.WriteLine("5' tam bölünen sayılar: " +i);
            //    } 
            //}




            // 1 ile 10 arasındaki sayıları topla
            //int totalValue = 0;

            // for (int i = 1; i <= 10; i++)
            // {
            //  totalValue = totalValue + i; 

            // totalValue + i = totalValue        i --> 1         totalValue --> 0 
            //   0 + 1 = 1 (yeni değer)                 2                        1
            //   1 + 2 = 3                              2                        3
            //   3 + 3 = 6                              3                        6
            //   6 + 4 = 10                             4                        10
            //  10 + 5 = 15                             5                        15
            //  15 + 6 = 21                             6                        21
            //  21 + 7 = 28                             7                        28
            //  28 + 8 = 36                             8                        36
            //  36 + 9 = 45                             9                        45
            //  45 + 10= 55                            10                        55  
            //}
            //Console.WriteLine(totalValue);



            // 1 ile 20 arasındaki çift sayıların toplamı

            //int totalValue = 0;

            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue = totalValue + i;
            //        Console.WriteLine(i);
            //        Console.WriteLine(totalValue);


            // totalValue + i = totalValue        i --> 0        totalValue --> 0 
            //   0 + 2 = 2 (yeni değer)                 2                       2
            //   2 + 4 = 6                              4                       6
            //   6 + 6 = 12                             6                       12
            //  12 + 8 = 20                             8                       20
            //  20 + 10 = 30                           10                       30
            //  30 + 12 = 42                           12                       42
            //  42 + 14 = 56                           14                       56
            //  56 + 16 = 72                           16                       72
            //  72 + 18 = 90                           18                       90
            //  90 + 20 = 110                          20                      110

            //    }
            //}
            //Console.WriteLine("Çift Sayıların Toplamı: "+ totalValue);




            // 1 ile 50 arasında kaç tane sayı 7'ye tam bölünür.

            //int count = 0;

            //for (int i = 0; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);



            // Bir bakteri türü her saatin sonunda kendini 2 ye bölerek çoğaltmaktadır  1.saat-->1 2.saat-->4 3.saat-->8 4.saat--16...   24 saat sonunda kaç bakteri olduğunu hesaplatan programı yazın.


            //int bacterium = 1;

            //for (int i = 1; i<= 24; i++)   // burda i kaç defa aynı işlemi yani (çarpımı)  tekrar ettiriyor.
            //{
            //    bacterium = bacterium * 2;
            //    Console.WriteLine(i + ".Saat Sonunda Oluşan Bakteri Sayısı: " + bacterium);


            //  bacterium * 2 = bacterium                       bacterium --> 2
            //    1 * 2 = 2 (yeni değer)                                      4
            //    2 * 2 = 4                                                   8
            //    4 * 2 = 8                                                  16
            //    8 * 2 = 16                                                 32
            //   16 * 2 = 32                                                 64
            //   32 * 2 = 64                                                128
            //   64 * 2 = 128                                               256  
            //  128 * 2 = 256                                               512  
            //  256 * 2 = 512                                              1024 
            //  512 * 2 = 1024                                             2048
            // 1024 * 2 = 2048                                             4096
            // 2048 * 2 = 4096 ..... 
            // 16777216 --> 2 ^ 24
            // }
            #endregion

            #region While Döngüsü

            // while (şart)
            //{
            //işlemler
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("merhaba");
            //    i++;
            //    Console.WriteLine(i);
            //}


            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);   // önce gel bunu kontrol et eğer bu şartı sağlıyorsa 1 arttır.
            //    }
            //    i++;
            //}

            //int i = 1 , sum = 0 ;
            //while (i <= 10)
            //{
            //    sum+=i;
            //    i++;
            // sum + i = sum                      i --> 0                sum --> 0 
            //   0 + 1 = 1 (yeni değer)                 1                        1
            //   1 + 2 = 3                              2                        3
            //   3 + 3 = 6                              3                        6
            //   6 + 4 = 10                             4                        10
            //  10 + 5 = 15                             5                        15
            //  15 + 6 = 21                             6                        21
            //  21 + 7 = 28                             7                        28
            //  28 + 8 = 36                             8                        36
            //  36 + 9 = 45                             9                        45
            //  45 + 10= 55                            10                        55  
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.  --> 456

            //int number , onlar , yüzler , birler , totalValue;
            //number = Convert.ToInt32(Console.ReadLine());

            //birler = number % 10;
            //onlar = (number / 10) % 10;
            //yüzler = number / 100;     // 4.56 --> 4

            //Console.WriteLine(birler);
            //Console.WriteLine(onlar);
            //Console.WriteLine(yüzler);

            //totalValue = birler + onlar + yüzler;
            //Console.WriteLine("Basamaklar Toplamı:  " +totalValue);

            #endregion


            // !!! İPUCU --> İLK ÖNCE İ'NİN ADIM SAYISINI BELİRLE SONRA SONUÇ BUL DAHA  SONRA ELDE ETTİĞİN SONUÇLARI YENİ SONUÇ DEĞERİNE ATA VE DEVAM ET , AMA ÖNCELİK İ'NİN ADIM SAYISINI BULMAK !!!
            Console.Read();



        }
    }
}
