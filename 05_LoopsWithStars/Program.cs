﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 Yıldız


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion


            #region Yana Yana 10 tane Yıldız

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}


            #endregion

            #region Dik Üçgen 

            //for (int i = 1; i <= 7; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region  Ters Üçgen


            //for (int i = 7; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion 

            #region Dik Üçgen + Ters Dik Üçgen


            //for (int i = 0; i <=7; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 6; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava Dilimi


            int n = 5;

            for (int i = 1; i <=n; i++)
            {
                for (int j = n - 1; j > 0; j--)
                {
                    Console.Write(" ");

                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = n - 1; j > 0; j--)
                {
                    Console.Write(' ');
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                   Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            #region Ters Pramit

            //int n = 5;

            //for (int i = n; i >= 1; i--)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");

            //    }

            //    for (int k = 1; k <= 2 * i- 1 ; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion



            Console.Read();
        }
    }
}
