
using PathTrainingOoTRandomizer.Components;

namespace PathTrainingOoTRandomizer.Models
{
    public class Inventory
    {
        short numberOfRupees = 0;
        public Rupee Rupees { set; get; }

        short numberOfTokens = 0;
        public Token Tokens { set; get; }


        public List<Item> Items;
        public List<SongComponent> Songs;
        public List<QuestItem> QuestItem;

        public override string ToString()
        {
            string contenusDeLObjet = "\n -- " + this.GetType() + " -- \n";

            contenusDeLObjet +=
                "    numberOfRupees : " + this.numberOfRupees +
                "\n    -> numberOfRupees : " + this.Rupees +
                "    numberOfRupees : " + this.numberOfTokens +
                "\n    -> Tokens : " + this.Tokens;
            contenusDeLObjet += "\n    -> Items :        ";
            if (this.Items != null)
            {
                foreach (var element in this.Items)
                {
                    contenusDeLObjet += element;
                }
            }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "\n    -> Items :        ";
            if (this.Songs != null)
            {
                foreach (var element in this.Songs)
                {
                    contenusDeLObjet += element;
                }
            }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "\n    -> Items :        ";
            if (this.QuestItem != null)
            {
                foreach (var element in this.QuestItem)
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
                 $"Version : {this.numberOfRupees} \n" +
                 $"Version : {this.Rupees} \n" +
                 $"Version : {this.numberOfTokens} \n" +
                 $"Version : {this.Tokens} \n" +
                 $"Version : {this.Items} \n" +
                 $"Version : {this.Songs} \n" +
                 $"Version : {this.QuestItem} \n";
            */

            return contenusDeLObjet;
        }
    }
}