using PathTrainingOoTRandomizer.Helpers;
using PathTrainingOoTRandomizer.Models;

namespace PathTrainingOoTRandomizer.Tests
{
    public static class JsonTests
    {

        public static bool JsonTest()
        {
            var answerOfTester = "";

            // ====================================================================================
            // TEST 1 
            // ====================================================================================

            Console.Clear();
            Console.WriteLine("Continuer ? (continue, yes, y, oui, o, no, non, n, stop)");
            answerOfTester = Console.ReadLine().ToLower();

            if (answerOfTester == "continue" || answerOfTester == "c" || answerOfTester == "yes" || answerOfTester == "y" || answerOfTester == "oui" || answerOfTester == "o")
            {
                Console.WriteLine("Test 1 : \n");
                Console.WriteLine("Resultat : " + DeserializeFromJsonFile() + "\n");
            }
            else if (answerOfTester == "stop")
            {
                return false;
            }
            else if (answerOfTester == "non" || answerOfTester == "no " || answerOfTester == "n") { }
            Console.WriteLine("Fin Test 1 : \n");

            // ====================================================================================
            // TEST 2
            // ====================================================================================

            Console.Clear();
            Console.WriteLine("Continuer ? (continue, yes, y, oui, o, no, non, n, stop)");
            answerOfTester = Console.ReadLine().ToLower();

            if (answerOfTester == "continue" || answerOfTester == "c" || answerOfTester == "yes" || answerOfTester == "y" || answerOfTester == "oui" || answerOfTester == "o")
            {
                Console.WriteLine("Test 2 : \n");
                Console.WriteLine("Resultat : " + SerializeJson() + "\n");
            }
            else if (answerOfTester == "stop")
            {
                Console.Clear();
                return false;
            }
            else if (answerOfTester == "non" || answerOfTester == "no " || answerOfTester == "n") { }
            Console.WriteLine("Fin Test 2 : \n");

            // ====================================================================================
            // TEST 3
            // ====================================================================================


            Console.Clear();
            Console.WriteLine("Continuer ? (continue, yes, y, oui, o, no, non, n, stop)");
            answerOfTester = Console.ReadLine().ToLower();

            string jsonString = JsonHelper.Serialize(CreateObjectToTest(536147153));

            if (answerOfTester == "continue" || answerOfTester == "c" || answerOfTester == "yes" || answerOfTester == "y" || answerOfTester == "oui" || answerOfTester == "o")
            {
                Console.WriteLine("Test 3 : \n");
                Console.WriteLine("Resultat : " + DeserializeFromJsonString(jsonString) + "\n");
            }
            else if (answerOfTester == "stop")
            {
                return false;
            }
            else if (answerOfTester == "non" || answerOfTester == "no " || answerOfTester == "n") { }
            Console.WriteLine("Fin Test 3 : \n");

            // ====================================================================================
            // TEST 4
            // ====================================================================================

            Console.Clear();
            Console.WriteLine("Continuer ? (continue, yes, y, oui, o, no, non, n, stop)");
            answerOfTester = Console.ReadLine().ToLower();

            if (answerOfTester == "continue" || answerOfTester == "c" || answerOfTester == "yes" || answerOfTester == "y" || answerOfTester == "oui" || answerOfTester == "o")
            {
                Console.WriteLine("Test 4 : \n");
                if (ExportJson())
                {
                    Console.WriteLine("Resultat : " + "Fichier Exporté depuis l'Objet de Test\n");
                }
            }
            else if (answerOfTester == "stop")
            {
                return false;
            }
            else if (answerOfTester == "non" || answerOfTester == "no " || answerOfTester == "n") { }
            Console.WriteLine("Fin Test 4 : \n");

            // ====================================================================================
            // TEST 5
            // ====================================================================================

            Console.Clear();
            Console.WriteLine("Continuer ? (continue, yes, y, oui, o, no, non, n, stop)");
            answerOfTester = Console.ReadLine().ToLower();

            if (answerOfTester == "continue" || answerOfTester == "c" || answerOfTester == "yes" || answerOfTester == "y" || answerOfTester == "oui" || answerOfTester == "o")
            {
                Console.WriteLine("Test 5 : \n");
                if (ImportJson())
                {
                    Console.WriteLine("Resultat : " + "Fichier Importé dans l'Objet de Test \n");
                }
            }
            else if (answerOfTester == "stop")
            {
                return false;
            }
            else if (answerOfTester == "non" || answerOfTester == "no " || answerOfTester == "n") { }
            Console.WriteLine("Fin Test 5 : \n");

            return true;
        }
        public static Game CreateObjectToTest(int Id)
        {
            var gameObjectToSerialize = new Game();

            gameObjectToSerialize.Name = "Game.Name JsonTests Serialize";
            gameObjectToSerialize.Description = "Game.Description JsonTests Serialize";
            gameObjectToSerialize.Id = Id;
            gameObjectToSerialize.Player = new Player();
            gameObjectToSerialize.World = new World();

            return gameObjectToSerialize;
        }

        public static Game DeserializeFromJsonFile()
        {
            Console.WriteLine("==========================================================================================");
            Console.WriteLine("Test de Deserialisation depuis un Fichier.json :");
            Console.WriteLine("==========================================================================================");

            Console.WriteLine("Creation de l'Objet de Test...");
            var objectDeTest = new Game();
            Console.WriteLine("Création Réussi : " + objectDeTest.GetType() + objectDeTest.GetHashCode());

            Console.WriteLine("");
            Console.WriteLine("-- Fin du Test de Deserialisation -- ");
            Console.WriteLine("==========================================================================================");

            return objectDeTest = JsonHelper.DeserializeFromFile<Game>("JsonTests/DeserializeJsonTest.json");

        }
        public static Game DeserializeFromJsonString(string jsonString)
        {
            Console.WriteLine("==========================================================================================");
            Console.WriteLine("Test de Deserialisation depuis un (json)String :");
            Console.WriteLine("==========================================================================================");

            Console.WriteLine("Creation de l'Objet de Test...");
            var objectDeTest = new Game();
            Console.WriteLine("Création Réussi : " + objectDeTest.GetType() + objectDeTest.GetHashCode());

            Console.WriteLine("");
            Console.WriteLine("-- Fin du Test de Deserialisation -- ");
            Console.WriteLine("==========================================================================================");

            return objectDeTest = JsonHelper.DeserializeFromString<Game>(jsonString);
        }

        public static string SerializeJson()
        {
            Console.WriteLine("==========================================================================================");
            Console.WriteLine("Test de Serialisation :");
            Console.WriteLine("==========================================================================================");

            Console.WriteLine("Creation de l'Objet de Test...");
            var objectDeTest = new Game();
            Console.WriteLine("Création Réussi : " + objectDeTest.GetType() + objectDeTest.GetHashCode());

            Console.WriteLine("Configuration des Variables de l'Objet de Test...");
            objectDeTest = CreateObjectToTest(735753614);
            Console.WriteLine("Paramétrage Terminé !");

            Console.WriteLine("");
            Console.WriteLine("-- Fin du Test de Serialisation -- ");
            Console.WriteLine("==========================================================================================");
            return JsonHelper.Serialize(objectDeTest);
        }

        public static bool ExportJson()
        {
            Console.WriteLine("==========================================================================================");
            Console.WriteLine("Test d'Exportation de Json :");
            Console.WriteLine("==========================================================================================");

            Console.WriteLine("Deserialisation d'un Objet de Test...");
            var objectDeTest = DeserializeFromJsonFile();
            Console.WriteLine("Deserialisation Réussi : " + objectDeTest.GetType() + objectDeTest.GetHashCode());

            Console.WriteLine("Exportation de l'Object de Test avec Relativ Path...");
            JsonHelper.ExportObject("JsonTests/ExportJsonTest1.json", objectDeTest);
            Console.WriteLine("Exportation Réussi !");

            Console.WriteLine("Exportation de l'Object de Test avec Directory + FileName...");
            JsonHelper.ExportObject("JsonTests/", "ExportJsonTest2.json", objectDeTest);
            Console.WriteLine("Exportation Réussi !");

            Console.WriteLine("Exportation d'un JsonString Serialisé depuis une SerialisationJson avec Relativ Pat ...");
            JsonHelper.ExportSerializedString("JsonTests/ExportJsonFromStringTest1.json", JsonHelper.Serialize(CreateObjectToTest(536147153)));
            Console.WriteLine("Exportation Réussi !");

            Console.WriteLine("Exportation d'un JsonString Serialisé depuis une SerialisationJson avec Diretory + FileName ...");
            JsonHelper.ExportSerializedString("JsonTests/", "ExportJsonFromStringTest2.json", JsonHelper.Serialize(CreateObjectToTest(536147153)));
            Console.WriteLine("Exportation Réussi !");

            Console.WriteLine("");
            Console.WriteLine("-- Fin Du Test d'Exportation de Json -- ");
            Console.WriteLine("==========================================================================================");

            return true;
        }

        public static bool ImportJson()
        {
            Console.WriteLine("==========================================================================================");
            Console.WriteLine("Test d'Importation de Json :");
            Console.WriteLine("==========================================================================================");

            Console.WriteLine("Creation de l'Objet de Test...");
            var objectDeTest = new Game();
            Console.WriteLine("Création Réussi : " + objectDeTest.GetType() + objectDeTest.GetHashCode());

            Console.WriteLine("Importation des Variables de l'Objet de Test depuis le JsonTest avec Directoy + Filename...");
            objectDeTest = JsonHelper.Import("JsonTests/", "ImportJsonTest1.json", objectDeTest);
            Console.WriteLine("Exportation Réussi !");
            Console.WriteLine(objectDeTest);

            Console.WriteLine("Importation des Variables de l'Objet de Test depuis le JsonTest avec RelativPath...");
            objectDeTest = JsonHelper.Import("JsonTests/ImportJsonTest2.json", objectDeTest);
            Console.WriteLine("Exportation Réussi !");
            Console.WriteLine(objectDeTest);

            Console.WriteLine("Importation des Variables de l'Objet de Test par Generic Method <T> depuis le JsonTest avec Directoy + Filename...");
            objectDeTest = JsonHelper.Import<Game>("JsonTests/", "ImportJsonTest1.json", objectDeTest);
            Console.WriteLine("Exportation Réussi !");
            Console.WriteLine(objectDeTest);

            Console.WriteLine("Importation des Variables de l'Objet de Test par Generic Method <T> depuis le JsonTest avec RelativPath...");
            objectDeTest = JsonHelper.Import<Game>("JsonTests/ImportJsonTest2.json", objectDeTest);
            Console.WriteLine("Exportation Réussi !");
            Console.WriteLine(objectDeTest);

            Console.WriteLine("");
            Console.WriteLine("-- Fin Du Test d'Importation de Json -- ");
            Console.WriteLine("==========================================================================================");

            return true;
        }
    }
}
