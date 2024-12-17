using System.Security.AccessControl;
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
//Generátor
    Console.WriteLine("\n\nNáhodně vygenerovaná čísla jsou: ");
        for(int i=0; i<n; i++) {
            myArray[i] = randomNumber.Next(dm, hm+1);
            Console.Write("{0}, ", myArray[i]);
        }
//Max a Min
        int max = myArray[0];
        int min = myArray[0];

        for(int i = 1; i < n; i++){
            if(myArray[i] > max){
                max = myArray[i];
            }
            if(myArray[i] < min){
                min = myArray[i];
            }
        }

        List<int> PoziceMax = new List<int>();
        List<int> PoziceMin = new List<int>();
  
              for(int i = 0; i < n; i++){
                if(myArray[i] == max){
                    PoziceMax.Add(i);
                }
                if(myArray[i] == min){
                    PoziceMin.Add(i);
                }
              }
            Console.WriteLine("\n---------");
            Console.WriteLine("\n\nMaximum: {0}; všechny pozice maxima: {1}", max, string.Join(", ", PoziceMax));   
            Console.WriteLine("Minimum: {0}; všechny pozice minima: {1}", min, string.Join(", ", PoziceMin));   
            Console.WriteLine("---------");

for(int left = 0, right = n -1; left < right;){
    for(int i = left; i < right; i++){
        if(myArray[i] < myArray[i + 1]){
            int tmp = myArray[i];
            myArray[i] = myArray[i + 1];
            myArray[i + 1] = tmp;
        }
    }
    right --;

    for(int i = right; i > left; i--){
        if(myArray[i] > myArray[i - 1]){
            int tmp = myArray[i];
            myArray[i] = myArray[i - 1];
            myArray[i - 1] = tmp;
            }
        }
        left ++;
}



Console.WriteLine("\n\n\nSeřazené pole (sestupně):");
for (int i = 0; i < n; i++)
{
    Console.Write("{0}; ", myArray[i]);
}



        
            int [] cleanedArray = myArray.Distinct().ToArray();
            Console.WriteLine("\n-------------");
            Console.WriteLine("Druhé největší číslo: {0}, Třetí největší číslo: {1}, Páté největší číslo {2}", cleanedArray[1],cleanedArray[2],cleanedArray[4]);

            //číslo převedené do čtyřkové soustavy
            int cislo = cleanedArray[2];
            string vysledek = "";
            while (cislo > 0) {
                int zbytek = cislo % 4;
                cislo /= 4;
                vysledek = zbytek + vysledek;
            }
            if (vysledek == "") vysledek = "0"; // Ošetření pro číslo 0
            Console.WriteLine("\nTřetí největší číslo ({0}) v čtyřkové soustavě: {1}", cleanedArray[2], vysledek);

    // Fibonacciho výpočet
  Console.WriteLine("\nFibonacciho posloupnost druhého největšího čísla ({0})\n", cleanedArray[1]);


    


int vyska = 2 * cleanedArray[4];
    if (cleanedArray[4] > 2) {
        Console.WriteLine("\nPřesýpací hodiny (výška = {0}):", vyska);

        for (int i = 0; i < vyska / 2; i++) {
            Console.WriteLine(new string(' ', i) + new string('*', vyska - 2 * i));
        }
        for (int i = vyska / 2 - 1; i >= 0; i--) {
            Console.WriteLine(new string(' ', i) + new string('*', vyska - 2 * i));
        }
    } else {
        Console.WriteLine("\nPřesýpací hodiny se nevykreslují, protože výška je menší nebo rovna 2.");
    }

          Console.WriteLine("Pro opakování programu stiskněte klávesu A");
        again = Console.ReadLine();

        }
