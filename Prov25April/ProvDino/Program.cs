

Console.WriteLine($"Du ska får betygsätta olika dinosarier nu!");

Console.WriteLine($"Först upp är {Triceratops.DinoName} som väger {Triceratops.DinoWeight}kg!\n{Triceratops.DinoDescription}\nVilket betyg vill du ge{Triceratops.DinoName} på en skala mellan 1-5");

string Tgrade = Console.ReadLine();
bool One = int.TryParse(Tgrade, out Triceratops.Grade);

while(Triceratops.Grade >5 || Triceratops.Grade<1 || One==false){                        // gör så att du inte kan ge betyg över 5 eller under 1
   Console.WriteLine("Vilket betyg vill du ge Triceratops på en skala mellan 1-5");
  Tgrade = Console.ReadLine();
 One = int.TryParse(Tgrade, out Triceratops.Grade);
}


Console.WriteLine("Skriv en kort resensionstext om Triceratopsen");
Triceratops.ReviewText = Console.ReadLine();





Console.WriteLine($"Nästa upp är {Tyrannosaurus.DinoName} som väger {Tyrannosaurus.DinoWeight}kg!\n{Tyrannosaurus.DinoDescription}\nVilket betyg vill du ge{Tyrannosaurus.DinoName} på en skala mellan 1-5");

string Tgrade2 = Console.ReadLine();
bool Two = int.TryParse(Tgrade2, out Tyrannosaurus.Grade);

while(Tyrannosaurus.Grade >5 || Tyrannosaurus.Grade<1 || Two==false){                        // gör så att du inte kan ge betyg över 5 eller under 1
   Console.WriteLine("Vilket betyg vill du ge Tyrannosaurus på en skala mellan 1-5");
  Tgrade2 = Console.ReadLine();
 Two = int.TryParse(Tgrade2, out Tyrannosaurus.Grade);
}



Console.WriteLine("Skriv en kort resensionstext om Tyrannosaurusen");
Tyrannosaurus.ReviewText = Console.ReadLine();

Console.WriteLine($"Du sa {Triceratops.ReviewText} och gav {Triceratops.Grade} om {Triceratops.DinoName} och {Tyrannosaurus.ReviewText} och gav {Tyrannosaurus.Grade} om {Tyrannosaurus.DinoName} ");

Console.ReadLine();