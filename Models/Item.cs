namespace PathTrainingOoTRandomizer.Models
{
    public class Item
    {
        public Item()
        {
        }
        public Item(string typeOfItem, string name, string description)
        {
            this.typeOfItem = typeOfItem;
            this.Name = name;
            this.Description = description;
        }

        // Probable Classe Mere pour =>
        //   Classe Fille "Majeur", "Junk", "QuestItem", "Hearts", "Ruppe"
        public string typeOfItem { get; set; } // To Replace with Heritage
        public string Name { get; set; }
        public string Description { get; set; }
        public bool isAmountable { get; set; } = false;
        public short? amount { get; set; }
        public short? maxAmount { get; set; }

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
                "    Type of Item : " + this.typeOfItem +
                "    Name : " + this.Name +
                "    Description : " + this.Description +
                "    Is Amountable : " + this.isAmountable +
                "    Amount : " + this.amount +
                "    Max Amount : " + this.maxAmount;

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
