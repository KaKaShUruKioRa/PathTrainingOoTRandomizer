namespace PathTrainingOoTRandomizer.Models
{
    // Classe représentant une Action Possible dans une Région
    public class Song
    {
        public string Name { get; set; } = "Name";
        public string Notes { get; set; } = "Av>^<>A^";


        public override string ToString()
        {
            string contenusDeLObjet = "\n -- " + this.GetType() + " -- \n";

            contenusDeLObjet +=
                "     Name : " + this.Name +
                "     Notes : " + this.Notes;
            /*
            return
                $"Name : {this.Name} \n" +
                $"Notes : {this.Notes} \n";
            */

            return contenusDeLObjet;
        }
    }
}