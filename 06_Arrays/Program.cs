using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] cities = new string[4];

            //cities[0] = "Ankara";
            //cities[1] = "Adana";
            //cities[2] = "Bursa";
            //cities[3] = "Aydın";

            //Console.WriteLine(cities[3]);

            //int[] numbers = new int[10];

            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[8] = 49;

            //Console.WriteLine(numbers[5]); //--> Böyle bir durumda çıktı 0'dır'.

            //string[] cities = { "Lyon", "Berlin", "Paris", "London" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Mavi", "Kırmızı", "Sarı", "Pembe", "Mor", "Yeşil", "Siyah", "Beyaz" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //        Console.WriteLine(numbers[i]);
            //}

            //char[] chars = { 'A', 'B', 'C', 'D', 'E', '*', '-', '(' };

            //for (int i = 0; i < chars.Length; i++)
            //{
            //    Console.WriteLine(chars[i]);
            //}

            //int[] numbers = { 1, 45, 67, 23, 15, 978, 34, 675, 3456, 75, 21, 8976, 35 };

            //int maxValue = numbers[0];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxValue)
            //    {
            //        maxValue = numbers[i];
            //    }
            //}
            //Console.WriteLine(maxValue);

            //string[] users = { "ali", "veli", "kazım", "burak", "tarık", "berke", "tayfun" };
            //Console.WriteLine(users.Length);

            //int[] numbers = { 1, 2, 45, 312, 56, 87, 31, 34, 21, 65, 8, 45, 743, 123, 34 };
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            //int[] numbers = { 1, 2, 45, 312, 56, 87, 31, 34, 21, 65, 8, 45, 743, 123, 34 };


            ////Diziyi komple tersten yazdırır
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotları

            //string[] personels = { "Ali", "hakan", "merve", "buse" };
            //int index = Array.IndexOf(personels, "buse");
            //Console.WriteLine(index);

            //int[] numbers = { 23, 34, 12, 767, 36, 867, 23, 23, 78, 48, 97, 46 };
            //Console.WriteLine("Dizinin en büyük sayısı: " + numbers.Max() + " Dizinin en küçük elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Diziye Değer Almak

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehrin ismini giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50, 60, 70 };
            //int summary = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    summary += numbers[i];
            //}
            //Console.WriteLine(summary);

            //int[] numbers = { 23, 546, 764, 1234, 98, 563, 146, 1234, 7879, 53, 1445, 87, 5654, 2342, 165, 98977, 452, 5768, 232, 123, 53421, 6438, 9785 };

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
