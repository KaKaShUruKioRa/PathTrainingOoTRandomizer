
using PathTrainingOoTRandomizer.Components;

namespace PathTrainingOoTRandomizer.Models
{
    public class Boss
    {
        public string Name { get; set; } = "Name";        
        public string Description { get; set; } = "Description";

        public CheckComponent Check { get; set; }

        public QuestItem QuestItem { get; set; }

        public override string ToString()
        {
            string contenusDeLObjet = "";

            contenusDeLObjet += "Name : " + this.Name;
            contenusDeLObjet += "Description : " + this.Description;
            contenusDeLObjet += "Check : " + this.Check;
            contenusDeLObjet += "QuestItem : " + this.QuestItem;

            return
                $"Name : {this.Name} \n" +
                $"Description : {this.Description} \n" +
                $"Check : {this.Check} \n" +
                $"QuestItem : {this.QuestItem} \n";

            return contenusDeLObjet;
        }
    }
}