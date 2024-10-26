using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü


            //for(x;y;z)
            //x : Başlangıç
            //y : Bitiş
            //z : Arttrım - Azaltım

            //int a;

            //for (a = 1; a <= 5; a++)
            //{
            //    Console.WriteLine("C# Camp");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 5; i <= 50; i+=5)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Ekranda Kaç Defa Yazılmasını İstersiniz (Rakam olarak Giriniz) : ");
            //int finishvalue=int.Parse(Console.ReadLine());

            //for (int i = 0; i < finishvalue; i++)
            //{
            //    Console.WriteLine("Fenerbahçe");


            //}


            //int totalValue = 0;

            //for (int i = 0; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue=0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue +=i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 1; i <= 24; i+=3)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-----------------");
            //Console.WriteLine(totalValue);


            //int total = 0;

            //for (int i = 1; i <= 55; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        total++;

            //        Console.WriteLine(i);

            //    }
            //}
            //Console.WriteLine("-----");
            //Console.WriteLine(total);

            //int bacterium = 1;

            //for (int i = 0; i <=24; i++)
            //{
            //    bacterium *=2;
            //    Console.WriteLine(i +".Saatin Sonunda: " + bacterium);
            //}
            #endregion


            #region While Döngüsü


            //while (şart)
            //{
            //    işlemler
            //}

            //int i = 1;

            //while (i <10)
            //{
            //    Console.WriteLine("Merhaba");
            //    i++;    
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum +=i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion




            #region Sınav Sorusu
            // Klavyeden girilen 3 basamaklı sayının basamaklarının toplamı olan kodu yazınız

            //456


            Console.Write("Sayıyı Giriniz: ");
            int number=int.Parse(Console.ReadLine());

            int ones, tens, hundreds;
            int sum;


            
            hundreds = number / 100;
            tens =(number / 10)%10;
            ones = number % 10;



            Console.WriteLine(ones + "-" + tens + "-" + hundreds);

            sum = ones + tens + hundreds;

            Console.WriteLine(sum);


            #endregion
            Console.Read();
        }
    }
}
