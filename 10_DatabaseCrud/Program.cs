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
            Console.WriteLine("***** Panel İşlemleri *****");
            Console.WriteLine();

            Console.WriteLine("-----------------------");

            #region Kategori Ekleme 
            //Console.Write(" Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName=Console.ReadLine();

            //SqlConnection connection=new SqlConnection("Data Source=DESKTOP-6J2APNJ;Initial catalog=CampDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine();
            //Console.Write("Kategori Başarılı Bir Şekilde Eklendi.");

            #endregion

            #region Ürün Ekleme

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //productPrice=decimal.Parse(Console.ReadLine());



            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-6J2APNJ;Initial catalog=CampDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus) values (@pn,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@pn", productName); //ilaa productName olmak zorunda değil
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine();
            //Console.Write("Ekleme İşleminiz Başarılı");


            #endregion


            #region Ürün Listeleme

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-6J2APNJ;Initial catalog=CampDb;integrated security=true");
            //connection.Open();

            //SqlCommand cmd=new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows) //Row: Sıra
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() +" ");
            //    }
            //    Console.WriteLine();
            //}


            //connection.Close();
            #endregion

            #region Ürün Silme

            //Console.Write("Silinecek Ürün ID: ");
            //int productID=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-6J2APNJ;Initial catalog=CampDb;integrated security=true");
            //connection.Open();
            //SqlCommand cmd = new SqlCommand("Delete From TblProduct Where ProductId=@p1", connection);
            //cmd.Parameters.AddWithValue("@p1", productID);
            //cmd.ExecuteNonQuery();


            //connection.Close();


            //Console.WriteLine("Silme İşlemi Başarılı");
            #endregion


            #region Ürün Güncelleme

            Console.Write("Güncellenecek Ürün ID: ");
            int productID = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı: ");
            string productName =Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı: ");
            int productPrice = int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-6J2APNJ;Initial catalog=CampDb;integrated security=true");
            connection.Open();
            SqlCommand cmd = new SqlCommand("Update TblProduct Set ProductName=@p1, ProductPrice=@p2 where ProductId=@pID", connection);
            cmd.Parameters.AddWithValue("@p1", productName);
            cmd.Parameters.AddWithValue("@p2", productPrice);
            cmd.Parameters.AddWithValue("@pID", productID);
            cmd.ExecuteNonQuery();


            connection.Close();

            Console.WriteLine("Güncelleme İşlemi Başarılı");

            #endregion

            Console.Read(); 
        }
    }
}
