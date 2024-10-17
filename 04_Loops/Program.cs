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

            //int i;

            //for (i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı Döngüler");
            //}

            //int i;

            //for (i = 1; i <= 53; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Yazının kaç kere yazılmasını istiyorsunuz: ");
            //int finalValue = int.Parse(Console.ReadLine());

            //for (int i = 0; i < finalValue; i++)
            //{
            //    Console.WriteLine("Bugün günlerden Perşembe");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for (int i = 0; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("------------");
            //Console.WriteLine(totalValue);

            //int count = 0;

            //for (int i = 0; i <= 70; i++)
            //{
            //    if (i % 9 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);

            //int bakteri = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bakteri *= 2;
            //    Console.WriteLine(i + ".Saatin Sonunda: " + bakteri);
            //}

            #endregion

            #region While Döngüsü

            //int i = 0;

            //while (i <= 10)
            //{
            //    Console.WriteLine("C# Eğitimi While Döngüsü");
            //    i++;
            //}

            //int i = 0;

            //while (i <= 45)
            //{
            //    if (i % 4 == 0)
            //        Console.WriteLine(i);
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 20)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu

            //Console.Write("3 Basamaklı bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int ones, tens, hundreds, summary;

            //ones = number % 10;
            //tens = (number % 100) / 10;  -> 100'e bölümünden kalan sayının 10'a bölümü
            //hundreds = number / 100;
            //summary = hundreds + tens + ones;

            //Console.WriteLine(hundreds + " - " + tens + " - " + ones);
            //Console.WriteLine("----------------");
            //Console.WriteLine(summary);

            #endregion


            Console.Read();
        }
    }
}
