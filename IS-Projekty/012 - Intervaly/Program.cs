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
    
    int int1=0;
    int int2=0;
    int int3=0;
    int int4=0;

    Console.WriteLine("\n\nVygenerovaná čísla: ");
        for(int i=0; i<n; i++) {
            myArray[i] = randomNumber.Next(dm, hm+1);
            Console.Write("{0}, ", myArray[i]);
        }

    if(myArray[i]<= (0.25 * hm)) {
        int1++;
    }
    else if(myArray[i] <= (0.5 * hm)){
        int2++;
    }
    else if(myArray[i] <= (0.75 * hm)){
        int3++;
    }
    else 
        int4++;

    Console.WriteLine("\nInterval <{0}, {1}>: {2}", dm, 0,25 * hm, int1);
    Console.WriteLine("\nInterval <{0}, {1}>: {2}", 0,25 * hm + 1, 0,50 * hm, int2);
    Console.WriteLine("\nInterval <{0}, {1}>: {2}", dm, 0,5 * hm + 1, 0,75 * hm,  int3);
    Console.WriteLine("\nInterval <{0}, {1}>: {2}", dm, 0,75 * hm + 1, hm * hm, int4);
                    Console.WriteLine("Pro opakování programu stiskněte klávesu A");

again = Console.ReadLine();

        }
