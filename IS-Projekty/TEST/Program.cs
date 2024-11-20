using System.Security.Authentication.ExtendedProtection;

string again = "a";
while(again=="a"){

Console.Clear();
Console.WriteLine("***************************");
Console.WriteLine("********Generátor*********");
Console.WriteLine("********Leoš Beran**********");
Console.WriteLine("***************************");

Console.Write("Zadejte počet čísel, které chcete generovat: ");
int n;
while(!int.TryParse(Console.ReadLine(), out n)){
    Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
}

Console.Write("Zadejte dolní mez generovaných čísel: ");
int dm;
while(!int.TryParse(Console.ReadLine(), out dm)){
    Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
}

Console.Write("Zadejte horní mez generovaných čísel: ");
int hm;
while(!int.TryParse(Console.ReadLine(), out hm)){
    Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
}

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Zadané hodnoty:");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("==========================================");
            Console.WriteLine();


    int [] myArray = new int [n];
    Random randomNumber = new Random();

    Console.WriteLine("\n\nVygenerovaná čísla: ");
        for(int i=0; i<n; i++) {
            myArray[i] = randomNumber.Next(dm, hm+1);
            Console.Write("{0}, ", myArray[i]);
        }

                    Console.WriteLine("Pro opakování programu stiskněte klávesu A");

again = Console.ReadLine();

        }
