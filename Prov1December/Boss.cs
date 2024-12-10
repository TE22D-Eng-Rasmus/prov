

class Boss
{

    public string _name = "";

    public int hp = 0;

    public int maxDamage = 0;

    public int minDamage = 0;

    public string _SpecialDrop = "";

    public string _weakness = "";

    public Boss(string name, string SpecialDrop, string Weakness)
    {

        _weakness = Weakness;

        _SpecialDrop = SpecialDrop;

        _name = name;          //gör så namnet man skriver till bossen döps den till

        maxDamage = Random.Shared.Next(20, 50);    //Ger bossen en random max och min damage och random hp
        minDamage = Random.Shared.Next(3, 15);
        hp = Random.Shared.Next(50, 80);
    }

}
