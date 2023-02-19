namespace Zadania_petle_tydzien_2_lekcja_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    // 1. Zadanie - liczby pierwsze w zakresie od 0 do 100
            //    Console.WriteLine("Zadanie liczby pierwsze w zakresie od 0 do 100.");
            //    Console.WriteLine("Podaj zakres liczb do sprawdzenia");

            //    Console.WriteLine("Podaj pierwszą liczbę: ");
            //    int i1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Podaj drugą liczbę: ");
            //    int i2 = int.Parse(Console.ReadLine());

            //    int counters = 0;

            //    for (int i = i1; i <= i2; i++)
            //    {
            //        int liczba = i;

            //        if (CzyPierwsza(liczba))
            //        {
            //            Console.WriteLine($"* {liczba} jest liczbą pierwszą");
            //            counters++;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{liczba} NIE jest liczbą pierwszą");
            //        }
            //    }
            //    Console.WriteLine($"W podanym przedziale od {i1} do {i2} liczb pierwszych jest: {counters}");
            //}
            //static bool CzyPierwsza(int n)
            //{
            //    if (n <= 0)
            //    {
            //        return false;
            //    }
            //    else if (n == 1)
            //    {
            //        return false;
            //    }

            //    for (int i = 2; i < n; i++)
            //    {
            //        if (n % i == 0)
            //        {
            //            return false;
            //        }
            //    }
            //    return true;

            // 2. Za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000

            Console.WriteLine("Znajdowanie wszystkie liczby parzyste z zakresu 0 – 1000.");
            Console.WriteLine("Podaj zakres liczb do sprawdzenia");

            Console.WriteLine("Podaj pierwszą liczbę: ");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int b2 = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("a2");
                if (a2 % 2 == 0)
                {
                    Console.WriteLine($"{a2} jest liczbą parzystą"); 
                }
                else
                {
                    Console.WriteLine($"{a2} Nie jest parzysta");
                }

            }
            while (a2 <= b2);


        }
    }
}