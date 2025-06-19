using System;

namespace SayiKontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan sayı al
            Console.Write("Bir sayı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // sayının 10'dan küçük, eşit veya büyük olduğunu kontrol et
            if (number < 10)
            {
                Console.WriteLine("Girilen sayı 10'dan küçüktür.");
            }
            else if (number == 10)
            {
                Console.WriteLine("Girilen sayı 10'a eşittir.");
            }
            else
            {
                Console.WriteLine("Girilen sayı 10'dan büyüktür.");
            }

            // ve sayının çift veya tek olduğunu kontrol et
            if (number % 2 == 0)
            {
                Console.WriteLine("Girilen sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Girilen sayı tektir.");
            }

            Console.ReadKey();
        }
    }
}
