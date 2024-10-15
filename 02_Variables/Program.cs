using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler

            //double applePrice, orangePrice, onionPrice, tomatoPrice, potatoPrice;

            //applePrice = 12.50;
            //orangePrice = 6.45;
            //onionPrice = 4.95;
            //tomatoPrice = 9.65;
            //potatoPrice = 5.95;

            //Console.WriteLine("-----* Fiyat Listesi *-----");
            //Console.WriteLine();
            //Console.WriteLine("Elmanın Kilogram Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("Portakalın Kilogram Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("Soğanın Kilogram Fiyatı: " + onionPrice + " TL");
            //Console.WriteLine("Domatesin Kilogram Fiyatı: " + tomatoPrice + " TL");
            //Console.WriteLine("Patatesin Kilogram Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine();

            //double appleGram, orangeGram, onionGram, tomatoGram, potatoGram;

            //appleGram = 3.54;
            //orangeGram = 2.26;
            //onionGram = 6.85;
            //tomatoGram = 4.34;
            //potatoGram = 2.21;

            //double appleTotalPrice, orangeTotalPrice, onionTotalPrice, tomatoTotalPrice, potatoTotalPrice;

            //appleTotalPrice = appleGram * applePrice;
            //orangeTotalPrice = orangeGram * orangePrice;
            //onionTotalPrice = onionGram * onionPrice;
            //tomatoTotalPrice = tomatoGram * tomatoPrice;
            //potatoTotalPrice = potatoGram * potatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma " + "- Birim Fiyatı: " + applePrice + " - Tartılan Ağırlık: " + appleGram + " - Genel Toplam: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal " + "- Birim Fiyatı: " + orangePrice + " - Tartılan Ağırlık: " + orangeGram + " - Genel Toplam: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Soğan " + "- Birim Fiyatı: " + onionPrice + " - Tartılan Ağırlık: " + onionGram + " - Genel Toplam: " + onionTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates " + "- Birim Fiyatı: " + tomatoPrice + " - Tartılan Ağırlık: " + tomatoGram + " - Genel Toplam: " + tomatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates " + "- Birim Fiyatı: " + potatoPrice + " - Tartılan Ağırlık: " + potatoGram + " - Genel Toplam: " + potatoTotalPrice);
            //Console.WriteLine();

            //double shoppingTotalCost = appleTotalPrice + orangeTotalPrice + onionTotalPrice + tomatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("Alışverişin Toplam Tutarı: " + shoppingTotalCost + " TL");

            #endregion

            #region Char Değişkenler

            //ABCDEFG...
            //DEF...
            // DERS SAAT 18.00'DA
            // Char değişkenler ' ile tanımlanır.

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri - String

            //string passengerName, passengerSurname, passengerGender, passengerAge, passengerIdentityNumber, passengerDistrict, passengerCity;

            //Console.WriteLine("-----* C# Hava Yolları Yolcu Bilgileri *-----");
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Yolcu Cinsiyeti: ");
            //passengerGender = Console.ReadLine();
            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.Write("Yolcu İlçesi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Yolcu Şehri: ");
            //passengerCity = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("---------------------");
            //Console.WriteLine();
            //Console.WriteLine("Yolcu Kimlik Numarası: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " - Yolcunun Cinsiyeti ve Yaşı: "
            //    + passengerGender + " " + passengerAge + " - Yolcunun Şehir ve İlçesi: " + passengerCity + "/" + passengerDistrict);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int computerPrice, chairPrice, deskPrice, keyboardPrice, mousePrice;

            //computerPrice = 5000;
            //chairPrice = 2000;
            //deskPrice = 1500;
            //keyboardPrice = 500;
            //mousePrice = 250;

            //int computerCount, chairCount, deskCount, keyboardCount, mouseCount;

            //Console.WriteLine("-----* Ofis Eşya Atölyesi *-----");
            //Console.WriteLine();
            //Console.Write("Satın Alınan Bilgisayar Sayısını Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Satın Alınan Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Satın Alınan Masa Sayısını Giriniz: ");
            //deskCount = int.Parse(Console.ReadLine());
            //Console.Write("Satın Alınan Klavye Sayısını Giriniz: ");
            //keyboardCount = int.Parse(Console.ReadLine());
            //Console.Write("Satın Alınan Mouse Sayısını Giriniz: ");
            //mouseCount = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");

            //int totalPrice = chairCount * computerPrice + chairCount * chairPrice + deskCount * deskPrice + keyboardCount * keyboardPrice + mouseCount * mousePrice;

            //Console.WriteLine("Ödenecek Toplam Tutar: " + totalPrice + " TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.WriteLine("-----* 3 Sınavın Ortalaması *-----");
            //Console.Write("1.Sınav Notu: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("2.Sınav Notu: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("3.Sınav Notu: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Not Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter İşlemleri

            // Char değişkenler yalnızca tek karakter değer alabilir.

            //char gender;

            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Cinsiyetiniz: " + gender);

            #endregion

            Console.Read();
        }
    }
}
