using System.Security.Authentication.ExtendedProtection;
using System.Diagnostics;

string again = "a";
        
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("***** Generátor pseudonáhodných čísel *****");
            Console.WriteLine("*******************************************");
            Console.WriteLine("************* Leoš Beran *****************");
            Console.WriteLine("*******************************************");
            Console.WriteLine();

            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných čísel znovu: ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Zadané hodnoty:");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("==========================================");
            Console.WriteLine();

            //deklarace pole    
            int[] myArray = new int[n];

            Random randomNumber = new Random();

            Console.WriteLine("\n\nNáhodná čísla:");
            for(int i=0; i<n; i++) {
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]); 
            }

            Stopwatch myStopwatch = new Stopwatch();

            int myCompare = 0;
            int myChange = 0;
            
            
            myStopwatch.Start();
            for (int gap = n / 2; gap > 0; gap /= 2) {
                for (int i = gap; i < n; i++) {
                    int current = myArray[i];
                    int j = i;

                    while (j >= gap && myArray[j - gap] > current) {
                        myCompare++;
                        myArray[j] = myArray[j - gap];
                        j -= gap;
                        myChange++;
                    }
                    myArray[j] = current;
                }
            }
            myStopwatch.Stop();



            Console.WriteLine("\n\n\nSeřazené pole");
            for(int i=0; i<n; i++) {
                Console.Write("{0}; ", myArray[i]); 
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nČas potřebný na seřazení pole pomocí algoritmu Shell sort: {0}", myStopwatch.Elapsed);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n\nPočet porovnání: {0}", myCompare);
            Console.WriteLine("\nPočet výměn: {0}", myChange);
            

            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();

        }