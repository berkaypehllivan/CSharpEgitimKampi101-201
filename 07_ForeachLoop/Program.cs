using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string[] users = { "ali", "kerim", "melike", "soner", "uğur", "busenur" };
            //foreach (string user in users)
            //{
            //    Console.WriteLine(user);
            //}

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,6,8,6,21,65,367,23,1254,76
            //};

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //        Console.WriteLine(number);
            //}

            //string word = "Muvaffakiyetsizleştiricileştiriveremeyebileceklerimizdenmişsinizcesine";

            //foreach (char i in word)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("-----* C# Eğitim Kampı Sınav Sistemi Uygulaması *-----");
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını alma işlemleri
            Console.WriteLine("------------------");
            Console.Write("Sınıfınızda kaç öğrenci bulunuyor: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------");

            //Öğrencilerin isimlerini ve not ortalamalarını tutacak olan diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAverage = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                Console.WriteLine();

                studentExamAverage[i] = totalExamResult / 3;
            }

            //Sınav Ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} isimli öğrencinin not ortalaması: {studentExamAverage[i]}");

                if (studentExamAverage[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi başarıyla geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten kaldı.");
                }

                Console.WriteLine("------------------------------------------------------");
            }

            #endregion

            Console.Read();
        }
    }
}
