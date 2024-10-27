using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Egitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach (1;2;3;4)  --> 4 tane parametre alıyor.

            //1:Değişken türü
            //2:Değişken adı
            //3:In
            //4:Liste, Koleksiyon, Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string a in cities)  // --> a değikeni citiesin içine gidip sırasıyla bütün değerleri üzerine alacak.
            //{
            //    Console.WriteLine(a);
            //}



            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}



            //int[] numbers = {45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}



            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine(total);



            //string word = "Merhaba";

            //foreach (char c in word) 
            //{
            //    Console.WriteLine(c);    // word ismindeki değişkeni chara göre parçalar her bir harfini c'ye atayıp sonra alt alta yazdırmasını bekliyoruz.
            //} 


            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            // klavyeden öğrenci adı soyadı numarası ve 3 sınav notunu alıp, bu notların ortalamasını yazdıran programı yazınız.


            //Console.Write("**** C# Eğitim Kampı Sınav Uygulaması ****");
            //Console.WriteLine();
            //Console.WriteLine();

            //// Sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            //int studentCount = Convert.ToInt32(Console.ReadLine());

            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //Console.WriteLine();

            //// Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //for ( int i = 0; i < studentCount; i++ ) 
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    // Her öğrenci için 3 sınav notu girişi

            //    for ( int j = 0; j < 3; j++ )
            //    {
            //        Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");

            //        double value = Convert.ToDouble( Console.ReadLine() );
            //        totalExamResult += value; // Notları topluyoruz.
            //    }
            //    Console.WriteLine();

            //    studentExamAvg[i] = totalExamResult / 3;
            //}

            //// Sınav Ortalamaları
            //for ( int i = 0;i < studentCount;i++ )
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]} ");


            //    // Öğrencilerin ortalaması ve geçip kalma durumları

            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçemedi");
            //    }

            //}

            Console.Read();
            #endregion

        }
    }
}
