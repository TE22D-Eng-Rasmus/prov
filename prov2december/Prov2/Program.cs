

using System.Security.Cryptography.X509Certificates;

bool bool1 = false;  // bool som enbart finns för att göra nästa del i en fungerande while-loop

while (bool1 == false){
Console.WriteLine("Hur många investerare vill du prata med?");
string _mängd = Console.ReadLine();

if (int.TryParse(_mängd, out int mängd))
{
    if (mängd <= 0)
    {
        Console.WriteLine("Skriv ett tal över 0!");
    }
    if (mängd >= 1)
    {
        Console.WriteLine($"Du har valt att prata med {mängd} investerare. Hoppas du får mycket pengar nu!");
        bool1 = true;
    }
    
}
else Console.WriteLine("Skriv ett tal över 0!");

}

Console.ReadLine();