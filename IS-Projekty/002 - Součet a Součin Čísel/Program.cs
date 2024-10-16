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


            int suma = 0;
            int multi = 1;
            int numberBackup = number;
            int digit;
            if(number<0)
                number = - number;
            while(number >= 10) {
                digit = number % 10;
                number = (number-digit)/10;
                Console.WriteLine("Digit = {0}", digit);
                suma = suma + digit;
                multi = multi * digit;
            }
            Console.WriteLine("Digit = {0}", number);

            suma = suma + number;

            multi = multi * number;
            
            Console.WriteLine();
            Console.WriteLine("\n\n\nSoučet cifer čísla {0} je {1}", numberBackup, suma);
            Console.WriteLine("\nSoučin cifer čísla {0} je {1}", numberBackup, multi);
        




        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stiskněte klávesu A");
        again = Console.ReadLine();








    }

}
}

// toto je jednořádkový komentář

/* toto je víceřádkový komentář */