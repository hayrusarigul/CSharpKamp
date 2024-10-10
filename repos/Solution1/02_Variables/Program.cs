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
            ////double number;
            ////number = 4.85;
            ////Console.WriteLine(number);

            //Console.WriteLine("*********** Fiyat Listesi *************");

            //double applePrice, orangePrice, strawberryPrice, potato, tomato;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potato = 9.74;
            //tomato = 6.88;

            //Console.WriteLine("------- Elma Fiyatı: " + applePrice);
            //Console.WriteLine( "------ Portakal Fiyatı: " + orangePrice);
            //Console.WriteLine( "-------- Çilek Fiyatı: " + strawberryPrice);
            //Console.WriteLine("--------Patates Fiyatı: " + potato);
            //Console.WriteLine("-------- Domates Fiyatı: " + tomato);

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 6.88;

            //double appleTotalPrice = appleGram * applePrice;
            //Console.WriteLine( "Elmanın toplam fiyatı: "+appleTotalPrice);

            //double orangeTotalPrice = orangeGram * orangePrice;
            //Console.WriteLine("Portakal toplam fiyatı: " + orangeTotalPrice);

            //double tomatoTotalPrice = tomatoGram * tomato;
            //Console.WriteLine("Domates toplam fiyatı: " + tomatoTotalPrice);

            //double potatoTotalPrice = potatoGram * potato;
            //Console.WriteLine("Patates toplam fiyatı: " + potatoTotalPrice);

            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //Console.WriteLine("Çileğin toplam fiyatı: " + strawberryTotalPrice);

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alşveriş toplamı: " + (strawberryTotalPrice + appleTotalPrice + orangeTotalPrice + tomatoTotalPrice + potatoTotalPrice));
            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00' DE
            // " '
            //char symbol;
            //symbol = 'a';



            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("********** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,
            //    passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC'si: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Yolcu TC'si: " + passengerIdentityNumber + "Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " +
            //    passengerDistrict + " / " + passengerCity + " " + passengerAge);



            #endregion

            #region Klavyeden Tam Sayı Girişleri

            ////ABC12D

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice =20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount =  int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoePrice + computerCount * computerPrice + chairCount*chairPrice + tvCount* tvPrice;

            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı Girişleri

            //double exam1, exam2, exam3, result;

            //Console.WriteLine("Lütfen 1. sınav notunuzu girin: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. sınav notunuzu girin: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 3. sınav notunuzu girin: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri
            //char gender;

            //Console.WriteLine("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);




#endregion

            Console.Read();
        }
    }
}
