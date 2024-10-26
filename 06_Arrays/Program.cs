using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Length : Uzunluk Verir
            //Array.Sort(Dizi_Adi)   : Sıralar = Küçükten, Büyüğe 



            #region Temel Diziler

            //Değişken_Türü [] Dizi_Adi=new Değişken_Türü[  Eleman_Sayisi  ]

            //string[] cities = new string[5];
            //cities[0] = "istanbul";
            //cities[1] = "sakarya";
            //cities[2] = "ankara";
            //cities[3] = "izmir";
            //cities[4] = "bursa";

            //Console.WriteLine(cities[4]);


            //for (int i = 0; i <cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //string[] metropolis = { "Prag", "Budapeşte", "Ankara", "Bakü" };

            //Console.WriteLine(metropolis.Length);
            //Console.WriteLine(metropolis[2]);

            #endregion

            #region Genel Örnek 

            //char[] symbols = { 'a', 'b', 'c','-','+','*', '/' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] myArray = { 47, 51, 58, 150, 25, 210, 350, 275, 662 };

            //int maxNumber=myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber=myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);



            //int[] numbers = { 47, 51, 10, 15, 85, 40, 90};

            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion

            #region Dizi Metodları


            //string[] customers = { "ali", "mehmet", "hasan", "hüseyin", "selin" };

            //int index = Array.IndexOf(customers, "hüseyin");
            //Console.WriteLine(index);


            //int[] numbers = { 47, 51, 58, 150, 25, 210, 350, 275, 662 };
            //Console.WriteLine("Dizinin En Büyük Sayısı : "+ numbers.Max() + "   En Küçük Sayısı : " + numbers.Min());


            #endregion


            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz : ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-----------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7,8,9};


            Console.WriteLine("Çift Sayılar");
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }


            #endregion

            Console.Read();
        }
    }
}
