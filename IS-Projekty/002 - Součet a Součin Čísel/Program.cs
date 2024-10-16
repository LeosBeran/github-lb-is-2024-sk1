using System;

class Program { static void Main() {

    string again = "a";

    while(again == "a") {
        Console.Clear();
        Console.WriteLine("***************");
        Console.WriteLine("*** Součet a součin čísel ***");
        Console.WriteLine("***************");
        Console.WriteLine("**** Leoš Beran ****");
        Console.WriteLine("***************");
        Console.WriteLine();

        // Vstup hodnot do programu - špatně řešený
        //Console.Write("Zadejte první číslo řady: ");
        //int first = int.Parse(Console.ReadLine());

        //Vstup do programu správně řešený
        Console.Write("Zadejte první číslo řady (celé číslo): ");
        int number;
        while(!int.TryParse(Console.ReadLine(), out number)){
            Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
        }

        
        /* možné řešení
        int suma = 0;
        multi =
        int numberBackup = number;
        int digit;

        while (number >= 10) {
            digit = number % 10;
            number = (number-digit)/10;
            Console.WriteLine("Digit = {0}" , digit);
            suma = suma + digit;
            multi = multi * digit;
        }
        Console.WriteLine("Digit = {0}" , digit);
       
        // musíme přičíst ještě poslední cifru
        suma = suma + number;
        multi = multi * number;

        Console.WriteLine();
        Console.WriteLine("\n\n\Součin cifer čísla {0} je {1}", numberBackup, multi) ;

        */

        int suma = 0;
        int numberBackup = number;
        int digit;

        while (number >= 10) {
            digit = number % 10;
            number = (number-digit)/10;
            Console.WriteLine("Digit = {0}" , digit);
            suma = suma + digit;
        }
        Console.WriteLine("Digit = {0}" , number);
       
        // musíme přičíst ještě poslední cifru
        suma = suma + number;

        Console.WriteLine();
        Console.WriteLine("\n\n\nSoučet cifer čísla {0} je {1}", numberBackup, suma) ;




        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stiskněte klávesu A");
        again = Console.ReadLine();








    }

}
}

// toto je jednořádkový komentář

/* toto je víceřádkový komentář */