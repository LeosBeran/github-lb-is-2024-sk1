using System;

class Program {
    static void Main() {

        string again = "a";

        while(again == "a") {
            Console.Clear();
            Console.WriteLine("***************");
            Console.WriteLine("*** Aritmetická posloupnost ***");
            Console.WriteLine("***************");
            Console.WriteLine("**** Leoš Beran ****");
            Console.WriteLine("***************");
            Console.WriteLine();

            Console.Write("Zadejte počet čísel v posloupnosti: ");
            int pocetCisel;
            while(!int.TryParse(Console.ReadLine(), out pocetCisel)){
                Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
            }

            Console.Write("Zadejte velikost diference: ");
            int diference;
            while(!int.TryParse(Console.ReadLine(), out diference)){
                Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
            }

            Console.Write("Zadejte první prvek v posloupnosti: ");
            int prvniPrvek;
            while(!int.TryParse(Console.ReadLine(), out prvniPrvek)){
                Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
            }

            Console.WriteLine("\n==========================================");
            Console.WriteLine("Zadané hodnoty:");
            Console.WriteLine("Počet čísel: {0}; diference: {1}; první prvek: {2}", pocetCisel, diference, prvniPrvek);
            Console.WriteLine("==========================================");
            Console.WriteLine();


            int[] posloupnost = new int[pocetCisel];
            int soucet = 0;

            Console.WriteLine("Aritmetická posloupnost: ");
            for(int i = 0; i < pocetCisel; i++){
                posloupnost[i] = prvniPrvek + i * diference;
                Console.Write("{0} ", posloupnost[i]);
                soucet += posloupnost[i];
            } 

            Console.WriteLine("\n\nSoučet všech členů posloupnosti: {0}", soucet);

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();








        }

    }
}



// toto je jednořádkový komentář

/* toto je
víceřádkový
komentář */