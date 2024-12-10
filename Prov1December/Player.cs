
class Player {

    public int hp = 0;

    public int minDamage = 0;

    public int maxDamage = 0;

    public Player(){
        hp = Random.Shared.Next(80,110);

        minDamage = Random.Shared.Next(25,40);
        maxDamage = Random.Shared.Next(45,65);
    }
}