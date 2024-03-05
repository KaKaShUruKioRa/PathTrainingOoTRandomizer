using PathTrainingOoTRandomizer.Interfaces;
using PathTrainingOoTRandomizer.Models;

namespace PathTrainingOoTRandomizer.Builders
{
    // Builder pour construire des régions
    public class GossipStoneBuilder : IGossipStoneBuilder
    {
        private GossipStone GossipStone = new GossipStone();
        private List<GossipStone> GossipStonesList = new List<GossipStone>();

        public GossipStoneBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.GossipStone = new GossipStone();
        }
        public void BuildName(string name)
        {
            this.GossipStone.Name = name;
        }
        public void BuildText(string text)
        {
            this.GossipStone.Text = text;
        }
        public void BuildColors(List<string> Colors)
        {
            this.GossipStone.Colors = Colors;
        }
        public void BuildHintedLocations(List<string> HintedLocations)
        {
            this.GossipStone.HintedLocations = HintedLocations;
        }
        public void BuildHintedItems(List<string> HintedItems)
        {
            this.GossipStone.HintedItems = HintedItems;
        }
        public void BuildRequierement(string Requierement)
        {
            this.GossipStone.Requierement = Requierement;
        }
        public void AddGossipStoneToList()
        {
            this.GossipStonesList.Add(this.GossipStone);
            Reset();
        }

        // ======================================================================
        // -> Méthode d'Interface pour IBuilder ??? Generic ???
        // ======================================================================
        public GossipStone GetGossipStone()
        {
            return this.GossipStone;
        }

        public List<GossipStone> GetGossipStonesList()
        {
            return this.GossipStonesList;
        }

        // ======================================================================
        // -> Méthode d'Interface pour IBuilder ??? Generic ???
        // ======================================================================
        public void AddObjectToList()
        {
            this.GossipStonesList.Add(this.GossipStone);
        }

        public object GetObject()
        {
            return this.GossipStone;
        }

        public List<object> GetObjectsList()
        {
            List<object> ObjectsList = new List<object>();

            if (this.GossipStonesList.Count > 0)
            {

                foreach (var element in this.GossipStonesList)
                {
                    ObjectsList.Add((GossipStone)element);
                }
            }

            return ObjectsList;
        }
    }
    /*
    public class Director
    {
        public IGossipStoneBuilder Builder { set; get; }

        public void BuildGossipStone(string name, string text, List<string> Colors, List<string> HintedLocations, List<string> HintedItems, string requierement)
        {
            this.Builder.BuildName(name);
            this.Builder.BuildText(text);
            this.Builder.BuildColors(Colors);
            this.Builder.BuildHintedLocations(HintedLocations);
            this.Builder.BuildHintedItems(HintedItems);
            this.Builder.BuildRequierement(requierement);
        }
        public void BuildGossipStone(Dictionary<string, Dictionary<string, dynamic>> GossipStoneConfiguration)
        {
            if (GossipStoneConfiguration.Count > 0)
            {
                //Name = la Key du PREMIER DIC
                this.Builder.BuildName(GossipStoneConfiguration.First().Key);

                foreach (var element in GossipStoneConfiguration.First().Value)
                {
                    //Vérifie si la Key vaut Text et Ajoute le Texte de la GameConfig dans la futur GossipStone
                    if (element.Key == "text")
                        this.Builder.BuildText(element.Value);

                    if (element.Key == "colors" && element.Value is Newtonsoft.Json.Linq.JArray colors)
                    {
                        List<string> colorsList = new List<string>();

                        for (int i = 0; i < colors.Count; i++)
                        {
                            colorsList.Add(colors[i].ToString());
                        }

                        this.Builder.BuildColors(colorsList);
                        Console.WriteLine("Colors !??");
                    }

                    if (element.Key == "hinted_locations" && element.Value is Newtonsoft.Json.Linq.JArray hintedlocations)
                    {
                        List<string> hintedlocationsList = new List<string>();

                        for (int i = 0; i < hintedlocations.Count; i++)
                        {
                            hintedlocationsList.Add(hintedlocations[i].ToString());
                        }

                        this.Builder.BuildHintedLocations(hintedlocationsList);
                        Console.WriteLine("Hinted Location !??");
                    }

                    if (element.Key == "hinted_items" && element.Value is Newtonsoft.Json.Linq.JArray hinteditems)
                    {
                        List<string> hintedItemsList = new List<string>();

                        for (int i = 0; i < hinteditems.Count; i++)
                        {
                            hintedItemsList.Add(hinteditems[i].ToString());
                        }

                        this.Builder.BuildHintedItems(hintedItemsList);
                        Console.WriteLine("Hinted Items !??");
                    }
                }
            }
        }

        public void BuildGossipStonesList(Dictionary<string, Dictionary<string, dynamic>> GossipStoneConfiguration)
        {
            if (GossipStoneConfiguration.Count > 0)
            {
                foreach (var element in GossipStoneConfiguration)
                {
                    //Name = la Key du PREMIER DIC
                    this.Builder.BuildName(element.Key);

                    foreach (var elementDictionnary in element.Value)
                    {
                        //Vérifie si la Key vaut Text et Ajoute le Texte de la GameConfig dans la futur GossipStone
                        if (elementDictionnary.Key == "text")
                            this.Builder.BuildText(elementDictionnary.Value);

                        if (elementDictionnary.Key == "colors" && elementDictionnary.Value is Newtonsoft.Json.Linq.JArray colors)
                        {
                            List<string> colorsList = new List<string>();

                            for (int i = 0; i < colors.Count; i++)
                            {
                                colorsList.Add(colors[i].ToString());
                            }
                            this.Builder.BuildColors(colorsList);
                        }

                        if (elementDictionnary.Key == "hinted_locations" && elementDictionnary.Value is Newtonsoft.Json.Linq.JArray hintedlocations)
                        {
                            List<string> hintedlocationsList = new List<string>();

                            for (int i = 0; i < hintedlocations.Count; i++)
                            {
                                hintedlocationsList.Add(hintedlocations[i].ToString());
                            }

                            this.Builder.BuildHintedLocations(hintedlocationsList);
                        }

                        if (elementDictionnary.Key == "hinted_items" && elementDictionnary.Value is Newtonsoft.Json.Linq.JArray hinteditems)
                        {
                            List<string> hintedItemsList = new List<string>();

                            for (int i = 0; i < hinteditems.Count; i++)
                            {
                                hintedItemsList.Add(hinteditems[i].ToString());
                            }

                            this.Builder.BuildHintedItems(hintedItemsList);
                        }
                    }
                    this.Builder.IGossipStoneToList();
                }
            }
        }
    }
    */
}