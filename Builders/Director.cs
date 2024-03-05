using PathTrainingOoTRandomizer.Interfaces;
using PathTrainingOoTRandomizer.Models;

namespace PathTrainingOoTRandomizer.Builders
{

    public class Director
    {
        // ======================================================================
        // -> Paramètres
        // ======================================================================
        public IBuilder Builder { set; get; }

        // ======================================================================
        // -> Méthodes de Build pour Gossip Stone
        // ======================================================================
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="text"></param>
        /// <param name="Colors"></param>
        /// <param name="HintedLocations"></param>
        /// <param name="HintedItems"></param>
        /// <param name="requierement"></param>
        public void BuildGossipStone(string name, string text, List<string> Colors, List<string> HintedLocations, List<string> HintedItems, string requierement)
        {
            var GossipStoneBuilder = (IGossipStoneBuilder)this.Builder; // Je sais pas si c'est bien autorisé ça

            GossipStoneBuilder.BuildName(name);
            GossipStoneBuilder.BuildText(text);
            GossipStoneBuilder.BuildColors(Colors);
            GossipStoneBuilder.BuildHintedLocations(HintedLocations);
            GossipStoneBuilder.BuildHintedItems(HintedItems);
            GossipStoneBuilder.BuildRequierement(requierement);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="GossipStoneConfiguration"></param>
        public void BuildGossipStone(Dictionary<string, Dictionary<string, dynamic>> GossipStoneConfiguration)
        {
            var GossipStoneBuilder = (IGossipStoneBuilder)this.Builder; // Je sais pas si c'est bien autorisé ça

            if (GossipStoneConfiguration.Count > 0)
            {
                //Name = la Key du PREMIER DIC
                GossipStoneBuilder.BuildName(GossipStoneConfiguration.First().Key);

                foreach (var element in GossipStoneConfiguration.First().Value)
                {
                    //Vérifie si la Key vaut Text et Ajoute le Texte de la GameConfig dans la futur GossipStone
                    if (element.Key == "text")
                        GossipStoneBuilder.BuildText(element.Value);

                    if (element.Key == "colors" && element.Value is Newtonsoft.Json.Linq.JArray colors)
                    {
                        List<string> colorsList = new List<string>();

                        for (int i = 0; i < colors.Count; i++)
                        {
                            colorsList.Add(colors[i].ToString());
                        }

                        GossipStoneBuilder.BuildColors(colorsList);
                    }

                    if (element.Key == "hinted_locations" && element.Value is Newtonsoft.Json.Linq.JArray hintedlocations)
                    {
                        List<string> hintedlocationsList = new List<string>();

                        for (int i = 0; i < hintedlocations.Count; i++)
                        {
                            hintedlocationsList.Add(hintedlocations[i].ToString());
                        }

                        GossipStoneBuilder.BuildHintedLocations(hintedlocationsList);
                    }

                    if (element.Key == "hinted_items" && element.Value is Newtonsoft.Json.Linq.JArray hinteditems)
                    {
                        List<string> hintedItemsList = new List<string>();

                        for (int i = 0; i < hinteditems.Count; i++)
                        {
                            hintedItemsList.Add(hinteditems[i].ToString());
                        }

                        GossipStoneBuilder.BuildHintedItems(hintedItemsList);
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="GossipStoneConfiguration"></param>
        public void BuildGossipStonesList(Dictionary<string, Dictionary<string, dynamic>> GossipStoneConfiguration)
        {
            var GossipStoneBuilder = (IGossipStoneBuilder)this.Builder; // Je sais pas si c'est bien autorisé ça

            if (GossipStoneConfiguration.Count > 0)
            {
                foreach (var element in GossipStoneConfiguration)
                {
                    //Name = la Key du PREMIER DIC
                    GossipStoneBuilder.BuildName(element.Key);

                    foreach (var elementDictionnary in element.Value)
                    {
                        //Vérifie si la Key vaut Text et Ajoute le Texte de la GameConfig dans la futur GossipStone
                        if (elementDictionnary.Key == "text")
                            GossipStoneBuilder.BuildText(elementDictionnary.Value);

                        if (elementDictionnary.Key == "colors" && elementDictionnary.Value is Newtonsoft.Json.Linq.JArray colors)
                        {
                            List<string> colorsList = new List<string>();

                            for (int i = 0; i < colors.Count; i++)
                            {
                                colorsList.Add(colors[i].ToString());
                            }
                            GossipStoneBuilder.BuildColors(colorsList);
                        }

                        if (elementDictionnary.Key == "hinted_locations" && elementDictionnary.Value is Newtonsoft.Json.Linq.JArray hintedlocations)
                        {
                            List<string> hintedlocationsList = new List<string>();

                            for (int i = 0; i < hintedlocations.Count; i++)
                            {
                                hintedlocationsList.Add(hintedlocations[i].ToString());
                            }

                            GossipStoneBuilder.BuildHintedLocations(hintedlocationsList);
                        }

                        if (elementDictionnary.Key == "hinted_items" && elementDictionnary.Value is Newtonsoft.Json.Linq.JArray hinteditems)
                        {
                            List<string> hintedItemsList = new List<string>();

                            for (int i = 0; i < hinteditems.Count; i++)
                            {
                                hintedItemsList.Add(hinteditems[i].ToString());
                            }

                            GossipStoneBuilder.BuildHintedItems(hintedItemsList);
                        }
                    }
                    GossipStoneBuilder.AddGossipStoneToList();
                }
            }
        }

        // ======================================================================
        // -> Méthodes de Build pour Item
        // ======================================================================
        /// <summary>
        /// 
        /// </summary>
        /// <param name="typeOfItem"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="isAmoutable"></param>
        /// <param name="amount"></param>
        /// <param name="maxAmount"></param>
        public void BuildItem(string typeOfItem, string name, string description, bool isAmoutable, short amount, short maxAmount)
        {
            //if (this.Builder.GetType() != IItemBuilder) {  // Verification du TYpe de Builder ?
            //return;
            //}
            //else {
            var ItemBuilder = (IItemBuilder)this.Builder; // Je sais pas si c'est bien autorisé ça
            //}
            ItemBuilder.BuildTypeOfItem(typeOfItem);
            ItemBuilder.BuildName(name);
            ItemBuilder.BuildDescription(description);
            ItemBuilder.BuildQuantity(isAmoutable, amount, maxAmount);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ItemConfiguration"></param>
        public void BuildItem(Dictionary<string, int> ItemConfiguration)
        {
            var ItemBuilder = (IItemBuilder)this.Builder; // Je sais pas si c'est bien autorisé ça

            if (ItemConfiguration.Count > 0)
            {
                string tempStringReader = ItemConfiguration.First().Key;
                // TODO : ALGORITHME QUI TRIE LES LETTRES et LES NOMBRES
                // Algorithme qui doit séparer, si des Parenthèses avec un Chiffre existe, isAmoutable = True;
                //      => le Nom (- le s du puriel) et le Chiffre pour Amount / maxAmount

                // Piste pour l'Algoritme qui trie les LETTRES et NOMBRE le STREAMREADER
                /*
                string stringtest = "Arrows (10)"
                StringReader ajidijd = new StringReader(stringtest);
                ajidijd.
                    */

                //Name = la Key du PREMIER DICT
                ItemBuilder.BuildName(ItemConfiguration.First().Key);
                //Description = la Key du PREMIER DICT
                ItemBuilder.BuildDescription(ItemConfiguration.First().Key);


                // Récupérent le Amount de l'Object Amoutable
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ItemConfiguration"></param>
        public void BuildItemsList(Dictionary<string, int> ItemConfiguration)
        {
            var ItemBuilder = (IItemBuilder)this.Builder; // Je sais pas si c'est bien autorisé ça

            if (ItemConfiguration.Count > 0)
            {
                foreach (var element in ItemConfiguration)
                {
                    string tempStringReader = element.Key;
                    // TODO : ALGORITHME QUI TRIE LES LETTRES et LES NOMBRES
                    // Algorithme qui doit séparer, si des Parenthèses avec un Chiffre existe, isAmoutable = True;
                    //      => le Nom (- le s du puriel) et le Chiffre pour Amount / maxAmount

                    // Piste pour l'Algoritme qui trie les LETTRES et NOMBRE le STREAMREADER
                    /*
                    string stringtest = "Arrows (10)"
                    StringReader ajidijd = new StringReader(stringtest);
                    ajidijd.
                        */

                    //Name = la Key du PREMIER DICT
                    ItemBuilder.BuildName(element.Key);
                    //Description = la Key du PREMIER DICT
                    ItemBuilder.BuildDescription(element.Key);

                    // Récupérent le Amount de l'Object Amoutable
                    // ItemBuilder.BuildQuantity

                    ItemBuilder.AddItemToList();
                }
            }
        }


        // ======================================================================
        // -> Méthodes de Build pour Check
        // ======================================================================
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="item"></param>
        /// <param name="price"></param>
        /// <param name="requierement"></param>
        public void BuildCheck(string name, string description, Item item, short price, string requierement)
        {
            var CheckBuilder = (ICheckBuilder)this.Builder; // Je sais pas si c'est bien autorisé ça

            CheckBuilder.BuildName(name);
            CheckBuilder.BuildDescription(description);
            CheckBuilder.BuildItem(item);
            CheckBuilder.BuildPrice(price);
            CheckBuilder.BuildRequierement(requierement);
        }

        public void BuildCheck(Dictionary<string, dynamic> CheckConfiguration)
        {
            var CheckBuilder = (ICheckBuilder)this.Builder; // Je sais pas si c'est bien autorisé ça

            if (CheckConfiguration.Count > 0)
            {
                //Name = la Key du PREMIER DICT
                CheckBuilder.BuildName(CheckConfiguration.First().Key);
                //Description = la Key du PREMIER DICT
                CheckBuilder.BuildDescription(CheckConfiguration.First().Key);

                /* 
                //MONTRER à SYLVERS IJEnumerable
                if (CheckConfiguration.First().Value is IJEnumerable<????> itemDictionnary)
                {                 
                    var stringDictionnary = new Dictionary<string, string>();

                    foreach (var element in itemDictionnary)
                    {
                        if(element.First.)
                    }
                }
                */
                if (CheckConfiguration.First().Value is Newtonsoft.Json.Linq.JContainer itemDictionnary)
                {
                    Console.WriteLine("Sommes-nous rentré ?");
                }
                else if (CheckConfiguration.First().Value is Newtonsoft.Json.Linq.JValue itemName)
                {
                    string stringItemName = itemName.ToString();
                    var itemToObtain = new Item(stringItemName, stringItemName, stringItemName);
                    CheckBuilder.BuildItem(itemToObtain);
                }
            }
        }

        public void BuildChecksList(Dictionary<string, dynamic> CheckConfiguration)
        {
            var CheckBuilder = (ICheckBuilder)this.Builder; // Je sais pas si c'est bien autorisé ça

            if (CheckConfiguration.Count > 0)
            {
                foreach (var element in CheckConfiguration)
                {
                    //Name = la Key du PREMIER DICT
                    CheckBuilder.BuildName(element.Key);
                    //Description = la Key du PREMIER DICT
                    CheckBuilder.BuildDescription(element.Key);

                    /* 
                    //MONTRER à SYLVERS IJEnumerable
                    if (CheckConfiguration.First().Value is IJEnumerable<????> itemDictionnary)
                    {                 
                        var stringDictionnary = new Dictionary<string, string>();

                        foreach (var element in itemDictionnary)
                        {
                            if(element.First.)
                        }
                    }
                    */
                    if (element.Value is Newtonsoft.Json.Linq.JObject itemDictionnary) // Ou JContainer ? (hérite de JToken/IJToken<JToken>
                    {
                        Console.WriteLine("Sommes-nous rentré ?");
                    }
                    else if (element.Value is string itemName)
                    {
                        string stringItemName = itemName.ToString();
                        var itemToObtain = new Item(stringItemName, stringItemName, stringItemName);
                        CheckBuilder.BuildItem(itemToObtain);
                    }
                    CheckBuilder.AddCheckToList();
                }
            }
        }
    }
}