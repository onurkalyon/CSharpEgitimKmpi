using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //YAZDIRMAKOMUTLARI

            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");

            //Console.WriteLine("****** YEMEK KATEGORİLERİ ******");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Yemekler");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("****** YEMEK KATEGORİLERİ ******");
            //Console.WriteLine();


            //STRİNGDEĞİŞKENLER

            //String name;
            // name= "Onur";
            //Console.Write(name);

            //String customerName;
            //String customerSurname;
            //String customerEmail;
            //String customerPhone, district, city;

            //customerName = "Onur";
            //customerSurname = "Kalyon";
            //customerEmail = "denem@gmail.com";
            //customerPhone = "+90 500 400 30 20";
            //district = "Beşiktaş";
            //city = "İstanbul";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Müşteri:"+customerName+" "+customerSurname);
            //Console.WriteLine("İletişim:"+ customerPhone);
            //Console.WriteLine("Email Adresi:"+customerEmail);
            //Console.WriteLine("Adres:"+district+"/"+city);
            //Console.WriteLine("------------------------------");
            //Console.WriteLine();
            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerEmail = "test@gmail.com";
            //customerPhone = "+90 500 400 30 80";
            //district = "Kadıköy";
            //city = "İstanbul";
            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("------------------------------");

            //İNTDEĞİŞKENLER

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger:" + hamburgerPrice);
            Console.WriteLine("-----Pizza:" + pizzaPrice);
            Console.WriteLine("-----Kola:"+cokePrice);
            Console.WriteLine("-----Limonata:" + lemonadePrice);
            Console.WriteLine("-----Kızartma:" + friesPrice);
            Console.WriteLine("-----Su:"+waterPrice);
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");


            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaCount = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice= cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice= friesCount * friesPrice;
            totalPizzaCount=pizzaCount * pizzaPrice;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Hamburger Tutarı:"+totalHamburgerPrice);
            Console.WriteLine("Pizza Tutarı:"+ totalPizzaCount);
            Console.WriteLine("Kızartma Tutarı:"+totalFriesPrice);
            Console.WriteLine("Kola Tutarı:"+ totalCokePrice);
            Console.WriteLine("Limonata Tutarı:"+totalLemonadePrice);
            Console.WriteLine("Su Tutarı:"+totalWaterPrice);
            Console.WriteLine();

            int totalPrice = totalHamburgerPrice+ totalCokePrice+ totalWaterPrice+ totalFriesPrice+ totalPizzaCount;
            Console.WriteLine("Toplam Ödenecek Tutar:"+totalPrice);






            Console.Read();
        }
    }
}
