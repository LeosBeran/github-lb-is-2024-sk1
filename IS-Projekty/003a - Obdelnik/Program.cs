﻿using System.Globalization;
string again = "a";
        
        while(again == "a") {
            Console.WriteLine("****************************");
            Console.WriteLine("***** Obdélník *****");
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
            int x;
            Console.Write(int.TryParse("10", out x));
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
                for(int j=1; j<= width; j++) {
                    Console.Write("* ");
                    
                    // zpoždění
                    System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(50));
                }
                Console.WriteLine();
            }
            
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();
        }









 

// toto je jednořádkový komentář

/* toto je víceřádkový komentář */