using System;

namespace RuyaManavSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hangi meyveyi almak istiyorsunuz? (elma, armut, çilek, muz, diğer): ");
            string? fruit = Console.ReadLine()?.ToLower(); // Harf duyarlılığı giderildi

            int price;

            switch (fruit)
            {
                case "elma":
                    price = 2;
                    break;
                case "armut":
                    price = 3;
                    break;
                case "çilek":
                    price = 2;
                    break;
                case "muz":
                    price = 3;
                    break;
                default:
                    price = 4;
                    break;
            }

            Console.WriteLine($"Seçtiğiniz meyve: {fruit} - fiyat: {price} TL");

            /*
                Bu tür bir senaryoda switch-case kullanmak daha uygun olur.

                Çünkü:
                - Değişkenin farklı sabit değerlere göre kontrolü isteniyor.
                - switch-case yapısı bu tür sabit karşılaştırmalarda daha temiz, okunaklı ve performanslıdır.
                - Yeni meyve eklemek çok daha kolaydır.

                if-else yapısı daha çok koşullar ve daha karmaşık mantıklar için tercih edilmelidir.
            */

        }
    }
}

