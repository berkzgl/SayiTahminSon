using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahminoyunu
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {


                int secim = 0;
                while (secim != -1)
                {

                    Console.WriteLine("Sayı tahmin oyununa hoşgeldiniz. \nBaşlamak için bir zorluk seçin: \n1-Kolay \n2-Orta \n3-Zor \nÇıkmak için '-1'");
                    secim = Convert.ToInt16(Console.ReadLine());
                    switch (secim)
                    {
                        case 1:
                            KolayTahmin();
                            break;
                        case 2:
                            OrtaTahmin();
                            break;
                        case 3:
                            ZorTahmin();
                            break;
                        case -1:
                            break;
                        default:
                            Console.WriteLine("Lütfen zorluğu doğru girdiğinizden emin olunuz, tekrar seçim yapınız");
                            break;

                    }
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Bilinmeyen hata oluştu.\nLütfen oyunu tekrar açıp doğru değerler giriniz.");
                throw;
            }


        }


        static void KolayTahmin()
        {

            #region kolay

            int rastgelesayi2 = new Random().Next(1, 10);
            Console.WriteLine("Kolay seviyesi için tahmin hakkınız:7 \n Başlamak için bir sayı giriniz.");



            int denemelimit2 = 7;
            int denemesayi2 = 0;

            while (true)
            {
                int tahmin2 = tahminal2();
                denemesayi2++;
                if (tahmin2 == rastgelesayi2)
                {
                    Console.WriteLine("Doğru tahmin!");
                    break;
                }

                if (tahmin2 > rastgelesayi2)
                {
                    Console.WriteLine("Tahmininiz çok fazla");
                }

                if (tahmin2 < rastgelesayi2)
                {
                    Console.WriteLine("Tahmininiz çok az");
                }

                if (denemesayi2 == denemelimit2)
                {
                    Console.WriteLine($"Tahmin hakkınız bitti.Doğru sayı: {rastgelesayi2}");
                    break;
                }

                Console.Write($" {denemelimit2 - denemesayi2}:Deneme sayınız kaldı.Lütfen başka bir sayı giriniz: ");
            }

            #endregion
        }

        static void OrtaTahmin()
        {
            #region orta

            int rastgelesayi1 = new Random().Next(1, 25);
            Console.WriteLine("Orta seviyesi için tahmin hakkınız:5 \n Başlamak için bir sayı giriniz.");

            int denemelimit1 = 5;
            int denemesayi1 = 0;

            while (true)
            {
                int tahmin1 = tahminal1();
                denemesayi1++;
                if (tahmin1 == rastgelesayi1)
                {
                    Console.WriteLine("Doğru tahmin!");
                    break;
                }

                if (tahmin1 > rastgelesayi1)
                {
                    Console.WriteLine("Tahmininiz çok fazla");
                }

                if (tahmin1 < rastgelesayi1)
                {
                    Console.WriteLine("Tahmininiz çok az");
                }

                if (denemesayi1 == denemelimit1)
                {
                    Console.WriteLine($"Tahmin hakkınız bitti.Doğru sayı: {rastgelesayi1}");
                    break;
                }

                Console.Write(
                    $" {denemelimit1 - denemesayi1}:Deneme sayınız kaldı.Lütfen başka bir sayı giriniz: ");
            }

            #endregion

        }

        static void ZorTahmin()
        {
            #region zor

            int rastgelesayi = new Random().Next(1, 50);
            Console.WriteLine("Zor seviyesi için tahmin hakkınız:3 \n Başlamak için bir sayı giriniz.");

            int denemelimit = 3;
            int denemesayi = 0;

            while (true)
            {
                int tahmin = tahminal();
                denemesayi++;
                if (tahmin == rastgelesayi)
                {
                    Console.WriteLine("Doğru tahmin!");
                    break;
                }

                if (tahmin > rastgelesayi)
                {
                    Console.WriteLine("Tahmininiz çok fazla");
                }

                if (tahmin < rastgelesayi)
                {
                    Console.WriteLine("Tahmininiz çok az");
                }

                if (denemesayi == denemelimit)
                {
                    Console.WriteLine($"Tahmin hakkınız bitti.Doğru sayı: {rastgelesayi}");
                    break;
                }

                Console.Write(
                    $" {denemelimit - denemesayi}:Deneme sayınız kaldı.Lütfen başka bir sayı giriniz: ");
            }

            #endregion

        }

        static int tahminal()
        {
            int tahmin = 0;
            try
            {
                tahmin = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Lütfen bir sayı giriniz.");
                tahmin = tahminal();
            }

            return tahmin;
        }

        static int tahminal1()
        {
            int tahmin1 = 0;
            try
            {
                tahmin1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Lütfen bir sayı giriniz.");
                tahmin1 = tahminal1();
            }

            return tahmin1;
        }

        static int tahminal2()
        {
            int tahmin2 = 0;
            try
            {
                tahmin2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Lütfen bir sayı giriniz.");
                tahmin2 = tahminal();
            }

            return tahmin2;
        }
    }
}
