using PathTrainingOoTRandomizer.Models;

namespace PathTrainingOoTRandomizer.Interfaces
{
    public interface IBuilder
    {
        void AddObjectToList();
        object GetObject();
        List<object> GetObjectsList();
    }

    public interface IGossipStoneBuilder : IBuilder
    {
        void BuildName(string name);
        void BuildText(string text);
        void BuildColors(List<string> Colors);
        void BuildHintedLocations(List<string> HintedLocations);
        void BuildHintedItems(List<string> HintedItem);
        void BuildRequierement(string requierement);
        void AddGossipStoneToList(); // Peut être à supprimé ? (Si Generic IBuilder)
    }

    public interface IItemBuilder : IBuilder
    {
        void BuildTypeOfItem(string typeOfItem);
        void BuildName(string name);
        void BuildDescription(string description);
        void BuildQuantity(bool isAmountable, short amount, short maxAmount);
        void AddItemToList(); // Peut être à supprimé ? (Si Generic IBuilder)
    }

    public interface ICheckBuilder : IBuilder
    {
        void BuildName(string name);
        void BuildDescription(string description);
        void BuildItem(Item item);
        void BuildPrice(short price);
        void BuildRequierement(string Requierement);
        void AddCheckToList(); // Peut être à supprimé ? (Si Generic IBuilder)
    }
}