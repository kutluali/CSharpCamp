using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen Şifreyi Giriniz : ");

            //string password=Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}


            //string capital, country;

            //Console.Write("Başkent Giriniz : ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz : ");
            //country = Console.ReadLine();


            //if (capital=="ankara" & country=="türkiye")
            //{
            //    Console.WriteLine("Bilgiler Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Bilgiler Yanlış");
            //}

            //int exam1, exam2, exam3, avegare;
            //string result;

            //Console.Write("1.Sınav Notu : ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sınav Notu : ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3.Sınav Notu : ");
            //exam3 = int.Parse(Console.ReadLine());

            //avegare = (exam1+exam2+exam3)/3;

            //Console.WriteLine("Sınavların Ortalaması : "+avegare); 


            //if (avegare > 0 & avegare <= 50)
            //{
            //    result = "Vasat";
            //}
            //if(avegare>50 & avegare <=70)
            //{
            //    result = "Orta";
            //}
            //if (avegare>70 & avegare<=84)
            //{
            //    result = "İyi";
            //}
            //if (avegare>84)
            //{
            //    result = "Çok İyi";
            //}
            //else
            //{
            //    result = "Vasıfsız";
            //}

            ////Else olmazsa--> "string result="Hata"; denilmeli

            //Console.WriteLine(result);

            //string city;

            //Console.Write("Şehir Girşi Yapınız : ");
            //city = Console.ReadLine();


            //if (city=="adana" | city=="istanbul" | city=="sinop")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}






            #endregion


            #region Mod İşlemleri

            //Console.Write("1. Sayıyı Giriniz : ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("2. Sayıyı Giriniz : ");
            //int number2 = int.Parse(Console.ReadLine());



            //int result=number1%number2;


            //Console.WriteLine("1. Sayının 2. Sayıya Bölümünden Kalan : " + result);



            //Console.Write("Lütfen Sayı Giriniz : ");
            //int number=int.Parse(Console.ReadLine());

            //if (number %2==0)
            //{
            //    Console.WriteLine("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tektir");
            //}


            #endregion

            #region Örnek Proje Uygulaması 

            //Console.WriteLine("**** C# Eğitim Kampı Restorant ****");
            //Console.WriteLine();
            //Console.WriteLine("---------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("---------------");
            //Console.WriteLine();


            //string menuItem;

            //Console.Write("Görmek İstediğiniz Menu Seçimini Yapın: ");
            //menuItem = Console.ReadLine();


            //if (menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------- Ana Yemekler --------");
            //    Console.WriteLine("1- Kebap");
            //    Console.WriteLine("2-Balıklar");
            //    Console.WriteLine("2-Baklagiller");
            //    Console.WriteLine();
            //    Console.WriteLine("------- Ana Yemekler --------");

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------- Çorbalar --------");
            //    Console.WriteLine("1- Mercimek");
            //    Console.WriteLine("2-Yayla");
            //    Console.WriteLine("2-Kremalı Tavuk");
            //    Console.WriteLine();
            //    Console.WriteLine("------- Çorbalar --------");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------- Pizzalar --------");
            //    Console.WriteLine("1- Karışık");
            //    Console.WriteLine("2-Magaritta");
            //    Console.WriteLine("2-Sebzeli");
            //    Console.WriteLine();
            //    Console.WriteLine("------- Pizzalar --------");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------- İçecekler --------");
            //    Console.WriteLine("1- Ayran");
            //    Console.WriteLine("2-Limonata");
            //    Console.WriteLine("2-Komnposto");
            //    Console.WriteLine();
            //    Console.WriteLine("------- İçecekler --------");
            //}

            #endregion


            #region Switch Case


            //Console.Write("Lütfen Ay Girişi Yapınız : ");
            //int montNumber = int.Parse(Console.ReadLine());

            //switch (montNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak");
            //        break;

            //    case 2:
            //        Console.WriteLine("Şubat");
            //        break;

            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;

            //    default:
            //        Console.WriteLine("Hatalı Giriş");
            //        break;
            //}





            #endregion


            #region Switch Case Hesap Makinesi

            int number1, number2, result;

            char symbol;

            Console.Write("1. Sayıyı Giriniz : ");
            number1=int.Parse(Console.ReadLine());

            Console.Write("2. Sayıyı Giriniz : ");
            number2 =int.Parse(Console.ReadLine());

            Console.Write("Yapmak İstediğiniz İşlemin Sembolünü Giriniz : ");
            symbol=char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Sonuç : " + result);
                    break;

                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Sonuç : " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Sonuç : " + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Sonuç : " + result);
                    break;
            }
            
            #endregion

            Console.Read();
        }
    }
}
