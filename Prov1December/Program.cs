

Boss GiantMan = new Boss("GiantMan", "GiantSword", "LaserGun");
Boss ElectroMan = new Boss("ElectroMan", "LaserGun", "WaterGun");
Boss SmallMan = new Boss("SmallMan", "WaterGun", "GiantSword");

Player MegaMan = new Player();
bool ready = false;

while (ready == false){

Console.WriteLine($"1 {GiantMan._name} does between {GiantMan.minDamage} and {GiantMan.maxDamage} damage per hit and has {GiantMan.hp} hp and drops {GiantMan._SpecialDrop} \n \n2 {ElectroMan._name} does between {ElectroMan.minDamage} and {ElectroMan.maxDamage} damage per hit and has {ElectroMan.hp} hp and drops {ElectroMan._SpecialDrop} \n \n3 {SmallMan._name} does between {SmallMan.minDamage} and {SmallMan.maxDamage} damage per hit and has {SmallMan.hp} hp and drops {SmallMan._SpecialDrop} \nWrite 1,2 or 3 to choose one to fight against ");


 string Select = Console.ReadLine();

 if (int.TryParse(Select, out int fighter)){
   if (fighter == 1){
    Console.WriteLine($"You choosen to fight {GiantMan._name}");
    ready = true;
   }
   if (fighter == 2){
    Console.WriteLine($"You choosen to fight {ElectroMan._name}");
    ready = true;
   }
   if (fighter == 3){
    Console.WriteLine($"You choosen to fight {SmallMan._name}");
    ready = true;
   }
   else Console.WriteLine("Incorrect input try agian\n");
 }
 else Console.WriteLine("Incorrect input try agian\n");
 
 }

 Console.ReadLine();