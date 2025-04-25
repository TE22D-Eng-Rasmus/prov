

 public class Triceratops: Dino{

 static string[] Descriptions = ["Triceratops, släkte med stora, behornade dinosaurier funna i Nordamerika, där den tros ha levt vid slutet av Kritaperioden för 68–66 milj. år sedan. Triceratops var ett gigantiskt djur som liknade en stor noshörning med långa horn i pannan", "Munnen saknade tänder i den främre delen men näbben var perfekt till att knipsa av de sega barrväxter och ormbunkar som Triceratops levde av. Det fanns nämligen ännu inga blommor och lövträd vid den här tiden. Födan maldes sedan sönder av kindtänderna innan den svaldes.", "Unga triceratops hade små, raka horn ovanför ögonen . När den växte blev hornen bakåtböjda, och till slut, när den nådde vuxen ålder, böjde sig hornen framåt. När det gäller hornet på näsan var detta gjord av keratin, vilket är samma ämne som mänskliga fingernaglar och noshörningshorn är gjorda av."];

  public static int Tr2 = Random.Shared.Next(1,4); //Väljer random vilken DinoDescription som väljs av alternativen i Descriptions

    public static string DinoName = "Triceratops";

    static public string DinoDescription = $"{Descriptions[Tr2]}";

   static public int DinoWeight = Random.Shared.Next(500,2500);

    static public int Grade;

   static public string ReviewText = "";

    
}