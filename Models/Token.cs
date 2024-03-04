namespace PathTrainingOoTRandomizer.Models
{
    public class Token
    {
        public short number = 0;
        public short maxNumber = 100;

        public void AddToken()
        {
            this.number += 1;
        }
        public override string ToString()
        {
            string contenusDeLObjet = "----\n";

            contenusDeLObjet += "number : " + this.number + "\n";
            contenusDeLObjet += "maxNumber : " + this.maxNumber + "\n";

            /*
            return
                $"number : {this.number} \n" +
                $"maxNumber : {this.maxNumber} \n";
            */

            return contenusDeLObjet;
        }
    }
}
