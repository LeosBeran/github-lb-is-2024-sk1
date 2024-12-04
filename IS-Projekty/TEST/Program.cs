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
            Console.WriteLine("\n\nPozice max:");
            for(int i=0; i < ConvertList.Length; i++){
            Console.Write("{0}, ", ConvertList[i]);
            }

            for(int i = 1; i < n; i++) {
                if(myArray[i] == min) {
                poziceMin.Add(i);
                                }
            }
            int [] MinArray = poziceMin.ToArray();
            Console.WriteLine("\n\nPozice min:");
            for(int i=0; i < MinArray.Length; i++){
            Console.Write("{0}, ", MinArray[i]);
            }
            
                for(int i =0; i < n-1; i++) {
                
                for(int j = 0; j < n-i-1; j++) {
                    if(myArray[j] < myArray[j+1]) {
                        int tmp = myArray[j+1];
                        myArray[j+1] = myArray[j];
                        myArray[j] = tmp;
                    }
                }
            }
            Console.WriteLine("\n\n\nSeřazené pole");
                for(int i=0; i<n; i++) {
                Console.Write("{0}; ", myArray[i]); 
            }

            int [] cleanedArray = myArray.Distinct().ToArray();
            Console.WriteLine("\n\n\nSeřazené pole");
                for(int i=0; i<cleanedArray.Length; i++) {
                Console.Write("{0}; ", cleanedArray[i]); 
            }

            Console.WriteLine("\n\nPrvní: {0}", cleanedArray[0]);
            Console.WriteLine("Třetí: {0}", cleanedArray[2]);

            double median;
                if (n%2==0){
                    int middle1 = myArray[n/2];
                    int middle2 = myArray[(n/2) - 1];
                    median = (middle1 + middle2)/2;
                    Console.WriteLine("\n\nMedián: {0}", median);
                        } else{
                            median = myArray[n/2];
                            Console.WriteLine("\n\nMedián: {0}", median);
                        }
                    
                    string Binary = Convert.ToString(cleanedArray[2], 2);
                            Console.WriteLine("\n\nPřevedeno do binární soustavy: {0}", Binary);

                    Console.WriteLine("Pro opakování programu stiskněte klávesu A");

again = Console.ReadLine();

        }
