using System;

class Program {
    static void Main() {
        string again = "a";
        
        while(again.ToLower() == "a") {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("***** Pravouhlý trojúhelník *****");
            Console.WriteLine("****************************");
            Console.WriteLine("******* Leoš Beran ********");
            Console.WriteLine("****************************");
            Console.WriteLine();
            
            // Zadejte šířku trojúhelníku
            Console.Write("Zadejte šířku (počet řádků) trojúhelníku (celé číslo): ");
            int width;
            while(!int.TryParse(Console.ReadLine(), out width)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu šířku: ");
            }

            // Výpis pravouhlého trojúhelníku
            for(int i = 1; i <= width; i++) {
                for(int j = 1; j <= i; j++) {
                    Console.Write("* ");
                    
                    // zpoždění pro efekt
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(50));
                }
                Console.WriteLine();
            }
            
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();
        }
    }
}
