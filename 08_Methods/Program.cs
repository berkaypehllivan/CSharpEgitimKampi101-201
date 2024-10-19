using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //Geriye değer döndürmeyen metotlar void ile oluşturulur. Programlamada bu metotlar kod tekrarının önlenmesinde ve okunabilirliği artırmasından dolayı önemlidir.

            //void UserList()
            //{
            //    Console.WriteLine("Tarık Akın");
            //    Console.WriteLine("Faruk Akrep");
            //    Console.WriteLine("Ziya Havuçgil");
            //    Console.WriteLine("Güney Sarı");
            //    Console.WriteLine("Jale Özcan");
            //}

            //UserList();
            //UserList();
            //UserList();
            //UserList();

            //void Summary()
            //{
            //    int x = 2;
            //    int y = 7;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Summary();




            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string name)
            //{
            //    Console.WriteLine(name);
            //}

            //WriteMethod("Hakan Güçlüer");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //CustomerCard("Mehmet", "Ekinci");
            //CustomerCard("Mahmut", "Akar");
            //CustomerCard("Mithat", "Yaşaroğlu");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Summary(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 * number3;
            //    Console.WriteLine(result);
            //}

            //Summary(456, 7, 34);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return name + " " + surname;
            //}

            //Console.Write(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string name, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülkenin adı: " + name + " - Başkenti: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülkenin Adını Giriniz: ");
            //x = Console.ReadLine();
            //Console.Write("Başkentinin Adını Giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Summary(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Summary(45, 54));
            //Console.WriteLine(Summary(475, 786));
            //Console.WriteLine(Summary(4234, 14));
            //Console.WriteLine(Summary(1674, 25));
            //Console.WriteLine(Summary(3, 5425));
            //Console.WriteLine(Summary(7569, 5344));

            #endregion

            #region Örnek Uygulama

            //string ExamAverageCalculator(string _studentName, int _exam1, int _exam2, int _exam3)
            //{
            //    int result = (_exam1 + _exam2 + _exam3) / 3;

            //    if (result <= 50)
            //    {
            //        return _studentName + " isimli öğrenci dersten kaldı. Ortalaması: " + result;
            //    }
            //    else
            //        return _studentName + " isimli öğrenci dersten geçti. Ortalaması: " + result;
            //}

            //int exam1, exam2, exam3;
            //string studentName;

            //Console.Write("Öğrenci adını giriniz: ");
            //studentName = Console.ReadLine();

            //Console.Write("1.Sınav Notunu Giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sınav Notunu Giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3.Sınav Notunu Giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //Console.WriteLine(ExamAverageCalculator(studentName, exam1, exam2, exam3));

            #endregion

            Console.Read();
        }
    }
}
