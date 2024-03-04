
using Newtonsoft.Json;
using PathTrainingOoTRandomizer.Models;

namespace PathTrainingOoTRandomizer.Helpers
{
    [Serializable]
    [JsonObject(MemberSerialization.OptIn)]
    public class GameConfiguration
    {
        [JsonProperty]
        public string Version { get; set; } = "Not Defined";
        public List<string> FileHash { get; set; } = new List<string>();
        public string Seed { get; set; } = "Not Defined";
        public string SettingsString { get; set; } = "Not Defined";
        public bool EnableDistributionFile { get; set; } = false;
        public Dictionary<string, string> Settings { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> RandomizedSettings { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> ItemPool { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> Dungeons { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, bool> EmptyDungeons { get; set; } = new Dictionary<string, bool>();
        public Dictionary<string, string> Trials { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> Songs { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, Dictionary<string, string>> Entrances { get; set; } = new Dictionary<string, Dictionary<string, string>>();
        public Dictionary<string, string> Locations { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> SkippedLocations { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, Dictionary<string, string>> WothLocations { get; set; } = new Dictionary<string, Dictionary<string, string>>();
        public GoalLocations GoalLocations { get; set; } = new GoalLocations();
        public List<string> BarrenRegions { get; set; } = new List<string>();
        public Dictionary<string, GossipStone> GossipStones { get; set; } = new Dictionary<string, GossipStone>();
        public Playthrough Playthrough { get; set; } = new Playthrough();

        public override string ToString()
        {
            string contenusDeLObjet = "\n -- " + this.GetType() + " -- \n";

            contenusDeLObjet = "Version : " + this.Version + "\n";

        /*
            foreach (KeyValuePair<string, string> element in this.Version)
            {
                n++;
                Console.WriteLine("Hello World ! " + n);
                contenusDeLObjet += "          ";
                contenusDeLObjet += element.Key + element.Value + "\n";
            }
        */
            contenusDeLObjet += "File Hash : " + this.FileHash + "\n";
            foreach (string element in this.FileHash)
            {
                contenusDeLObjet += element + " - ";
            }

            contenusDeLObjet +=
                    "\n" +
                    "Seed : " + this.Seed + "\n" +
                    "SettingsString : " + this.SettingsString + "\n" +
                    "EnableDistributionFile : " + this.EnableDistributionFile + "\n" +

                    "Settings : " + this.Settings + "\n";
            foreach (KeyValuePair<string, string> element in this.Settings)
            {
                contenusDeLObjet += element.Key + element.Value + "\n";
            }
            contenusDeLObjet += this.RandomizedSettings + "\n";
            foreach (KeyValuePair<string, string> element in this.Settings)
            {
                contenusDeLObjet += element.Key + element.Value + "\n";
            }
            contenusDeLObjet += this.ItemPool + "\n";
            foreach (KeyValuePair<string, string> element in this.Settings)
            {
                contenusDeLObjet += element.Key + element.Value + "\n";
            }
            contenusDeLObjet += this.Dungeons + "\n";
            foreach (KeyValuePair<string, string> element in this.Settings)
            {
                contenusDeLObjet += element.Key + element.Value + "\n";

            }
            contenusDeLObjet += this.EmptyDungeons + "\n";
            foreach (KeyValuePair<string, string> element in this.Settings)
            {
                contenusDeLObjet += element.Key + element.Value + "\n";

            }
            contenusDeLObjet +=
                this.Trials + "\n";
            foreach (KeyValuePair<string, string> element in this.Settings)
            {
                contenusDeLObjet += element.Key + element.Value + "\n";

            }
            contenusDeLObjet +=
                this.Songs + "\n";
            foreach (KeyValuePair<string, string> element in this.Settings)
            {
                contenusDeLObjet += element.Key + element.Value + "\n";

            }
            contenusDeLObjet +=
                this.Entrances + "\n";
            foreach (KeyValuePair<string, string> element in this.Settings)
            {
                contenusDeLObjet += element.Key + element.Value + "\n";

            }
            contenusDeLObjet +=
                this.Locations + "\n";
            foreach (KeyValuePair<string, string> element in this.Settings)
            {
                contenusDeLObjet += element.Key + element.Value + "\n";

            }
            contenusDeLObjet +=
                this.SkippedLocations + "\n";
            foreach (KeyValuePair<string, string> element in this.Settings)
            {
                contenusDeLObjet += element.Key + element.Value + "\n";

            }
            contenusDeLObjet +=
                this.WothLocations + "\n";
            foreach (KeyValuePair<string, string> element in this.Settings)
            {
                contenusDeLObjet += element.Key + element.Value + "\n";

            }
            contenusDeLObjet +=
                this.GoalLocations + "\n" +
                this.BarrenRegions + "\n";
            foreach (KeyValuePair<string, string> element in this.Settings)
            {
                contenusDeLObjet += element.Key + element.Value + "\n";

            }
            contenusDeLObjet +=
                this.GossipStones + "\n";
            foreach (KeyValuePair<string, string> element in this.Settings)
            {
                contenusDeLObjet += element.Key + element.Value + "\n";

            }
            contenusDeLObjet +=
                this.Playthrough + "\n";
            /*
            return
                $"Version :  {this.Version} \n" +
                $"Version :  {this.BarrenRegions} \n" +
                $"Version :  {this.Dungeons} \n" +
                $"Version :  {this.EmptyDungeons} \n" +
                $"Version :  {this.EnableDistributionFile} \n" +
                $"Version :  {this.Entrances} \n" +
                $"Version :  {this.Seed} \n" +
                $"Version :  {this.RandomizedSettings} \n" +
                $"Version :  {this.Trials} \n" +
                $"Version :  {this.SkippedLocations} \n" +
                $"Version :  {this.Songs} \n" +
                $"Version :  {this.WothLocations} \n" +
                $"Version :  {this.Settings} \n" +
                $"Version :  {this.FileHash} \n";
            */
            return contenusDeLObjet;
        }
    }
}