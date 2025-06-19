using System;

namespace BilgiYarismasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int trueCounter = 0;

            Console.WriteLine("Hoş geldiniz! İsminiz nedir?");
            string? name = Console.ReadLine();

            // 1. Soru
            Console.WriteLine("\n1 -> Kızınca tüküren hayvan hangisidir?");
            Console.WriteLine("a) Lama\nb) Deve");
            Console.Write("Cevabınız: ");
            string? answer1 = Console.ReadLine()?.ToLower();

            if (answer1 == "a")
            {
                Console.WriteLine("Doğru cevap!");
                trueCounter++;
            }
            else
            {
                Console.WriteLine("Yanlış cevap!");
            }

            // 2. Soru
            Console.WriteLine("\n2 -> Dünya'ya en yakın gezegen hangisidir?");
            Console.WriteLine("a) Venüs\nb) Mars");
            Console.Write("Cevabınız: ");
            string? answer2 = Console.ReadLine()?.ToLower();

            if (answer2 == "a")
            {
                Console.WriteLine("Doğru cevap!");
                trueCounter++;
            }
            else
            {
                Console.WriteLine("Yanlış cevap!");
            }

            // Eğer ilk 2 sorudan sonra 2 doğru yapılmadıysa 3. soruya geç
            if (trueCounter < 2)
            {
                Console.WriteLine("\n3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?");
                Console.WriteLine("a) 7\nb) 12");
                Console.Write("Cevabınız: ");
                string? answer3 = Console.ReadLine()?.ToLower();

                if (answer3 == "b")
                {
                    Console.WriteLine("Doğru cevap!");
                    trueCounter++;
                }
                else
                {
                    Console.WriteLine("Yanlış cevap!");
                }
            }
            else
            {
                Console.WriteLine("\nİlk iki sorudan 2 doğru cevap verdiniz. 3. soruya gerek kalmadı!");
            }

            // Sonuç değerlendirme
            Console.WriteLine("\n----------------------------");
            if (trueCounter >= 2)
            {
                Console.WriteLine($"Tebrikler {name}! {trueCounter} doğru cevap verdiniz ve 1 Milyon TL kazandınız!");
            }
            else
            {
                Console.WriteLine($"Maalesef, sadece {trueCounter} doğru cevap verdiniz. Büyük ödülü kazanamadınız.");
            }

            Console.WriteLine("\nYarışmaya katıldığınız için teşekkürler!");
            Console.ReadKey();
        }
    }
}
