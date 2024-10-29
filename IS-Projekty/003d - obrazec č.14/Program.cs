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
            Console.WriteLine("***** Obrazec č. 14 *****");
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

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    
                    if ((i >= 0 && i <= 3 && j >= 4 && j <= 7) ||   
                        (i >= 4 && i <= 7 && j >= 0 && j <= 3))     
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
