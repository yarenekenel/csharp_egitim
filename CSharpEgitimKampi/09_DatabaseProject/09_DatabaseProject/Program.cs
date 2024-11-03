using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ado . net  --> SQL yapılarını kullanabilmemize olanak sağlayan bir yapı çerçeve

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();


            //   ---> SQL bağlantısı lazım bize   SQL bağlantısını kullanmak için kullanmam gereken komut sqlconnection

            SqlConnection connection = new SqlConnection("Data Source=192.168.1.143;Initial Catalog=EgitimKampiDb;User ID=SA;Password=YarenEkenel.;");
            // nesne örneği
            connection.Open();  // --> bağlantıyı açtık

            SqlCommand command = new SqlCommand("Select * From TblCategory" , connection);  // --> sorguyu yazdım
            SqlDataAdapter adapter = new SqlDataAdapter(command);  // --> C# ile SQL arasında bir köprü görevi
            DataTable datatable = new DataTable();    // --> verileri belleğe almamı sağlayacak
            adapter.Fill(datatable);
            connection.Close();


            foreach (DataRow row in datatable.Rows)
            {
                foreach ( var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine() ;
            }

            Console.Read();

        }
    }
}
