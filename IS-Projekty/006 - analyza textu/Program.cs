using System;

class Program {
    static void Main() {

        string again = "a";

        while(again == "a") {
            Console.Clear();
            Console.WriteLine("***************");
            Console.WriteLine("*** ANALYZA TEXTU ***");
            Console.WriteLine("***************");
            Console.WriteLine("**** Leoš Beran ****");
            Console.WriteLine("***************");
            Console.WriteLine();

            Console.Write("\nZadejte váš text: ");
            string myText = Console.ReadLine();
            
            string samohlasky = "aáeéěiíoóuůúyýAÁEÉIÍOÓUŮÚYÝ";
            string souhlasky = "bcčdďfghjklmnňpqrřsštťvwxzžBCČDĎFGHJKLMNŇPQRŘSŠTŤVWXZŽ";
            string cislice = "0123456789";

            int pocetSamohlasek = 0;
            int pocetSouhlasek = 0;
            int pocetOstatnich = 0;
            int pocetCislic = 0;

            foreach(char znak in myText) {
                if(souhlasky.Contains(znak)){
                    pocetSouhlasek++;
                }
                else if(samohlasky.Contains(znak)){
                    pocetSamohlasek++;
                }
                else if(cislice.Contains(znak)){
                    pocetCislic++;
                }
                else 
                    pocetOstatnich++;
                
                
            }

            Console.WriteLine();
            Console.WriteLine("Počet samohlásek: {0}", pocetSamohlasek) ;
            Console.WriteLine("Počet souhlásek: {0}", pocetSouhlasek); 
            Console.WriteLine("Počet číslic: {0}", pocetCislic); 
            Console.WriteLine("Počet ostatních znaků: {0}", pocetOstatnich) ;



        

            Console.WriteLine();
            Console.WriteLine(myText);
            Console.WriteLine(myText[0]);
            Console.WriteLine(myText.Length);

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();








        }

    }
}



// toto je jednořádkový komentář

/* toto je
víceřádkový
komentář */