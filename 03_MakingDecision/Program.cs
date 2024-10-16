using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "12345")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;

            //Console.Write("Ülkeyi Giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Başkenti Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "Ankara" & country == "Türkiye")
            //{
            //    Console.WriteLine("Girilen Bilgiler Doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen Bilgiler Yanlış.");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata";

            //Console.Write("1.Sınav Notu: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("2.Sınav Notu: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("3.Sınav Notu: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine(average);

            //if (average > 0 & average < 44)
            //{
            //    result = "Not ortalamanız vasat";
            //}
            //if (average > 45 & average < 74)
            //{
            //    result = "Not ortalamanız orta";
            //}
            //if (average > 75 & average < 84)
            //{
            //    result = "Not ortalamanız iyi";
            //}
            //if (average > 85)
            //{
            //    result = "Not ortalamanız çok iyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen Şehir Bilgisi Giriniz: ");
            //city = Console.ReadLine();

            //if (city == "Bursa" | city == "Ankara" | city == "Manisa")
            //{
            //    Console.WriteLine("Şehir Bilgisi Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Bilgisi Yanlış");
            //}

            //Console.Write("Kullanıcı Adınızı Girin: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Hatalı Kullanıcı Adı Girişi");
            //}
            //else
            //{
            //    Console.WriteLine("Doğru Kullanıcı Adı Girişi");
            //}



            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //int number1, number2, result;
            //Console.Write("Lütfen 1.sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //result = number1 % number2;
            //Console.WriteLine("1.sayının 2.sayıya bölümünden kalan: " + result);

            //Console.Write("Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tektir");
            //}

            #endregion

            #region Char Değişkenleri İle Karar Yapıları

            //string result = "Hatalı giriş";
            //char team;
            //Console.Write("Lütfen Takımınızın Sembolünü Giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'a' | team == 'A')
            //{
            //    result = "Adana Spor";
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    result = "Balıkesir Spor";
            //}
            //if (team == 'c' | team == 'C')
            //{
            //    result = "Cancık Spor";
            //}
            //if (team == 'd' | team == 'D')
            //{
            //    result = "Denizli Spor";
            //}

            //Console.Write(result);

            #endregion

            #region Örnek Uygulama

            //Console.WriteLine("-----* C# Kursu Örnek Uygulama *-----");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("-----* Çorbalar *-----");
            //Console.WriteLine("-----* Yemekler *-----");
            //Console.WriteLine("-----* İçecekler *-----");
            //Console.WriteLine("-----* Tatlılar *-----");
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine();
            //Console.Write("Detaylarını Görmek İstediğiniz Menüyü Seçiniz: ");
            //string menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine("-----* Çorbalar *-----");
            //    Console.WriteLine();
            //    Console.WriteLine("Mercimek Çorbası");
            //    Console.WriteLine("Tarhana Çorbası");
            //    Console.WriteLine("Ezogelin Çorbası");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine("-----* Yemekler *-----");
            //    Console.WriteLine();
            //    Console.WriteLine("İskender");
            //    Console.WriteLine("Kasap Köfte");
            //    Console.WriteLine("Tavuklu Pilav");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine("-----* İçecekler *-----");
            //    Console.WriteLine();
            //    Console.WriteLine("Kola");
            //    Console.WriteLine("Ayran");
            //    Console.WriteLine("Su");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine("-----* Tatlılar *-----");
            //    Console.WriteLine();
            //    Console.WriteLine("Sütlaç");
            //    Console.WriteLine("Kazandibi");
            //    Console.WriteLine("Hoşmerim");
            //}

            #endregion

            #region Switch Case

            //string result;
            //Console.WriteLine("bir sayi giriniz");
            //int mounthNumber = int.Parse(Console.ReadLine());

            //switch (mounthNumber)
            //{
            //    case 1: result = "Ocak"; break;
            //    case 2: result = "Şubat"; break;
            //    case 3: result = "Mart"; break;
            //    case 4: result = "Nisan"; break;
            //    case 5: result = "Mayıs"; break;
            //    case 6: result = "Haziran"; break;
            //    case 7: result = "Temmuz"; break;
            //    case 8: result = "Ağustos"; break;
            //    case 9: result = "Eylül"; break;
            //    case 10: result = "Ekim"; break;
            //    case 11: result = "Kasım"; break;
            //    case 12: result = "Aralık"; break;
            //    default: result = "Hatalı Veri Girişi"; break;
            //}

            //Console.WriteLine(result);

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("2.sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write("Yapılacak işlemin sembolünü giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':

            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //}

            #endregion

            Console.Read();
        }
    }
}
