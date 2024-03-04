
namespace PathTrainingOoTRandomizer.Models
{    public class QuestItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Quest Item";
        public string Description { get; set; } = "Description";

        public override string ToString()
        {
            string contenusDeLObjet = "\n -- " + this.GetType() + " -- \n";

            contenusDeLObjet +=
                "    Id : " + this.Id +
                "    Name : " + this.Name +
                "    Description : " + this.Description;

            /*
            return
                $"Id : {this.Id} \n" +
                $"Name : {this.Name} \n" +
                $"Description : {this.Description} \n";
            */

            return contenusDeLObjet;
        }
    }
}