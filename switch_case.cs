using System;

namespace RuyaManavSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hangi meyveyi almak istiyorsunuz? (elma, armut, çilek, muz, diğer): ");
            string? meyve = Console.ReadLine()?.ToLower(); // Harf duyarlılığı giderildi

            int fiyat;

            switch (meyve)
            {
                case "elma":
                    fiyat = 2;
                    break;
                case "armut":
                    fiyat = 3;
                    break;
                case "çilek":
                    fiyat = 2;
                    break;
                case "muz":
                    fiyat = 3;
                    break;
                default:
                    fiyat = 4;
                    break;
            }

            Console.WriteLine($"Seçtiğiniz meyve: {meyve} - Fiyat: {fiyat} TL");
        }
    }
}
