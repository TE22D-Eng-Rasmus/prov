

Console.WriteLine($"Du ska får betygsätta olika dinosarier nu!");

List<string> dinosaurList = new List<string> { "Triceratops", "Tyrannosaurus" };

Triceratops Tri = new();
Tyrannosaurus Tyr = new();


Console.WriteLine("Lista över dinosaurier:");
foreach (var dino in dinosaurList)
{
   Console.WriteLine(dino);
}


Console.WriteLine($"\nFörst upp är {Tri.DinoName} som väger {Tri.DinoWeight}kg!\n{Tri.DinoDescription}\nVilket betyg vill du ge{Tri.DinoName} på en skala mellan 1-5");

string Tgrade = Console.ReadLine();
bool One = int.TryParse(Tgrade, out Tri.Grade);

while (Tri.Grade > 5 || Tri.Grade < 1 || One == false)
{                        // gör så att du inte kan ge betyg över 5 eller under 1
   Console.WriteLine("Vilket betyg vill du ge Triceratops på en skala mellan 1-5");
   Tgrade = Console.ReadLine();
   One = int.TryParse(Tgrade, out Tri.Grade);
}

Tri.WriteText();

Console.WriteLine("Skriv en kort resensionstext om Triceratopsen");
Tri.ReviewText = Console.ReadLine();





Console.WriteLine($"Nästa upp är {Tyr.DinoName} som väger {Tyr.DinoWeight}kg!\n{Tyr.DinoDescription}\nVilket betyg vill du ge{Tyr.DinoName} på en skala mellan 1-5");

string Tgrade2 = Console.ReadLine();
bool Two = int.TryParse(Tgrade2, out Tyr.Grade);

while (Tyr.Grade > 5 || Tyr.Grade < 1 || Two == false)
{                       // gör så att du inte kan ge betyg över 5 eller under 1
   Console.WriteLine("Vilket betyg vill du ge Tyrannosaurus på en skala mellan 1-5");
   Tgrade2 = Console.ReadLine();
   Two = int.TryParse(Tgrade2, out Tyr.Grade);
}


Tyr.WriteText();
Console.WriteLine("Skriv en kort resensionstext om Tyrannosaurusen");
Tyr.ReviewText = Console.ReadLine();

Console.WriteLine($"Du sa {Tri.ReviewText} och gav {Tri.Grade} om {Tri.DinoName} och {Tyr.ReviewText} och gav {Tyr.Grade} om {Tyr.DinoName} ");

Console.ReadLine();