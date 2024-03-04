
using PathTrainingOoTRandomizer.Models;

namespace PathTrainingOoTRandomizer.Components
{
    // Classe représentant un Check qui contient un Objet
    public class GoldenSkulltulaComponent
    {
        public string Name { get; set; } = "Name";
        public string Description { get; set; } = "Description"; 
        public Token Token { get; set; }

        public GoldenSkulltulaComponent()
        {
           this.Token = new Token();
        }
        public void GiveTokenToPlayer()
        {
            // Player.Inventory.Token.AddToken();
        }

        public override string ToString()
        {
            string contenusDeLObjet = "\n -- " + this.GetType() + " -- \n";

            contenusDeLObjet +=
                "    Name : " + this.Name +
                "    Description : " + this.Description + "        " +
                "\n    -> Token : " + this.Token + "        ";

            /*
            return
                $"Name : {this.Name} \n" +
                $"Description : {this.Description} \n" +
                $"Token : {this.Token} \n";
            */

            return contenusDeLObjet;
        }
    }
}