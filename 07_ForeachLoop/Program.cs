using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //foreach (1;2;3;4)
            //1:Değişken Türü
            //2:Değişken Adı
            //3:In
            //4:Liste, Koleksiyon, Dizi

            //string[] cities = { "milono", "roma", "budapeşte", "ankara" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 3, 54, 83, 54, 55, 485,550 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            //int[] numbers = { 3, 54, 83, 54, 55, 485, 550 };

            //int total = 0;

            //foreach (int nbr in numbers)
            //{
            //    total += nbr;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";

            //foreach (char s in word)
            //{
            //    Console.WriteLine(s);
            //}


            #endregion


            #region Örnek Sınav Sorusu


            Console.Write("***** C# Eğitim Campı Uyg *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----------------------");

            Console.Write("Sınıfta Kaç Öğrenci var : ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");

            //Öğrenci İsim ve Not Ort. Saklayan Diziler
            string[] studentNames=new string[studentCount];
            double[] studentExamAvg=new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}.öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //her öğrenci için 3 sınav notu
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}.sınav notunu giriniz: ");
                    double valur=double.Parse(Console.ReadLine());
                    totalExamResult += valur;
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;

            }

            //Sınav Ortalaması

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //Geçip Kalam Durumu

                if (studentExamAvg[i]>=50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("-----------------------");
            }





            #endregion
            Console.Read();
        }
    }
}
