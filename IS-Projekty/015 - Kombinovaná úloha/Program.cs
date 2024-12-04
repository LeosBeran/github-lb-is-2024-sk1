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

    Console.WriteLine("\nNáhodně vygenerovaná čísla jsou: ");
        for(int i=0; i<n; i++) {
            myArray[i] = randomNumber.Next(dm, hm+1);
            Console.Write("{0}, ", myArray[i]);
        }
    Console.WriteLine("\n---------------------------: ");

            int max = myArray.Max();
            int min = myArray.Min();
            List<int> poziceMax = new List<int>();
            List<int> poziceMin = new List<int>();
            int indexPoleMax = 0;
            for(int i = 1; i < n; i++) {
                if(myArray[i] == max) {
                poziceMax.Add(i);
                                }
                
            }
            int [] ConvertList = poziceMax.ToArray();
            for(int i=0; i < ConvertList.Length; i++){
            Console.WriteLine("Max:{0}, všechny pozice maxima:{1}", max, ConvertList[i]);
            }

            for(int i = 1; i < n; i++) {
                if(myArray[i] == min) {
                poziceMin.Add(i);
                                }
            }
            int [] MinArray = poziceMin.ToArray();
            for(int i=0; i < MinArray.Length; i++){
            Console.WriteLine("Min:{0}, všechny pozice Minima:{1}", min, MinArray[i]);
            }
    Console.WriteLine("\n---------------------------: ");

            bool swapped;
            int start = 0, end = n - 1;

            do {
                swapped = false;

                for (int i = start; i < end; i++) {
                    if (myArray[i] < myArray[i + 1]) {
                        int tmp = myArray[i];
                        myArray[i] = myArray[i + 1];
                        myArray[i + 1] = tmp;
                        swapped = true;
                    }
                }

                for (int i = end - 1; i >= start; i--) {
                    if (myArray[i] < myArray[i + 1]) {
                        int tmp = myArray[i];
                        myArray[i] = myArray[i + 1];
                        myArray[i + 1] = tmp;
                        swapped = true;
                    }
                }
            } while (swapped);



            Console.WriteLine("\n\n\nSeřazené pole pomocí shaker sort");
            for(int i=0; i<n; i++) {
                Console.Write("{0}; ", myArray[i]); 
            }
    Console.WriteLine("\n---------------------------: ");

            int [] cleanedArray = myArray.Distinct().ToArray();
                for(int i=0; i<cleanedArray.Length; i++) {
            }

            Console.WriteLine("\nDruhé největší číslo: {0}", cleanedArray[1]);
            Console.WriteLine("Třetí největší číslo: {0}", cleanedArray[2]);
            Console.WriteLine("Čtvrté největší čslo: {0}", cleanedArray[3]);

            double median;
                if (n%2==0){
                    int middle1 = myArray[n/2];
                    int middle2 = myArray[(n/2) - 1];
                    median = (middle1 + middle2)/2;
                    Console.WriteLine("\n\nMedián generovaných čísel je: {0}", median);
                        } else{
                            median = myArray[n/2];
                            Console.WriteLine("\n\nMedián generovaných čísel je: {0}", median);
                        }
    Console.WriteLine("\n---------------------------: ");
                    string Binary = Convert.ToString(cleanedArray[3], 2);
                            Console.WriteLine("\n\nČtvrté nejvěší číslo převedeno do binární soustavy: {0}", Binary);


 // Nová část: Generování obrazce
            int height = (int)median; // Výška je medián
            int width = cleanedArray[2]; // Šířka je třetí největší číslo

            Console.WriteLine("\nObrazec - výška = medián ({0}); šířka = třetí největší číslo {1}", median, cleanedArray[2]);
            for (int i = 0; i < height; i++)
            {
                if (i < height / 3 || i >= height - height / 3)
                {
                    Console.WriteLine(new string(' ', (width - 3) / 2) + new string('*', 3));
                }
                else
                {
                    Console.WriteLine(new string('*', width));
                }
            }
                    Console.WriteLine("Pro opakování programu stiskněte klávesu A");
again = Console.ReadLine();

        }
