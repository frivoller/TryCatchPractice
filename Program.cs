using System;

namespace TryCatchOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı giriniz: ");

            try
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                int karesi = sayi * sayi;
                Console.WriteLine("Girdiğiniz sayının karesi: " + karesi);
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
            }

            Console.WriteLine("Çıkış için bir tuşa basınız...");
            Console.ReadKey();
        }
    }
}
