namespace PathTrainingOoTRandomizer.Components
{
    // Classe représentant une Action Possible dans une Région
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