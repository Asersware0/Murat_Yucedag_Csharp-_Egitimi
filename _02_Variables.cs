using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Char Değişkenler

            //char sembol = 'A';
            //Console.WriteLine(sembol);


            #endregion

            #region Klavyeden Veri Girişi String Değişkenler

            //Console.WriteLine("*****Aser Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine(); // klavyeden veri girişi

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC NO: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("------------------------------------------");

            //Console.WriteLine("Yolcu: " + passengerName + " " +  passengerSurname + " " + passengerDistrict  + " "+ passengerCity + " " + passengerAge + " " + passengerIdentityNumber);



            #endregion

            #region Klavyeden tam sayı girişi ve dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount,computerCount,chairCount,tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount  = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            ////parse komutu dönüşüm yapıyor

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());


            //int totalPrice = shoePrice * shoesCount + computerPrice * computerCount + chairCount * chairPrice + tvCount * tvPrice; 

            //Console.WriteLine("Toplam Fİyat: " + " " + totalPrice);
            #endregion




            #region Klavyeden Ondalıklı Sayı Girişi

            //double exam1, exam2, exam3, result;

            //Console.WriteLine("Lütfen 1. sınav sonucunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. sınav sonucunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 3. sınav sonucunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Ortalamanız: " + result);
            #endregion


            #region Klavyeden karakter girişi

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Cinsiyetiniz: " + gender);

             #endregion
            Console.Read();
        }
    }
}
