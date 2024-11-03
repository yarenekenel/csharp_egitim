using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Crud --> Create - Read - Update - Delete


            // C# ' tan SQL'e veri gönderme.

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            #region Kategori Ekleme İşlemi
            //Console.WriteLine("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source = 10.44.225.124; initial catalog = EgitimKampiDb; User ID=SA; Password=YarenEkenel.; ");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)" , connection);     // --> sorguları çağırıyoruz (sql)
            //command.Parameters.AddWithValue("@p1" , categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori Başarıyla Eklendi");

            #endregion

            #region Ürün Ekleme İşlemi

            //string prouductName;
            //decimal prouductPrice;
            //bool prouductStatus;

            //Console.Write("Ürün Adı: ");
            //prouductName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //prouductPrice = Convert.ToDecimal(Console.ReadLine());

            //SqlConnection Connection = new SqlConnection("Data Source = 10.44.225.124; initial catalog = EgitimKampiDb; User ID=SA; Password=YarenEkenel.; ");
            //Connection.Open();
            //SqlCommand cmd = new SqlCommand("insert into TblProduct (ProductName, ProductPrice , ProductStatus) values (@productName,@productPrice,@productStatus)", Connection);

            //cmd.Parameters.AddWithValue("productName", prouductName);
            //cmd.Parameters.AddWithValue("productPrice", prouductPrice);
            //cmd.Parameters.AddWithValue("productStatus", true);
            //cmd.ExecuteNonQuery();   // Değişikleri kaydet ve bunu veri tabanında yansıt.
            //Connection.Close();

            //Console.WriteLine("Ürün Eklmesi Başarılı");
            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection Connection = new SqlConnection("Data Source = 10.44.225.124; initial catalog = EgitimKampiDb; User ID=SA; Password=YarenEkenel.; ");
            //Connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct" , Connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);   // SQL'den veri çekerken veri listeleme sırasında arada bir köprü görevi gören komut.
            //DataTable dt = new DataTable();  // verileri geçici belleğe almak için kullanılan bir sınıf.
            //adapter.Fill(dt);  // dataTable' dan gelen veriler.

            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (var item in  row.ItemArray)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //    Console.WriteLine();  // her satır bittikten sonra boşluk bırak.
            //}

            // Connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = Convert.ToInt32(Console.ReadLine());

            //SqlConnection Connection = new SqlConnection("Data Source = 10.44.225.124; initial catalog = EgitimKampiDb; User ID=SA; Password=YarenEkenel.; ");
            //Connection.Open();

            //SqlCommand Command = new SqlCommand("Delete From TblProduct Where ProductId = @productId" , Connection);
            //Command.Parameters.AddWithValue("@productId" , productId);
            //Command.ExecuteNonQuery();   // Değişiklikleri veri tabanına yansıt.

            //Connection.Close();

            //Console.WriteLine("Silme İşlemi Yapıldı");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = Convert.ToDecimal(Console.ReadLine());


            //SqlConnection Connection = new SqlConnection("Data Source = 10.44.225.124; initial catalog = EgitimKampiDb; User ID=SA; Password=YarenEkenel.; ");
            //Connection.Open();

            //SqlCommand commad = new SqlCommand("Update TblProduct Set ProductName = @productName, ProductPrice = @productPrice where ProductId = @productId", Connection);  // güncelleme yaparken şartı yazman lazım yoksa bütün kayıtları günceller.
            //commad.Parameters.AddWithValue("@productName", productName);   // parametreleri çağırııyorum.
            //commad.Parameters.AddWithValue("@productPrice", productPrice);
            //commad.Parameters.AddWithValue("@productId", productId);
            //commad.ExecuteNonQuery();     // değişiklikleri kaydediyorum.

            //Connection.Close();

            //Console.WriteLine("Güncelleme İşlemi Başarılı");
            #endregion

            Console.Read();


        }
    }
}
