using PathTrainingOoTRandomizer.Interfaces;
using PathTrainingOoTRandomizer.Models;

namespace PathTrainingOoTRandomizer.Builders
{
    // Builder pour construire des régions
    public class CheckBuilder : ICheckBuilder
    {

        // ======================================================================
        // -> Paramètres
        // ======================================================================
        private Check Check = new Check();
        private List<Check> ChecksList = new List<Check>();


        // ======================================================================
        // -> Constructeur
        // ======================================================================
        public CheckBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.Check = new Check();
        }

        // ======================================================================
        // -> Méthodes de l'Inferface IbuilderCheck
        // ======================================================================

        public void BuildName(string name)
        {
            this.Check.Name = name;
        }
        public void BuildDescription(string description)
        {
            this.Check.Description = description;
        }
        public void BuildItem(Item item)
        {
            this.Check.Item = item;
        }

        public void BuildPrice(short price)
        {
            this.Check.price = price;
        }
        public void BuildRequierement(string Requierement)
        {
            this.Check.Requierement = Requierement;
        }

        // ======================================================================
        // -> IBuilder
        // ======================================================================
        public void AddCheckToList()
        {
            this.ChecksList.Add(this.Check);
            Reset();
        }
        public Check GetCheck()
        {
            return this.Check;
        }
        public List<Check> GetChecksList()
        {
            return this.ChecksList;
        }

        // ======================================================================
        // -> Méthode d'Interface pour IBuilder ??? Generic ???
        // ======================================================================
        public void AddObjectToList()
        {
            this.ChecksList.Add(this.Check);
        }

        public object GetObject()
        {
            return this.Check;
        }

        public List<object> GetObjectsList()
        {
            List<object> ObjectsList = new List<object>();

            if (this.ChecksList.Count > 0)
            {

                foreach (var element in this.ChecksList)
                {
                    ObjectsList.Add((Check)element);
                }
            }

            return ObjectsList;
        }
    }
}