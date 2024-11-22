using System;

class Program
{
    static void Main()
    {
        string again = "a";

        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("***************");
            Console.WriteLine("*** Výpočet Eulerova čísla ***");
            Console.WriteLine("***************");
            Console.WriteLine("**** Leoš Beran ****");
            Console.WriteLine("***************");
            Console.WriteLine();

            Console.Write("Zadejte požadovanou přesnost: ");
            double presnost;
            while (!double.TryParse(Console.ReadLine(), out presnost) || presnost <= 0)
            {
                Console.Write("Nezadali jste kladné reálné číslo. Zadejte přesnost znovu: ");
            }

            double euler = 1.0; // První člen řady (1/0!)
            double clen = 1.0; // Aktuální člen řady (1/n!)
            int n = 1; // Počítání iterací

            while (clen >= presnost)
            {
                clen = clen / n; // Vypočítání dalšího členu řady
                euler += clen;
                Console.WriteLine("Člen: 1/{0}! = {1}; aktuální hodnota e = {2}", n, clen, euler);
                n++;
            }

            Console.WriteLine("\nHodnota Eulerova čísla e = {0:f10}", euler);

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();
        }
    }
}
