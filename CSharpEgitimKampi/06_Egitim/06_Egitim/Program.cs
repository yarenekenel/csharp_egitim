using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Egitim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri 

            // Aynı veri tipindeki çok sayıda veriyi birarada tutmak için kullanılan yapı.
            // 2,4,6,8
            // sarı,kırmızı,mavi,turuncu,beyaz
            //adana,ankara,istanbul,bursa

            // syntax --> değişkenTürü [] diziAdı = new değişkenTürü[elemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";

            //Console.WriteLine(colors[2]);


            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[0]);


            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[5]);  // --> dizide tanımlamadığım sayıyı bize "0" olarak gösterir.


            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[4]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "sarı", "kırmızı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine("3'e bölünen sayılar: " + numbers[i]);
            //    } 
            //}


            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i< symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}




            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0];  // --> bu max değişkenine ilk değeri ata for ile dizideki tüm sayıları gezecek ve if ile de sayıları karşılaştıracak büyük olanı tutacak.

            //for (int i = 1; i < maxNumber; i++)
            //{
            //    if (myArray[i] > maxNumber)   // --> ilk olarak myArray[0] = 47   maxNumber = 47   47 - 47' den büyük değil döngüden çık maxnumber 47' de kaldı. 
            //    {                            //  -->            myArray[1] = 85   maxNumber = 47   85 - 47' den büyük mü evet o zaman maxnumber'a 85 ata.
            //                                 //  -->            myArray[2] = 95   maxNumber = 85   95 - 85' ten büyük mü evet o zaman maxnumber'a 95 ata.
            //                                 // -->             myArray[3] = 41   maxNumber = 95   41 - 95'ten büyük mü hayır o zaman döngüden çık.
            //                                 // -->             myArray[4] = 25   maxNumber = 95   25 - 95' ten büyük mü hayır o zaman döngüden çık.
            //                                 // -->             myArray[5] = 635  maxNumber = 95   635 - 95'ten büyük mü evet o zaman maxnumber'a 635 ata.
            //                                 // -->             myArray[6] = 789  maxNumber = 635  789 - 635'ten büyük mü evet o zaman maxnumber'a 789 ata.
            //                                 // -->             myArray[7] = 86   maxNumber = 789  86 - 789'dan büyük mü hayır o o zaman döngüden çık.
            //                                 // -->             myArray[8] = 100  maxNumber = 789  100 - 789'dan büyük mü hayır o zaman döngüden çık.
            //                                 // dizinin sonunda en büyük değer 789 olarak kaldı kii bu dqa dizinin en büyük değeridir :)
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);




            #endregion

            #region Dizi Metotları

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);   // --> DİZİNİN UZUNLUĞUNU GÖSTERMEYE YARAYAN BİR METOTTUR. --> 6 TANE DİZİ ELEMANI VARDIR.


            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);     // --> DİZİYİ KÜÇÜKTEN BÜYÜĞE DOĞRU SIRALAMAYA YARAYAN METOTTUR.
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);     // --> DİZİYİ TERSTEN YAZAN METOTTUR.
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };

            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + "  Dizinin En Küçük Elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcından Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}.Şehri Giriniz:  ");              // $ --> sembolü bir çift tırnak içerisinde parametresel ifadeler kullanmama olanak sağlar.Yani çift tırnak ve + yerine bu sembolü kullanabiliriz.

            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //for (int i = 0;i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}



            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);




            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine("Çift Sayılar: " + numbers[i]);
            //    }
            //}

            //for (int j = 0; j < numbers.GetLength(0); j++)
            //{
            //    if (numbers[j] % 2 != 0)    // Ya Da --> (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine("Tek Sayılar: " + numbers[j]);
            //    }
            //}

            //Console.Read();
            #endregion

        }
    }
}
