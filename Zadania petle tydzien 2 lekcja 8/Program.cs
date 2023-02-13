namespace Zadania_petle_tydzien_2_lekcja_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile jest liczb pierwszych w zakresie od 0 do 100.");
            Console.WriteLine("Podaj zakres liczb do sprawdzenia");
            
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int no1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int no2 = int.Parse(Console.ReadLine());

            int i = no1;

            for ( i = 1; i < no2; i++)
            {
                

                if (i%no2 == 0 && no2<=i)
                {

                } else
                {

                }




            }





        }
    }
}