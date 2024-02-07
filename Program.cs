using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int guess = random.Next(1, 11);

        int myInt;
        int howMany = 0;

        Console.WriteLine("Zgadnij liczbe z zakresu od 1 do 10");

        do
        {
            howMany++;
            Console.Write("Podaj liczbe: ");
            myInt = int.Parse(Console.ReadLine());

            if (myInt < 1 || myInt > 10)
            {

                Console.WriteLine("Podales liczbe z poza zakresu!");
            }
            else
            {
                if (myInt < guess)
                {
                    Console.WriteLine("Podales za mala liczbe!");
                }
                else if (myInt > guess)
                {
                    Console.WriteLine("Podales za duza liczbe!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Brawo! Zgadles za {0} razem", howMany);
                }
            }

        } while (guess != myInt);
    }
}