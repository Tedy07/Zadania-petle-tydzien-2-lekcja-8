namespace Zadania_petle_tydzien_2_lekcja_8
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
                int liczba;
                counters++;


                if (CzyPierwsza(liczba))
                {
                    Console.WriteLine("TAK");

                }
                else
                {
                    Console.WriteLine("NIE");
                }


                Console.WriteLine($"{i1} and {counters}");

                //if (i1 % i1 == 0 &&  )
                //{
                //    Console.WriteLine($"Reszta z dzielenia cyfry {i1} == 0 ");
                //} else
                //{
                //    Console.WriteLine("W przeciwnym razie");
                //}
            }

        }

        static bool CzyPierwsza(int n)
        {

            return true;
        }

    }
}