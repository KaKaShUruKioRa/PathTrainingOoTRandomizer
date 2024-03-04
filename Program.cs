using PathTrainingOoTRandomizer.Helpers;
using PathTrainingOoTRandomizer.Tests;

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

            // Chemin relatif vers le fichier JSON
            string cheminFichierJson = "Ressources/Json/Untitled-1.json";

            var ha = new GameConfiguration();
            JsonHelper.Import<GameConfiguration>(cheminFichierJson, ha);


            // var gameManger = new GameManager();}

            return 0;
        }
    }
}

/*

        // Créer une région de désert en utilisant la factory
        Region desertRegion = RegionFactory.CreateDesertRegion();

        // Afficher les noms des lieux de la région de désert
        Console.WriteLine($"Lieux de la région de désert '{desertRegion.Name}':");
        foreach (var location in desertRegion.Locations)
        {
            Console.WriteLine(location.Name);
        }

        // Méthode pour charger les données à partir du fichier JSON
        static Region[] LoadRegions(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Region[]>(json);
        }

        // Méthode pour afficher les informations sur une région
        static void DisplayRegionInfo(Region region)
        {
            Console.WriteLine($"Nom : {region.Name}");
            Console.WriteLine($"Description : {region.Description}");
            // Affiche d'autres propriétés selon la structure de ta classe Region
        }

        // Chemin vers le fichier JSON contenant les données des régions
        string jsonFilePath = "regions.json";

        // Charge les régions à partir du fichier JSON
        Region[] regions = LoadRegions("jsontoread/test.json");

        // Affiche un message d'accueil
        Console.WriteLine("Bienvenue dans le jeu inspiré de Ocarina of Time Randomizer !");

        // Boucle principale du jeu
        while (true)
        {
            // Affiche les options disponibles pour l'utilisateur
            Console.WriteLine("\nQue voulez-vous faire ?");
            Console.WriteLine("1. Afficher les informations sur une région");
            Console.WriteLine("2. Quitter");

            // Lit le choix de l'utilisateur
            string choice = Console.ReadLine();

            // Traite le choix de l'utilisateur
            switch (choice)
            {
                case "1":
                    // Affiche les informations sur une région
                    Console.WriteLine("Entrez le nom de la région :");
                    string regionName = Console.ReadLine();
                    Region selectedRegion = Array.Find(regions, r => r.Name.Equals(regionName, StringComparison.OrdinalIgnoreCase));
                    if (selectedRegion != null)
                    {
                        DisplayRegionInfo(selectedRegion);
                    }
                    else
                    {
                        Console.WriteLine("Région non trouvée !");
                    }
                    break;
                case "2":
                    // Quitte le jeu
                    Console.WriteLine("Merci d'avoir joué !");
                    return;
                default:
                    Console.WriteLine("Choix invalide !");
                    break;
            }
        }
<<<<<<< HEAD
        */
=======
    }
}
>>>>>>> 51f161f (Organisation des Dossiers et Fichiers + Début de Code pour Lire/Ecrire des Fichiers .json)
