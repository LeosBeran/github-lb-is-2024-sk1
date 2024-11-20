using System;

class Program {
    static void Main() {

        string again = "a";

        while(again == "a") {
            Console.Clear();
            Console.WriteLine("***************");
            Console.WriteLine("*** Konvergentní řady ***");
            Console.WriteLine("***************");
            Console.WriteLine("**** Leoš Beran ****");
            Console.WriteLine("***************");
            Console.WriteLine();

            Console.Write("Zadejte počet iterací (přesnost): ");
            double presnost;
            while(!double.TryParse(Console.ReadLine(), out presnost)) {
                Console.Write("Nezadali jste reálné číslo. Zadejte přesnou hodnotu znovu: ");
            }

            double i = 1;
            double znamenko = 1;
            double piCtvrt = 1;

            while((1/i)>=presnost) {
                i = i + 2;
                znamenko = -znamenko;
                piCtvrt = piCtvrt + znamenko * (1/i);

                if(znamenko==1){
                        Console.WriteLine("Zlomek: +1/{0}; aktuální hodnota PI = {1}", i, 4 * piCtvrt);
                }
                     else {
                        Console.WriteLine("Zlomek: -1/{0}; aktuální hodnota PI = {1}", i, 4 * piCtvrt);
                }
            }

            Console.WriteLine("Hodnota čísla PI = {0:f4}", 4 * piCtvrt);



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