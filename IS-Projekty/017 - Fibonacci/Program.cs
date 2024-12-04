using System.Data;
using System.Net.Security;
string again = "a";
while(again == "a") {
    Console.Clear();
    razitko();
    ulong a = nacistCislo("Zadejte počet členů Fibonacciho posloupnosti: ");
    

}

static void razitko()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("***************");
        Console.WriteLine("*** Fibonacci ***");
        Console.WriteLine("***************");
        Console.WriteLine("**** Leoš Beran ****");
        Console.WriteLine("***************");
        Console.ResetColor();
    }

static ulong nacistCislo(string zprava){
    Console.Write(zprava);
    ulong cislo;
        while (!ulong.TryParse(Console.ReadLine(), out cislo) || cislo == 0){
            Console.Write("Nebylo zadáno platné kladné číslo! Zadejte znovu: ");
        }
        return cislo;
}

