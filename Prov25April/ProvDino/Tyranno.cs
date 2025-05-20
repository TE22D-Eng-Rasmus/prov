

public class Tyrannosaurus : Dino
{

   public Tyrannosaurus()
   {
      DinoName = "Tyrannosaurus";
      DinoDescription = $"{Descriptions[Tr]}";
      DinoWeight = Random.Shared.Next(500, 2800);
      Grade = 0;
      ReviewText = "";
   }


   string[] Descriptions = ["Tyrannosaurus är ett släkte stora köttätande dinosaurier som tros ha levt i slutet av kritaperioden för cirka 68 till 65,5 miljoner år sedan.", "Tyrannosaurs rex levde för 68-66 miljoner år sedan i nuvarande västra USA och Kanada. Den kunde bli 12 meter lång, 5 meter hög och vägde 7 ton. Tänderna kunde bli upp till 18 cm långa", "Tyrannosaurus hade det kraftigaste bettet av alla landlevande djur som man känner till och bakbenens klor var stora och skarpa. Förutom dessa dödliga vapen hade Tyrannosaurus en stor och välutvecklad hjärna, ett mycket välutvecklat luktsinne och framåtriktade ögon."];

   public int Tr = Random.Shared.Next(1, 4); //Väljer random vilken DinoDescription som väljs av alternativen i Descriptions




   public override void WriteText()
   {


      if (Grade <= 2)
      {
         Console.WriteLine("Det var inte ett så bra betyg");
      }

      if (Grade >= 3)
      {
         Console.WriteLine("Inte illa, Du verkar gilla Tyrannosarus!");
      }

      else if (Grade! >= 3 && Grade! <= 2)
      {
         Console.WriteLine("Du gav ett riktigt skumt betyg"); // ska inte gå att ge ett betyg som inte är mellan 1-5 annars kommer detta
      }

   }


}