using Newtonsoft.Json;

namespace PathTrainingOoTRandomizer.Helpers
{
    public static class JsonHelper
    {
        public static T DeserializeFromString<T>(string jsonString)
        {
            if (jsonString != "")
            {
                var deserializedObject = JsonConvert.DeserializeObject<T>(jsonString);

                return deserializedObject;
            }
            else
                throw new Exception("Le JsonString Indiqué est Vide");
        }

        public static T DeserializeFromFile<T>(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);

                var deserializedObject = JsonConvert.DeserializeObject<T>(jsonString);

                return deserializedObject;
            }
            else
                throw new Exception("Le Dossier/Fichier Indiqué n'existe pas");
        }

        public static string Serialize(object objectToSeriliaze)
        {            
            return JsonConvert.SerializeObject(objectToSeriliaze, Formatting.Indented);
        }

        public static void ExportSerializedString(string directory, string fileName, string serialisedString)
        {
            var jsonSerialiazer = new JsonSerializer();

            using (var streamWriter = new StreamWriter(directory + fileName))
            {
                using (var jsonWriter = new JsonTextWriter(streamWriter))
                {
                    Console.WriteLine("Exportation du String " + serialisedString.GetHashCode() + " en Fichier .json..." + "\n");

                    jsonWriter.Formatting = Formatting.Indented;
                    jsonSerialiazer.Serialize(jsonWriter, JsonConvert.DeserializeObject(serialisedString));

                    Console.WriteLine("Terminée..." + "\n");
                }
            }
        }

        public static void ExportSerializedString(string relativPath, string serialisedString)
        {
            var jsonSerialiazer = new JsonSerializer();

            using (var streamWriter = new StreamWriter(relativPath))
            {
                using (var jsonWriter = new JsonTextWriter(streamWriter))
                {
                    Console.WriteLine("Exportation du String " + serialisedString.GetHashCode() + " en Fichier .json..." + "\n");

                    jsonWriter.Formatting = Formatting.Indented;
                    jsonSerialiazer.Serialize(jsonWriter, JsonConvert.DeserializeObject(serialisedString));

                    Console.WriteLine("Terminée..." + "\n");
                }
            }
        }

        public static void ExportObject(string directory, string fileName, object objectToExport)
        {
            var jsonSerialiazer = new JsonSerializer();

            using (var streamWriter = new StreamWriter(directory + fileName))
            {
                using (var jsonWriter = new JsonTextWriter(streamWriter))
                {
                    Console.WriteLine("Exportation de l'Objet " + objectToExport.GetHashCode() + " en Fichier .json..." + "\n");

                    jsonWriter.Formatting = Formatting.Indented;
                    jsonSerialiazer.Serialize(jsonWriter, objectToExport);

                    Console.WriteLine("Terminée..." + "\n");
                }
            }
        }

        public static void ExportObject(string relativPath, object objectToExport)
        {
            var jsonSerialiazer = new JsonSerializer();

            using (var streamWriter = new StreamWriter(relativPath))
            {
                using (var jsonWriter = new JsonTextWriter(streamWriter))
                {
                    Console.WriteLine("Exportation de l'Objet " + objectToExport.GetHashCode() + " en Fichier .json..." + "\n");

                    jsonWriter.Formatting = Formatting.Indented;
                    jsonSerialiazer.Serialize(jsonWriter, objectToExport);

                    Console.WriteLine("Terminée..." + "\n");
                }
            }
        }
        public static T Import<T>(string directory, string fileName, T objectToImport)
        {
            var serializer = new JsonSerializer();

            using (var streamReader = new StreamReader(directory + fileName))
            {
                using (var jsonReader = new JsonTextReader(streamReader))
                {
                    Console.WriteLine("Importation de l'Objet " + objectToImport.GetHashCode() + " en Fichier .json..." + "\n");

                    objectToImport = serializer.Deserialize<T>(jsonReader);

                    Console.WriteLine("Terminée..." + "\n");

                    //Console.WriteLine(objectToImport);

                    return objectToImport;
                }
            }
        }

        public static T Import<T>(string relativPath, T objectToImport)
        {
            var serializer = new JsonSerializer();

            using (var streamReader = new StreamReader(relativPath))
            {
                using (var jsonReader = new JsonTextReader(streamReader))
                {
                    Console.WriteLine("Importation de l'Objet " + objectToImport.GetHashCode() + " en Fichier .json..." + "\n");

                    objectToImport = serializer.Deserialize<T>(jsonReader);

                    Console.WriteLine("Terminée..." + "\n");

                    //Console.WriteLine(objectToImport);

                    return objectToImport;
                }
            }
        }

        public static void Import(string directory, string fileName, object objectToImport)
        {
            var serializer = new JsonSerializer();

            using (var streamReader = new StreamReader(directory + fileName))
            {
                using (var jsonReader = new JsonTextReader(streamReader))
                {
                    Console.WriteLine("Importation de l'Objet " + objectToImport.GetHashCode() + " en Fichier .json..." + "\n");

                    Type TypeOfObjectToImport = objectToImport.GetType();

                    objectToImport = serializer.Deserialize(jsonReader, objectToImport.GetType());

                    Console.WriteLine("Terminée..." + "\n");

                    Console.WriteLine(objectToImport);
                }
            }
        }
        public static void Import(string relativPath, object objectToImport)
        {
            var serializer = new JsonSerializer();

            using (var streamReader = new StreamReader(relativPath))
            {
                using (var jsonReader = new JsonTextReader(streamReader))
                {
                    Console.WriteLine("Importation de l'Objet " + objectToImport.GetHashCode() + " en Fichier .json..." + "\n");

                    Type TypeOfObjectToImport = objectToImport.GetType();

                    objectToImport = serializer.Deserialize(jsonReader, objectToImport.GetType());

                    Console.WriteLine("Terminée..." + "\n");

                    Console.WriteLine(objectToImport);
                }
            }
        }
        public static GameConfiguration DeserializeGameConfiguration(string relativPath)
        {
            // Obtenez le chemin absolu du fichier en utilisant le chemin relatif
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativPath);

            Console.WriteLine("Your Relativ Path : " + relativPath);
            Console.WriteLine("loading... " + filePath + "\n");

            // Vérifier si le fichier existe
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);

                var gameconfig = JsonConvert.DeserializeObject<GameConfiguration>(jsonString);

                return gameconfig;
            }
            else
            {
                throw new FileNotFoundException("Le fichier JSON n'existe pas.", filePath);
            }
        }
    }
}
