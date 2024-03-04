namespace PathTrainingOoTRandomizer.Components
{
    // Classe repr�sentant une Action Possible dans une R�gion
    public class PossibleActionComponent
    {        
        public string Name { get; set; } = "Name";
        public string Description { get; set; } = "Description";

        public override string ToString()
        {
            string contenusDeLObjet = "\n -- " + this.GetType() + " -- \n";

            contenusDeLObjet += 
                "    Name : " + this.Name + "\n" + 
                "    Description : " + this.Description + "\n";
            /*
            return
                $"Name : {this.Name} \n" +
                $"Description : {this.Description} \n";
            */

            return contenusDeLObjet;
        }
    }
}