namespace PathTrainingOoTRandomizer.Models
{
    // Classe représentant un Check qui possède un Objet
    public class Check
    {
        public Check() { }
        public Check(string name, string description, Item item)
        {
            Name = name;
            Description = description;
            Item = item;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public Item Item { get; set; }
        public short? price;
        public string Requierement; // Peut-être Object avec Comparaison ??

        //public Component<Price> price;

        public override string ToString()
        {
            string contenusDeLObjet = "\n -- " + this.GetType() + " -- \n";

            contenusDeLObjet +=
            "     Name : " + this.Name +
            "     Description : " + this.Description +
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