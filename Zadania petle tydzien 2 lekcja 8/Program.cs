using System.Threading.Channels;

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

            //// 2. Za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000
            //Console.WriteLine("Znajdowanie wszystkich liczb parzystych w podanym zakresie.");
            //Console.WriteLine("Podaj zakres liczb do sprawdzenia");

            //Console.WriteLine("Podaj pierwszą liczbę: ");
            //int a2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj drugą liczbę: ");
            //int b2 = int.Parse(Console.ReadLine());

            //int counters2 = 0;
            //int liczba = a2;

            //do
            //{
            //    if (liczba % 2 == 0)
            //    {
            //        Console.WriteLine($"{liczba++} jest liczbą parzystą, razem liczb parzystych jest {++counters2}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{liczba++} jest liczbą nieparzystą");
            //    }
            //} while (liczba <= b2);

            //Console.WriteLine($"W podanym zakresie liczb parzystych jest: {counters2}.");

            ////dodatkowo zadanie 2 w pętli for 
            //Console.WriteLine("\nDodatkowe zadanie 2 w pętli for ");
            //Console.WriteLine("Znajdowanie wszystkich liczb parzystych w podanym zakresie.\n");

            //int counters2a = 0;
            //int liczba2a = a2;

            //for (int i = liczba2a; i <= b2; i++)
            //{
            //    if (liczba2a % 2 == 0)
            //    {
            //        Console.WriteLine($"{liczba2a++} jest liczbą parzystą, razem liczb parzystych jest {++counters2a}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{liczba2a++} jest liczbą nieparzystą");
            //    }
            //}
            //Console.WriteLine($"W podanym zakresie liczb parzystych jest {counters2a}.");


            //// 3. Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.
            //Console.WriteLine("\nWyświetlić ciąg Fibonacciego?");
            //Console.ReadKey();

            //int a = 0;
            //int b = 1;
            //int c;

            //Console.WriteLine($"\n{a}");
            //Console.WriteLine(b);

            //for (int i = a; i <= 42; i++)
            //{
            //    c = a + b;
            //    a = b;
            //    b = c;
            //    Console.WriteLine($"{c}");
            //}
            //// 4. Program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej.
            //Console.WriteLine("Program, który po podaniu liczby całkowitej wyświetli piramidę liczb.");

            //Console.WriteLine("Podaj liczbę całkowitą.");
            //int a4 = int.Parse(Console.ReadLine());
            //int number4 = 0;    

            //for (int i = 0; i < a4; i++)
            //{
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        Console.Write(++number4);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //// 5. Program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.
            //Console.WriteLine("Program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.");

            //for (int i = 1; i <= 20; i++)
            //{
            //    double result = Math.Pow(i, 3);
            //    Console.WriteLine($" Liczba {i} do 3 to {result},");
            //}

            // 6. Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:.
            Console.WriteLine("Program, który dla liczb od 0 do 20 obliczy sumę wg wzoru.");








        }
    }
}
