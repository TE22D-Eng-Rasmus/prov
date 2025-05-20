

public class Triceratops : Dino
{


  public Triceratops()
   {
      DinoName = "Triceratops";
      DinoDescription = $"{Descriptions[Tr2]}";
      DinoWeight = Random.Shared.Next(500, 2500);
      Grade = 0;
      ReviewText = "";
   }

   string[] Descriptions = ["Triceratops, släkte med stora, behornade dinosaurier funna i Nordamerika, där den tros ha levt vid slutet av Kritaperioden för 68–66 milj. år sedan. Triceratops var ett gigantiskt djur som liknade en stor noshörning med långa horn i pannan", "Munnen saknade tänder i den främre delen men näbben var perfekt till att knipsa av de sega barrväxter och ormbunkar som Triceratops levde av. Det fanns nämligen ännu inga blommor och lövträd vid den här tiden. Födan maldes sedan sönder av kindtänderna innan den svaldes.", "Unga triceratops hade små, raka horn ovanför ögonen . När den växte blev hornen bakåtböjda, och till slut, när den nådde vuxen ålder, böjde sig hornen framåt. När det gäller hornet på näsan var detta gjord av keratin, vilket är samma ämne som mänskliga fingernaglar och noshörningshorn är gjorda av."];

  public int Tr2 = Random.Shared.Next(1, 4); //Väljer random vilken DinoDescription som väljs av alternativen i Descriptions



   public override void WriteText()
  {


    if (Grade <= 2)
    {
      Console.WriteLine("Det var inte ett så bra betyg");
    }

    if (Grade >= 3)
    {
      Console.WriteLine("Inte illa, Du verkar gilla Triceratops!");
    }

    else if (Grade! >= 3 && Grade! <= 2)
    {
      Console.WriteLine("Du gav ett riktigt skumt betyg"); // ska inte gå att ge ett betyg som inte är mellan 1-5 annars kommer detta
    }

  }


}