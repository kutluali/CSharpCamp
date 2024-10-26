using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            // "()"=> ile ifade edilir.
            //Mor renkte Küp olursa Methotdur.

            //Geriye Değer Döndürmeyen (VOID)

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Veli Yıldrım");
            //    Console.WriteLine("Mehmet Yel");
            //}

            //CustomerList();

            //void Sum(int v)
            //{
            //    int x = 1;
            //    int y = 3;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();


            #endregion


            #region Parametreli-Geriye Değer Döndürmeyen String Metotlar 

            //void WriteMethod(string CustomerName)
            //{
            //    Console.WriteLine(CustomerName);
            //}

            //WriteMethod("Mehmet Yıldrım");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine($"Müşteri: {name} {surName}");
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Zeynep", "Yılmaz");

            #endregion


            #region Parametreli-Geriye Değer Döndürmeyen String Metotlar 


            //void Sum(int num1, int num2, int num3)
            //{
            //    int result = num1 + num2 + num3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);


            #endregion


            #region Geriye Değer Döndüren Methodlar => Return

            //string CustomerName()
            //{
            //    return "Buse Yıldız";

            //}
            //CustomerName(); // Boş Gelir
            //Console.WriteLine(CustomerName()); //Dolu

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kutlu";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion


            #region Parametreli - Geriye Değer Döndüren Methodlar => Return


            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo=$"Ülke: {countryName} -Başkent: {capital} -Bayrak Rengi: {flagColor}";
            //    return cardInfo;


            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz :");
            //y= Console.ReadLine();

            //Console.Write("Başkent Giriniz: ");
            //z= Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //x= Console.ReadLine();
            //Console.WriteLine(CountryCard(y,z,x));
            #endregion

            Console.Read();
        }
    }
}
