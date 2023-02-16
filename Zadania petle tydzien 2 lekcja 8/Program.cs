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

            for ( i1 = i1 ; i1 <= i2; i1++)
            {
                
                counters++;

                Console.WriteLine(i1);




                //if (i1 % i2 == 0)
                //{

                //} else
                //{

                //}




            }





        }
    }
}