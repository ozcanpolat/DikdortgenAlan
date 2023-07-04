using System;

namespace DikdortgenAlan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kısa ve uzun kenarı girilen dikdörtgenin alan ve çevresini hesaplayınız. 

            Console.Write("Kısa kenarı girin : ");
            int kenar1 = int.Parse(Console.ReadLine());

            Console.Write("Uzun kenarı girin : ");
            int kenar2 = int.Parse(Console.ReadLine());

            int alan = kenar1 * kenar2;
            int cevre = 2 * (kenar1 + kenar2);

            Console.WriteLine("Dikdörtgenin Alanı :" + alan);
            Console.WriteLine("Dikdörtgenin Çevresi :" + cevre);


        }
    }
}
