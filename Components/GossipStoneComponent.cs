namespace PathTrainingOoTRandomizer.Components
{
    // Classe représentant un GossipStone (Contient un Hint)
    public class GossipStoneComponent
    {

        public GossipStoneComponent(string text, List<string> colors, List<string> hintedLocations, List<string> hintedItems)
        {
            Text = text;
            Colors = new List<string>(colors);
            HintedLocations = new List<string>(hintedLocations);
            HintedItems = new List<string>(hintedItems);
        }

        public string Text { get; set; }
        public List<string> Colors { get; set; }
        public List<string> HintedLocations { get; set; }
        public List<string> HintedItems { get; set; }

        public override string ToString()
        {
            string contenusDeLObjet = "\n -- " + this.GetType() + " -- \n";

            contenusDeLObjet +=
                "    Text : " + this.Text;

            contenusDeLObjet += "\n    -> Colors :        ";
            if (this.Colors != null)
            {
                foreach (var element in this.Colors)
                {
                    contenusDeLObjet += element;
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