﻿using System.Threading.Channels;

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
            Console.WriteLine("\nWyświetlić ciąg Fibonacciego?");
            Console.ReadKey();

            // 0, 1, 1, 2, 3, 5, 8, 13, 21 

            int a = 0;
            int b = 1;
            int c;

            for (int i = a; i < 6; i++)
            {
                c = a + b;

                 a = b;
                b = c;

                Console.WriteLine($"{a} i {b} i {c}");
                //Console.WriteLine($"{c}");

                
            }



        }

    }
}
