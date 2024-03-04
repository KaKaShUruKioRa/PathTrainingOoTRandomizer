namespace PathTrainingOoTRandomizer.Models
{
    // Classe représentant un Check qui possède un Objet
    public class Check
    {
        public Check(string name, string description, string item)
        {
            Name = name;
            Description = description;
            Item = item;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Item { get; set; }
        // Autres attributs selon tes besoins

        public override string ToString()
        {
            string contenusDeLObjet = "\n -- " + this.GetType() + " -- \n";

            contenusDeLObjet +=
            "     Name : " + this.Name +
            "     Desciption : " + this.Description +
            "     Item : " + this.Item;

            /*
            return
                $"Name : {this.Name} \n" +
                $"Description : {this.Description} \n" +
                $"Item : {this.Item} \n";
            */

            return contenusDeLObjet;
        }
    }
}