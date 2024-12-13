class Investor
{

    static public int Money;

    static public int Vanity;

    static public int Greed = 0;

    static public bool HasBeenApproached;

    static public int Flatter;

    static public int Entice;




}

class GreedyInvestor : Investor  //Arvklass till investor
{

    public GreedyInvestor()
    {
        Greed = Random.Shared.Next(50, 80);
        Vanity = Random.Shared.Next(0, 10);
    }

}

class VainInvestor : Investor  //Arvklass till investor
{
    public VainInvestor()
    {
        Vanity = Random.Shared.Next(50, 80);
        Greed = Random.Shared.Next(0, 10);
    }

}