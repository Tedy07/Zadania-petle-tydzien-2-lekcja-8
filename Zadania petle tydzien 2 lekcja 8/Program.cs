using System.Linq;
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

            //// 6. Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:.
            //Console.WriteLine("Program, który dla liczb od 0 do 20 obliczy sumę wg wzoru: 1 + 1⁄2 + 1/3 + 1⁄4 itd...");

            //double result;
            //double result2 = 0;
            //int n = 20;

            //for (double i = 1; i < n; i++)
            //{
            //    result = 1 / i;
            //    result2 = result2 + result;
            // }

            //Console.WriteLine($"Wynik dodawania kolejnych liczb to: {result2}");

            //// 7. Napisz program, który Napisz program, narysuje diament o krótszej przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:.
            //Console.WriteLine("Program narysuje diament, podaj długość krótszej przekątnej");
            //int a7 = int.Parse(Console.ReadLine());

            //for (int i = 0; i < a7; i++)    // odpowiedzialna za linie
            //{
            //    for (int j = i; j < a7; j++)  // wstawia biały znak, pusty
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k < i; k++)     //odpowiedzialny za rysowanie z lewej strony
            //    {
            //        Console.Write("*");
            //    }
            //    for (int f = 0; f <= i; f++)        //odpowiedzialny za rysowaniez prawej strony

            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i <= a7; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = i; k < a7; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    for (int f = i; f <= a7; f++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// 8. Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np. Testowe dane: Abcdefg Rezultat Gfedcba.
            //Console.WriteLine("Program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np. Testowe dane: Abcdefg Rezultat Gfedcba.");
            //Console.WriteLine("Podaj ciąg znaków ...");

            //string text = Console.ReadLine();

            //for (int i = text.Length-1;  i >= 0; i--)
            //{
            //    Console.Write(text[i]);
            //}

            // 9. Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.
            Console.WriteLine("Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.");
            Console.WriteLine("Podaj liczbę dzieiętną ...");

            int number = int.Parse(Console.ReadLine());
            int reszta;
            string numberDecimal = " ";

            for (int i = 0; 0 < number; i++)
            {
                if (number % 2 == 0)
                {
                    number = number / 2;
                    reszta = 0;
                    numberDecimal += reszta.ToString();
                }
                else
                {
                    number = number / 2;
                    reszta = 1;
                    numberDecimal += reszta.ToString();
                }
            }
            Console.WriteLine(numberDecimal);

            for (int j = numberDecimal.Length - 1; j >= 0; j--)
            {
                Console.Write(numberDecimal[j]);
            }

            //// 9. Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.
            //Console.WriteLine("Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.");
            //Console.WriteLine("Podaj liczbę dzieiętną ...");















            // zastanowić się nad takim rozwiązaniem
            //  for (int i = revBin.Length; i > 0; i--)
            //{
            //    Console.Write(revBin[i - 1]);
            //}
            //Console.WriteLine(".");




        }
    }
}
