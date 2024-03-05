using PathTrainingOoTRandomizer.Interfaces;
using PathTrainingOoTRandomizer.Models;
using System.Xml.Linq;

namespace PathTrainingOoTRandomizer.Builders
{
    // Builder pour construire des régions
    public class ItemBuilder : IItemBuilder
    {
        private Item Item = new Item();
        private List<Item> ItemsList = new List<Item>();

        public ItemBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.Item = new Item();
        }

        // ======================================================================
        // -> Méthodes de l'Inferface IbuilderItem
        // ======================================================================
        public void BuildTypeOfItem(string name)
        {
            this.Item.typeOfItem = name;
        }
        public void BuildName(string name)
        {
            this.Item.Name = name;
        }
        public void BuildDescription(string description)
        {
            this.Item.Description = description;
        }
        public void BuildQuantity(bool isAmountable, short amount, short maxAmount)
        {

            if (this.Item.isAmountable = isAmountable)
            {
                this.Item.amount = amount;
                this.Item.maxAmount = maxAmount;
            }
        }


        // ======================================================================
        // -> IBuilder
        // ======================================================================
        public void AddItemToList()
        {
            this.ItemsList.Add(this.Item);
            Reset();
        }
        public Item GetItem()
        {
            return this.Item;
        }
        public List<Item> GetItemsList()
        {
            return this.ItemsList;
        }

        // ======================================================================
        // -> Méthode d'Interface pour IBuilder ??? Generic ???
        // ======================================================================
        public void AddObjectToList()
        {
            this.ItemsList.Add(this.Item);
        }

        public object GetObject()
        {
            return this.Item;
        }

        public List<object> GetObjectsList()
        {
            List<object> ObjectsList = new List<object>();

            if (this.ItemsList.Count > 0)
            {

                foreach (var element in this.ItemsList)
                {
                    ObjectsList.Add((Item)element);
                }
            }

            return ObjectsList;
        }
    }
}