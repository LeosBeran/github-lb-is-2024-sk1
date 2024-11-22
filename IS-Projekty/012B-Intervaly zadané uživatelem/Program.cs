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

Console.Write("Zadejte počet inetrvalů: ");
int intervalPocet;
while(!int.TryParse(Console.ReadLine(), out intervalPocet)){
    Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
}
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Zadané hodnoty:");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}, počet intervalů: {3}", n, dm, hm, intervalPocet);
            Console.WriteLine("==========================================");
            Console.WriteLine();


    int [] myArray = new int [n];
    Random randomNumber = new Random();

    int [] pocetciselvIntervalech = new int [intervalPocet];
    double velikostIntervalu = (double)(hm-dm)/intervalPocet;
   

    Console.WriteLine("\n\nVygenerovaná čísla: ");
        for(int i=0; i<n; i++) {
            myArray[i] = randomNumber.Next(dm, hm+1);
            Console.Write("{0}, ", myArray[i]);
        
            for(int j=0; j<intervalPocet; j++){
                double dolnihranice = dm + j * velikostIntervalu;
                double hornihranice = dm + (j + 1) * velikostIntervalu;

                if(myArray[i] >= dolnihranice && myArray[i] < hornihranice){
                    pocetciselvIntervalech[j]++;
                    break;
                }

                if (j == intervalPocet - 1 && myArray[i] == hm){

                pocetciselvIntervalech[j]++;
                 }
            }
        }
    Console.WriteLine("\n");
        Console.WriteLine("Intervaly a počty hodnot:");
        for (int j = 0; j < intervalPocet; j++)
        {
            double dolniHranice = dm + j * velikostIntervalu;
            double horniHranice = dm + (j + 1) * velikostIntervalu;
            Console.WriteLine("Interval <{0:F2}, {1:F2}>: {2}", dolniHranice, horniHranice, pocetciselvIntervalech[j]);
    }
                    Console.WriteLine("Pro opakování programu stiskněte klávesu A");

again = Console.ReadLine();

        }
