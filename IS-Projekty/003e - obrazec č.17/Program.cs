using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        string again = "a";

        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("***** Obrazec č. 17 *****");
            Console.WriteLine("****************************");
            Console.WriteLine("******* Leoš Beran ********");
            Console.WriteLine("****************************");
            Console.WriteLine();
            
            Console.Write("Zadejte šířku obrazce (celé číslo, min. 8): ");
            int width;
            while (!int.TryParse(Console.ReadLine(), out width) || width < 8)
            {
                Console.Write("Nezadali jste platné celé číslo (min. 8). Zadejte šířku znovu: ");
            }

            Console.Write("Zadejte výšku obrazce (celé číslo, min. 8): ");
            int height;
            while (!int.TryParse(Console.ReadLine(), out height) || height < 8)
            {
                Console.Write("Nezadali jste platné celé číslo (min. 8). Zadejte výšku znovu: ");
            }

            for (int i = 1; i < height; i++)
            {
                for (int j = 1; j < width; j++)
                {
                    // Podmínky pro umístění hvězdiček podle vzoru
                    if ((i == 1 && j == 1) || (i == 1 && j == 4) || 
                        (i == 1 && j == 7) || (i == 2 && j == 2) ||
                        (i == 2 && j == 5) || (i == 2 && j == 8) ||
                        (i == 3 && j == 3) || (i == 3 && j == 6) ||
                        (i == 4 && j == 4) || (i == 4 && j == 7) ||
                        (i == 5 && j == 3) || (i == 5 && j == 6) ||
                        (i == 6 && j == 2) || (i == 6 && j == 5) || 
                        (i == 6 && j == 8) || (i == 7 && j == 1) ||
                        (i == 7 && j == 4) || (i == 7 && j == 7) ||
                        (i == 8 && j == 2) || (i == 8 && j == 5) ||
                        (i == 8 && j == 8))
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                    // Zpoždění pro každé vykreslení hvězdičky
                    Thread.Sleep(50);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();
        }
    }
}
