using PathTrainingOoTRandomizer.Builders;
using PathTrainingOoTRandomizer.Helpers;
using PathTrainingOoTRandomizer.Managers;
using PathTrainingOoTRandomizer.Models;
using PathTrainingOoTRandomizer.Tests;
using System.Xml.Linq;

namespace KaKaShUruKioRa
{
    class Program
    {
        static int Main(string[] args)
        {
            var testing = false;

            Console.WriteLine("Entrer dans la Session Test !?");
            switch (Console.ReadLine().ToLower())
            {
                case "y":
                    testing = true;
                    break;
                case "yes":
                    testing = true;
                    break;
                case "o":
                    testing = true;
                    break;
                case "oui":
                    testing = true;
                    break;
                case "n":
                    testing = false;
                    break;
                case "no":
                    testing = false;
                    break;
                case "non":
                    testing = false;
                    break;
                default:
                    testing = false;
                    break;
            }

            if (testing)
            {
                if (!JsonTests.JsonTest())
                {
                    throw new Exception("Test Non Réussi");
                    return 3993;
                }
                else
                {
                    return 5;
                }
            }

            TestBuilder();

            /*           
            var gameConfig = new GameConfiguration();
            gameConfig.settings.Add("user_message", "OoTr League S5");
            gameConfig.settings.Add("reachable_locations", "beatable League S5");

            JsonHelper.ExportObject(relativPath, gameConfig);
            */

            var gameManger = new GameManager();

            return 0;
        }
        public static void TestBuilder()
        {
            // Chemin relatif vers le fichier JSON
            string cheminFichierJson = "Ressources/Json/Untitled-2.json";

            var gameConfiguration = JsonHelper.Import<GameConfiguration>(cheminFichierJson, new GameConfiguration());

            var builderForGossipStone = new GossipStoneBuilder();
            var builderForItem = new ItemBuilder();
            var builderForCheck = new CheckBuilder();
            var directorOfBUilder = new Director();

            directorOfBUilder.Builder = builderForGossipStone;
            directorOfBUilder.BuildGossipStonesList(gameConfiguration.gossip_stones);

            directorOfBUilder.Builder = builderForItem;
            directorOfBUilder.BuildItemsList(gameConfiguration.item_pool);

            directorOfBUilder.Builder = builderForCheck;
            directorOfBUilder.BuildChecksList(gameConfiguration.locations);

            var gossipStonesList = builderForGossipStone.GetGossipStonesList();
            var itemsList = builderForItem.GetItemsList();
            var checksList = builderForCheck.GetChecksList();

            foreach (var elementList in gossipStonesList)
            {
                Console.WriteLine(elementList);
            }
            foreach (var elementList in itemsList)
            {
                Console.WriteLine(elementList);
            }
            foreach (var elementList in checksList)
            {
                Console.WriteLine(elementList);
            }


            /*
            foreach (var element in gameConfiguration.gossip_stones)
            {
                directorForGossipStone.BuildGossipStone(element., Colors, HintedLocations, HintedItems, requierement);
            }
            */
        }
    }
}