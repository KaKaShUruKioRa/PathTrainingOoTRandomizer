
namespace PathTrainingOoTRandomizer.Models
{
    public class Item
    {

        public Item()
        {
            Console.WriteLine("hello");
        
        }
        public string typeOfItem { get; set; } = "Major";
        public string Name { get; set; } = "Item";
        public string Description { get; set; } = "Description";

        public bool isAmountable { get; set; } = false;
        public short amount { get; set; }
        public short maxAmount { get; set; }

    }
}
