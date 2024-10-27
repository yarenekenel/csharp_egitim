using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Egitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 Tane Yıldız Oluşturma
            //for (int i=1; i<=10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion

            #region Alt Alta 10 Tane Yıldız Oluşturma Her Satırda 10 Tane Yıldız Olsun
            //for (int i=1; i<=10; i++)
            //{
            //    Console.WriteLine("**********");
            //}
            #endregion

            #region Dik Üçgen 

            //for (int i=1; i<=5; i++)            // i = 1    j = 1    *
            //{                                   // i = 2    j = 2    **
            //                                    // i = 3    j = 3    ***
            //for (int j=1; j<=i; j++)            // i = 4    j = 4    ****
            //    {                               // i = 5    j = 5    *****
            //        Console.Write("*");
            //    }
            // Console.WriteLine();
            //}
            #endregion

            #region Ters Dik Üçgen 

            //for (int i = 5; i >= 1; i--)            // i = 5   j = 1   ******
            //{                                       // i = 4   j = 2   ****
            //    for (int j = 1; j <= i; j++)        // i = 3   j = 3   ***
            //    {                                   // i = 2   j = 4   **
            //        Console.Write("*");             // i = 1   j = 5   *
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Elmas Şekli (Dik ve Ters Dik Üçgen Beraber)

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();   
            //}

            //for (int i = 4; i >= 1 ;i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(); //  --> Boşluk Bıraksın
            //}
            #endregion

            #region Piramit

            //int n = 5;   
            //for (int i = 1; i<=n; i++)
            //{    // boşluklar için
            //    for (int j = n-i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //yıldızlar
            //    for (int k = 1; k<=2*i-1; k++)   // k --> tek sayıları yazdırıyor(2 katının 1 eksiği)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Ters Piramit

            //int n = 5;
            //for (int i=n; i >= 1; i--)
            //{
            //    // boşluklar
            //    for (int j= n - i; j >= 1; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //yıldızlar
            //    for (int k = 1; k <= 2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            Console.Read();


        }
    }
}
