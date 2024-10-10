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
            #region if else
            //Console.WriteLine("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış.");
            //}

            //string capital, country;
            //Console.WriteLine("Başkenti giriniz: ");
            //capital = Console.ReadLine();
            //Console.WriteLine("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if( capital ==  "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("bilgiler doğru");
            //}
            //else
            //{

            //    Console.WriteLine("hatalı bilgi");
            //}


            #endregion else

            #region mod işlemleri

            //int number;
            //number = 26;
            //int sonuc = number % 5;
            //Console.WriteLine(sonuc);

            //Console.WriteLine("Lütfen 1. sayıyı girin: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen 2. sayıyı girin: ");
            //int number2 = int.Parse(Console.ReadLine());
            //int sonuc = number1 % number2;
            //Console.WriteLine(sonuc);

            //char team;
            //Console.WriteLine("Lütfen takım sembolünü giriniz: ");
            // team = char.Parse(Console.ReadLine());




            #endregion

            #region switch case

            Console.WriteLine("Lütfen ay girişi yapını: ");
            int monthNumber = int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak");
            //        break;
            //        case 2: Console.WriteLine("Şubat");
            //        break;
            //        case 3: Console.WriteLine("Mart");
            //        break;
            //        case 4: Console.WriteLine("Nisan");
            //        break;
            //        case 5: Console.WriteLine("Mayıs");
            //        break;
            //        case 6: Console.WriteLine("Haziran");
            //        break;
            //        case 7: Console.WriteLine("Temmuz");
            //        break;
            //        case 8: Console.WriteLine("Ağustos");
            //        break;
            //        case 9: Console.WriteLine("Eylül");
            //        break;
            //        case 10: Console.WriteLine("Ekim");
            //        break;
            //        case 11: Console.WriteLine("Kasım");
            //        break;
            //        case 12: Console.WriteLine("Aralık");
            //        break;
            //    default: Console.WriteLine("Hatalı veri girişi");
            //        break;
            //}




            #endregion 




            Console.Read();
        }
    }
}
