using System;

class Program {
    static void Main() {

        string again = "a";

        while(again.ToLower() == "a") {
            Console.Clear();
            Console.WriteLine("***************");
            Console.WriteLine("*** Součet a součin čísel ***");
            Console.WriteLine("***************");
            Console.WriteLine("**** Leoš Beran ****");
            Console.WriteLine("***************");
            Console.WriteLine();

            // Vstup do programu správně řešený
            Console.Write("Zadejte první číslo řady (celé číslo): ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)){
                Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
            }

            // Uchování původního čísla pro pozdější výstup
            int numberBackup = number;

            // Pokud je číslo záporné, převedeme jej na kladné
            if (number < 0) {
                number = -number; }

            // Alternativní řešení: převedení čísla na řetězec
            string numberString = number.ToString();
            int suma = 0;
            int multi = 1;

            // Procházíme každou cifru v čísle
            foreach(char digit in numberString) {
                int currentDigit = int.Parse(digit.ToString()); // převod znaku na číslo
                suma += currentDigit;  // přičtení cifry k součtu
                multi *= currentDigit; // násobení cifry k součinu
            }

            // Výstup výsledků
            Console.WriteLine($"\n\n\nSoučet cifer čísla {numberBackup} je {suma}");
            Console.WriteLine($"Součin cifer čísla {numberBackup} je {multi}");

            // Opakování programu
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();
        }
    }
}
