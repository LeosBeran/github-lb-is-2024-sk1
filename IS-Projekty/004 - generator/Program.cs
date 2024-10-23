using System;
using System.Data;
using System.Net;

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

   

        //Vstup do programu správně řešený
        Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
        int n;
        while(!int.TryParse(Console.ReadLine(), out n)){
            Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
        }
        Console.Write("Zadejte dolní mez (celé číslo): ");
        int dm;
        while(!int.TryParse(Console.ReadLine(), out dm)){
            Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
        }
        Console.Write("Zadejte horní mez (celé číslo): ");
        int hm;
        while(!int.TryParse(Console.ReadLine(), out hm)){
            Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
        }

        Console.WriteLine();
        Console.WriteLine("===============================");
        Console.WriteLine("Zadejte hodnoty");
        Console.WriteLine("Počet čísel: {0}; dolní mez: {1}, horní mez: {2}", n, dm, hm);
        Console.WriteLine("===============================");
        Console.WriteLine();

        //deklarace pole
        int[] myArray = new int[n];

        Random randomNumber = new Random();

        Console.WriteLine("\n\nNáhodná čísla:");
        for(int i=0; i<=n; i++) {
            myArray[i] = randomNumber.Next(dm, hm);
            Console.Write("{0}; ", myArray[i]);
        }















        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stiskněte klávesu A");
        again = Console.ReadLine();








    }

}
}

// toto je jednořádkový komentář

/* toto je víceřádkový komentář */