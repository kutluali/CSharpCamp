using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Ben Ali");

            //Console.WriteLine();

            //Console.WriteLine("*** Yemek Kategorileri ***");
            //Console.WriteLine("1- Çorba");
            //Console.WriteLine("2- Kebap");
            //Console.WriteLine("3- Köfte");
            //Console.WriteLine("4- İçeçecekler");

            //Console.WriteLine("*** Yemek Kategorileri ***");

            #endregion

            #region String Değişkenler

            //string CustomerName;
            //string CustomerAddress;
            //string CustomerPhone;

            //CustomerName = "Ahmet Yılmaz";
            //CustomerAddress = "Fatih/İstanbul";
            //CustomerPhone = "90 0505 500 50 50";

            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Müşteri Adı: " + CustomerName);
            //Console.WriteLine("Telefon Numarası: " + CustomerPhone);
            //Console.WriteLine("Adres Bilgisi: " + CustomerAddress);
            //Console.WriteLine("-------------------------------");


            #endregion

            #region Int Değişkenler

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int pizzaPrice = 250;
            int ayranPrice = 30;
            int limonataPrice = 30;
            int sodaPrice = 15;

            Console.WriteLine("**** Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("------Hamburger: " +hamburgerPrice+ "₺");
            Console.WriteLine("------Pizza: "+ pizzaPrice+ "₺");
            Console.WriteLine("------Ayran: " +ayranPrice + "₺");
            Console.WriteLine("------Limonata: "+ limonataPrice+ "₺");
            Console.WriteLine();
            Console.WriteLine("**** Menü Fiyatı ****");

            int hamburgerCount;
            int pizzaCount;
            int limonataCount;
            int ayranCount;
            int sodaCount;

            int totalHamburgerPrice;
            int totalPizzaPrice;
            int totalAyranPrice ;
            int totalLimonataPrice ;
            int totalSodaPrice ;

            hamburgerCount = 3;
            pizzaCount = 3;
            limonataCount = 3;
            ayranCount = 3;
            sodaCount=0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalPizzaPrice= pizzaCount * pizzaPrice;
            totalLimonataPrice = limonataCount * limonataPrice;
            totalAyranPrice = ayranCount * ayranPrice;
            totalSodaPrice = sodaCount * sodaPrice; 

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Toplam Hamburger Tutarı: "+totalHamburgerPrice);
            Console.WriteLine("Toplam Pizza Tutarı: "+totalPizzaPrice);
            Console.WriteLine("Toplam Ayran Tutarı: "+totalAyranPrice);
            Console.WriteLine("Toplam Limonata Tutarı: "+totalHamburgerPrice);
            Console.WriteLine("Toplam Soda Tutarı: "+totalSodaPrice);

            int totalPrice= totalHamburgerPrice+totalPizzaPrice+totalLimonataPrice+totalAyranPrice+totalSodaPrice;

            Console.WriteLine("-------------------------");
            Console.WriteLine("Toplam Tutar: "+totalPrice);

            #endregion


            Console.Read();
        }
    }
}
