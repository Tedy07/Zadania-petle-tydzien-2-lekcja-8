﻿namespace Zadania_petle_tydzien_2_lekcja_8
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Liczby pierwsze w zakresie od 0 do 100.");
            Console.WriteLine("Podaj zakres liczb do sprawdzenia");

            Console.WriteLine("Podaj pierwszą liczbę: ");
            int i1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int i2 = int.Parse(Console.ReadLine());

            int counters = 0;
            //licznik

            for (int i = i1; i <= i2; i++)
            {
                int liczba = i;
               
                if (CzyPierwsza(liczba))
                {
                    Console.WriteLine($"TAK {liczba} jest liczbą pierwszą");
                    counters++;
                    Console.WriteLine($"Licznik: {counters}");
                }
                else
                {
                    Console.WriteLine($"{liczba} NIE jest liczbą pierwszą");
                }

            

                //if (i1 % i1 == 0 &&  )
                //{
                //    Console.WriteLine($"Reszta z dzielenia cyfry {i1} == 0 ");
                //} else
                //{
                //    Console.WriteLine("W przeciwnym razie");
                //}
            }


            Console.WriteLine($"W podanym przedziale od {i1} do {i2} liczb pierwszych jest: {counters} ");
        }

        static bool CzyPierwsza(int n)  
        {
            if (n == 1)
            {
                return false;
            }


            for (int i = 2; i < n; i++)
            {
                if (n%i == 0) 
                {  
                    return false;
                }

            }
             
            return true;
        }

    }
}