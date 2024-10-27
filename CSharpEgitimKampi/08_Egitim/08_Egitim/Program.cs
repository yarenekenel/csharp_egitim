using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Egitim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar


            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer --> Listele,ekle,sil,güncelle
            //Void


            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();




            //void Sum()
            //{
            //    int x = 1; 
            //    int y = 2;
            //    int z = x + y;

            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName) // --> Yazdırmak istediğim şeyi dışarıdan giricem.
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");



            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)   --> Void içi boş öylece duruyor o yüzden de değer döndürmüyor.
            //{
            //  int result  = number1 + number2 + number3;
            //  Console.WriteLine(result);
            //}

            //Sum(2, 4 ,5);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Yaren Ekenel";    // --> geriye döndürme işlemini return yapıyor.
            //}


            //string StudentCard()   // --> geri dönüş türü var o da string bu metod, ad ve soyadı birleştirip, bir string değeri geri döndürüyor. return ifadesiyle geri dönüş yapıyor.
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return  name + " " + surname;    // --> Bu fonksiyondan çıkan çıktı / sonuç.
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            // Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));

            #endregion

            #region Örnek Uygulama

            string ExamResult ( string student , int exam1 , int exam2, int exam3)
          {
             int result = (exam1 + exam2 + exam3) / 3;

             if (result >= 50) 
             {
                return student + " isimli öğrenci sınavı geçti     " + "Ortalama: " + result;
             }
             else
             {
                    return student + " isimli öğrenci sınavı geçemedi   " + "Ortalama: " + result;
                }
          }
          
            Console.WriteLine(ExamResult("Ali", 25,41,55));
            Console.WriteLine(ExamResult("Ayşe",36,88,33));

            Console.Read();

            #endregion

        }
    }
}


// "Geriye değer döndürmek" bir metodun çalıştırıldıktan sonra bir sonuç veya değer üretip bu değeri dışarıya, yani o metodu çağıran koda iletmesi demektir. Bu, programın başka bir yerinde o değeri kullanmanı sağlar.

//Metodun geri döndüreceği değeri belirtmek için dönüş türü (return type) kullanılır. Eğer metod bir sonuç üretip geri döndürüyorsa, return anahtar kelimesiyle bu değeri belirtir. Eğer geri değer döndürmeyecekse, dönüş türü olarak void kullanılır.

//Geriye Değer Döndürmeyen Metot (void)
//Bu metot sadece bir işlemi yapar, ama herhangi bir sonuç geri vermez.

//Geriye Değer Döndüren Metot
//Bu metot bir işlem yapar ve sonucunu geri döndürür. Örneğin, toplama işlemi yapan ve sonucunu geri döndüren bir metot: