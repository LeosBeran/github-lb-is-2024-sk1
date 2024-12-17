using System.Security.Authentication.ExtendedProtection;
using System.Diagnostics;

string again = "a";
        
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("***** Kombinovaná Úloha Vánoční *****");
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
            

            myStopwatch.Start();
            int gap = n;
            bool swapped;

            do {
                gap = (gap * 10) / 13;
                if (gap < 1) gap = 1;

                swapped = false;
                for (int i = 0; i + gap < n; i++) {
                    if (myArray[i] > myArray[i + gap]) {
                        int tmp = myArray[i];
                        myArray[i] = myArray[i + gap];
                        myArray[i + gap] = tmp;
                        swapped = true;
                    }
                }
            } while (gap > 1 || swapped);
            myStopwatch.Stop();



            Console.WriteLine("\n\n\nSeřazené pole pomocí comb sort");
            for(int i=0; i<n; i++) {
                Console.Write("{0}; ", myArray[i]); 
            }

            Console.WriteLine("\n\nČas potřebný na seřazení pole pomocí algoritmu Comb sort: {0}", myStopwatch.Elapsed);

             Stopwatch mineStopwatch = new Stopwatch();

            
            

                    mineStopwatch.Start();
            for (int i = 1; i < n; i++) {
                int current = myArray[i];
                int j = i - 1;

                while (j >= 0 && myArray[j] > current) {
                    myArray[j + 1] = myArray[j];
                    j--;
                                    }
                myArray[j + 1] = current;
            }
            mineStopwatch.Stop();



            Console.WriteLine("\n\n\nSeřazené pole pomocí Insertion sort");
            for(int i=0; i<n; i++) {
                Console.Write("{0}; ", myArray[i]); 
            }

            Console.WriteLine("\n\nČas potřebný na seřazení pole pomocí algoritmu Insertion sort: {0}", mineStopwatch.Elapsed);
    
    
            int max = myArray[0];
            int min = myArray[0];
          
            for(int i = 1; i < n; i++) {
                if(myArray[i] > max) {
                    max = myArray[i];                    
                }
                if(myArray[i] < min){
                    min = myArray[i];
                }
                
            }
            Console.WriteLine("\n\nMaximum = {0}", max);   
            Console.WriteLine("\n\nMinimum = {0}", min);   

               // Ruční výpočet aritmetického průměru
            int sum = 0;
            for (int i = 0; i < n; i++) {
                sum += myArray[i]; // Sečítáme všechna čísla
            }
            
            // Ručně vypočítáme průměr a zbytek
            int prumer = sum / n;  // Celá část průměru
            int zbytek = sum - (prumer * n); // Zbytek (součet - průměr * počet čísel)

            Console.WriteLine("\n\nAritmetický průměr (celá část): {0}", prumer);
            Console.WriteLine("Zbytek při dělení součtu čísel počtem čísel: {0}", zbytek);

            Console.WriteLine("\n\nAritmetický průměr (celá část): {0}", prumer);
            Console.WriteLine("Zbytek při dělení součtu čísel počtem čísel: {0}", zbytek);

            int width = zbytek;
                        for(int i = 1; i <= width; i++) {
                        }

            Console.WriteLine();
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();

        }