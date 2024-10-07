using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 7.75;

            //Console.WriteLine(number);


            //Console.WriteLine("****Fiyat Listesi****");
            //Console.WriteLine();

            //double applePrice, orangePrice, lemonPrice, tomatoPrice;


            //applePrice = 14.75;
            //orangePrice = 11.22;
            //lemonPrice = 20.25;
            //tomatoPrice = 18.85;

            //Console.WriteLine("-----Elma Birim Fiyatı: " + applePrice);
            //Console.WriteLine("-----Portakal Birim Fiyatı: " + orangePrice);
            //Console.WriteLine("-----Limon Birim Fiyatı: " + lemonPrice);


            //double appleGram, lemonGram, orangeGram, tomatoGramm;

            //appleGram = 1.25;
            //orangeGram = 2.850;
            //lemonGram = 1.455;
            //tomatoGramm = 2.50;

            //double appleTotalPrice, orangeTotalPrice, lemonTotalPrice, tomatoTotalPrice;

            //appleTotalPrice =appleGram*applePrice;
            //lemonTotalPrice =lemonGram*lemonPrice;
            //tomatoTotalPrice = tomatoPrice * tomatoGramm;
            //orangeTotalPrice = orangeGram * orangePrice ;






            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Elma : -" + "Birim Fiyatı : "+ applePrice+ " Gramjı : " + appleGram + " Toplam Ödenecek Tutar : " + appleTotalPrice);

            //Console.WriteLine("Domates : -" + "Birim Fiyatı : "+ tomatoPrice+ " Gramjı : " + appleGram + " Toplam Ödenecek Tutar : " + tomatoTotalPrice);

            //Console.WriteLine("Limon : -" + "Birim Fiyatı : "+ lemonPrice + " Gramjı : " + lemonGram + " Toplam Ödenecek Tutar : " + lemonTotalPrice);

            //Console.WriteLine("Portakal : -" + "Birim Fiyatı : "+ orangePrice + " Gramjı : " + orangeGram + " Toplam Ödenecek Tutar : " + orangeTotalPrice);


            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar : " + (orangePrice + lemonTotalPrice + tomatoTotalPrice + orangeTotalPrice));
            #endregion

            #region Klavyeden String Değer Alma

            //Console.WriteLine("****** Yolcu Bilgileri Ekranı *****");
            //Console.WriteLine();

            //string customerName, customerSurname;

            //Console.Write("Yolcu Adı: ");
            //customerName=Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //customerSurname = Console.ReadLine();


            //Console.WriteLine("Yolcu Bilgileri: " + customerName + " " + customerSurname);


            #endregion


            #region Klavyeden Tam Sayı Değer Girşi ve Dönüşümler

            //int shoesPrice, pcPrice, chairPrice;

            //shoesPrice = 1250;
            //pcPrice = 15000;
            //chairPrice = 500;

            //int shoesCount, pcCount, chairCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //pcCount= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + (shoesCount*shoesPrice + pcCount*pcPrice + chairCount*chairPrice));


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3;


            //Console.Write("1.Sınav Notunuz Girniz : ");
            //exam1= int.Parse(Console.ReadLine());


            //Console.Write("2.Sınav Notunuz Girniz : ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3.Sınav Notunuz Girniz : ");
            //exam3 = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Not Ortalaması : "+((exam1 + exam2 + exam3) / 3));

            #endregion

            Console.Read();
        }
    }
}