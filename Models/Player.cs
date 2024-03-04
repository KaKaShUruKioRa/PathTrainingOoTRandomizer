
namespace PathTrainingOoTRandomizer.Models
{
    public class Player
    {
        public Inventory Inventory { get; set; }

        public Region CurrentRegion { get; set; }

        public bool CanAccessRegion(Region regionName)
        {
            if (regionName.Requierement is not null)
            {
                return false;
            }
            else
                return true;
        }

        public void ChangeRegion(Region regionToGo)
        {

            CurrentRegion = regionToGo;
        }

        public override string ToString()
        {
            string contenusDeLObjet = "\n -- " + this.GetType() + " -- \n";

            contenusDeLObjet +=
                "\n    -> Inventory : " + this.Inventory +
                "\n    -> CurrentRegion : " + this.CurrentRegion;

            /*
            return
                $"Version :  {this.Inventory} \n" +
                $"Version :  {this.CurrentRegion} \n";
            */

            return contenusDeLObjet;
        }
    }
}