using System.Globalization;
string again = "a";
        
        while(again == "a") {
            Console.WriteLine("****************************");
            Console.WriteLine("***** Obrazec číslo 12 *****");
            Console.WriteLine("****************************");
            Console.WriteLine("******* Leoš Beran ********");
            Console.WriteLine("****************************");
            Console.Clear();
            Console.WriteLine();
            Console.Write("Zadejte šířku obrazce (celé číslo): ");
            int width;
            while(!int.TryParse(Console.ReadLine(), out width)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu šířku: ");
            }
            Console.Write("Zadejte výšku obrazce (celé číslo): ");
            int height;
            while(!int.TryParse(Console.ReadLine(), out height)) {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu výšku: ");
            }
            // for(int i=1; i <= 10 ; i++) {
            //     Console.WriteLine(i);
            // }
            // int j = 1;
            // while(j <= 10) {
            //     Console.WriteLine(j);
            //     j++;
            // }
            for(int i=1; i<= height; i++) {
                for(int j=1; j<= width; j++)

                 { 
                    bool jeIckoSude = i%2==0;
                    bool jeJeckoSude = j%2==0;

                    if(!jeIckoSude && jeJeckoSude){
                      Console.Write("*");
                    
                    // zpoždění
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(50));
                    }
                     else if(jeIckoSude && !jeJeckoSude){
                      Console.Write("*");
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(50));
                    }

                    else{
                      Console.Write("  ");
                    }
                

                }
                Console.WriteLine();
            }
            
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();
        }









 

// toto je jednořádkový komentář

/* toto je víceřádkový komentář */