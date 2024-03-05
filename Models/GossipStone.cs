using PathTrainingOoTRandomizer.Builders;
using PathTrainingOoTRandomizer.Factories;
using PathTrainingOoTRandomizer.Helpers;
using static System.Net.Mime.MediaTypeNames;

namespace PathTrainingOoTRandomizer.Models
{
    // Classe représentant un GossipStone (Contient un Hint)
    public class GossipStone 
        /*: IProduct*/
    {
    public GossipStone()
        {
        }

        public GossipStone(string text, List<string> colors, List<string> hintedLocations, List<string> hintedItems)
        {
            Text = text;
            Colors = new List<string>(colors);
            HintedLocations = new List<string>(hintedLocations);
            HintedItems = new List<string>(hintedItems);
        }

        public string Name { get; set; }
        public string Text { get; set; }
        public List<string> Colors { get; set; } = new List<string>();
        public List<string> HintedLocations { get; set; } = new List<string>();
        public List<string> HintedItems { get; set; } = new List<string>();
        public string Requierement { get; set; }

        /*
        public GossipStone Operation()
        {
            var builderForGossipStone = new GossipStoneBuilder();
            var directorForGossipStone = new Director();
            directorForGossipStone.Builder = builderForGossipStone;

            directorForGossipStone.BuildGossipStone(gameConfiguration.gossip_stones);

            return builderForGossipStone.GetGossipStone();
        }
        */

        // ==================================================================
        // Surcharge Opérateur ToString();
        // ==================================================================
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string contenusDeLObjet = "\n -- " + this.GetType() + " -- \n";

            contenusDeLObjet +=
                "    Text : " + this.Text;
            contenusDeLObjet += "\n    -> Colors :        ";
            if (this.Colors.Count != 0)
            {
                foreach (var element in this.Colors)
                {
                    contenusDeLObjet += element + " - ";
                }
            }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "\n    -> Hinted Locations :        ";
            if (this.HintedLocations != null)
            {
                foreach (var element in this.HintedLocations)
                {
                    contenusDeLObjet += element;
                }
            }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "\n    -> Hinted Items :        ";
            if (this.HintedItems != null)
            {
                foreach (var element in this.HintedItems)
                {
                    contenusDeLObjet += element;
                }
            }
            else
            {
                contenusDeLObjet += "\n";
            }

            /*
            return
                $"Text : {this.Text} \n" +
                $"Colors : {this.Colors} \n" +
                $"HintedLocations : {this.HintedLocations} \n" +
                $"HintedItems : {this.HintedItems} \n";
            */

            return contenusDeLObjet;
        }
    }
}