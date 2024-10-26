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
            //CRUD = CREATE / READ / UPDATE / DELETE

            Console.WriteLine("-----* Menü Sipariş Paneli *-----");
            Console.WriteLine();

            #region Kategori Ekleme İşlemi

            //Console.WriteLine("Eklemek istediğiniz kategoriyi giriniz: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=PEHLIVAN;initial catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori Başarıyla Eklendi!");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Eklemek istenilen ürün adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Eklenen ürünün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection con = new SqlConnection("Data Source=PEHLIVAN;initial catalog=EgitimKampiDb;integrated security=true");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)", con);
            //cmd.Parameters.AddWithValue("@p1", productName);
            //cmd.Parameters.AddWithValue("@p2", productPrice);
            //cmd.Parameters.AddWithValue("@p3", true);
            //cmd.ExecuteNonQuery();
            //con.Close();

            //Console.Write("Ürün eklemesi başarılı");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection con = new SqlConnection("Data Source=PEHLIVAN;initial catalog=EgitimKampiDb;integrated security=true");

            //con.Open();
            //SqlCommand cmd = new SqlCommand("Select * From TblProduct", con);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //con.Close();


            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürünün Idsi: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection con = new SqlConnection("Data Source=PEHLIVAN;initial catalog=EgitimKampiDb;integrated security=true");
            //con.Open();

            //SqlCommand cmd = new SqlCommand("Delete From TblProduct Where ProductId=@p1", con);
            //cmd.Parameters.AddWithValue("@p1", productId);
            //cmd.ExecuteNonQuery();

            //con.Close();

            //Console.WriteLine("Başarılı");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection con = new SqlConnection("Data Source=PEHLIVAN;initial catalog=EgitimKampiDb;integrated security=true");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("Update TblProduct Set ProductName=@p1,ProductPrice=@p2 Where ProductId=@p3", con);
            //cmd.Parameters.AddWithValue("@p1", productName);
            //cmd.Parameters.AddWithValue("@p2", productPrice);
            //cmd.Parameters.AddWithValue("@p3", productId);
            //cmd.ExecuteNonQuery();

            //con.Close();

            //Console.WriteLine("Güncelleme Başarılı");


            #endregion

            Console.Read();
        }
    }
}
