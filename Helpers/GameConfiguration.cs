
using Newtonsoft.Json;
using PathTrainingOoTRandomizer.Models;
using System.Drawing;

namespace PathTrainingOoTRandomizer.Helpers
{

    [Serializable]
    //[JsonObject(MemberSerialization.OptIn)]
    public class GameConfiguration
    {
        //[JsonProperty]
        public string version { get; set; }
        public List<string> file_hash { get; set; } = new List<string>();
        public string seed { get; set; }
        public string settings_string { get; set; }
        public bool enable_distribution_file { get; set; }
        public Dictionary<string, dynamic> settings { get; set; } = new Dictionary<string, dynamic>();
        public Dictionary<string, string> randomized_settings { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, int> item_pool { get; set; } = new Dictionary<string, int>();
        public Dictionary<string, string> dungeons { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, bool> empty_dungeons { get; set; } = new Dictionary<string, bool>();
        public Dictionary<string, string> trials { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> songs { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, Dictionary<string, string>> entrances { get; set; } = new Dictionary<string, Dictionary<string, string>>();
        public Dictionary<string, dynamic> locations { get; set; } = new Dictionary<string, dynamic>();
        public Dictionary<string, string> skipped_locations { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, Dictionary<string, string>> woth_locations { get; set; } = new Dictionary<string, Dictionary<string, string>>();
        public Dictionary<string, Dictionary<string, Dictionary<string, string>>> goal_locations { get; set; } = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
        public List<string> barren_regions { get; set; } = new List<string>();
        public Dictionary<string, Dictionary<string, dynamic>> gossip_stones { get; set; } = new Dictionary<string,Dictionary<string, dynamic>>();
        public Dictionary<string, Dictionary<string, string>> playthrough { get; set; } = new Dictionary<string, Dictionary<string, string>>();

        public override string ToString()
        {
            string contenusDeLObjet = "\n -- " + this.GetType() + " -- \n";

            contenusDeLObjet +=
                "    Version : " + this.version + "\n";
            /*
                foreach (KeyValuePair<string, string> element in this.Version)
                {
                    n++;
                    Console.WriteLine("Hello World ! " + n);
                    contenusDeLObjet += "          ";
                    contenusDeLObjet += element.Key + element.Value + "\n";
                }
            */
            contenusDeLObjet += "    -> File Hash : \n";
            if (this.file_hash != null)
            {
                foreach (string element in this.file_hash)
                {
                    contenusDeLObjet += element + " - ";
                }
            } else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet +=
            "\n" +
            "    Seed : " + this.seed + "\n" +
            "    Settings String : " + this.settings_string + "\n" +
            "    Enable Distribution File : " + this.enable_distribution_file + "\n";


            contenusDeLObjet += "    -> Settings : \n";
            foreach (KeyValuePair<string, dynamic> element in this.settings)
            {
                contenusDeLObjet += element.Key + " : " + element.Value + "\n";
            }
            if (this.settings != null)
            {
            }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "    -> Randomized Settings : \n";
            if (this.randomized_settings != null)
            {
                foreach (KeyValuePair<string, string> element in this.randomized_settings)
                {
                    contenusDeLObjet += element.Key + " : " + element.Value + "\n";
                } }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "    -> Item Pool : \n";
            if (this.item_pool != null)
            {
                foreach (KeyValuePair<string, int> element in this.item_pool)
                {
                    contenusDeLObjet += element.Key + " : " + element.Value + "\n";
                } }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "    -> Dungeons : \n";
            if (this.dungeons != null)
            {
                foreach (KeyValuePair<string, string> element in this.dungeons)
                {
                    contenusDeLObjet += element.Key + " : " + element.Value + "\n";

                } }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "    ->empty_dungeons : \n";
            if (this.empty_dungeons != null)
            {
                foreach (KeyValuePair<string, bool> element in this.empty_dungeons)
                {
                    contenusDeLObjet += element.Key + " : " + element.Value + "\n";
                } }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "    ->trials : \n";
            if (this.trials != null)
            {
                foreach (KeyValuePair<string, string> element in this.trials)
                {
                    contenusDeLObjet += element.Key + " : " + element.Value + "\n";
                } }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "    -> Songs : \n";
            if (this.songs != null)
            {
                foreach (KeyValuePair<string, string> element in this.songs)
                {
                    contenusDeLObjet += element.Key + " : " + element.Value + "\n";
                } }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "    -> Entrances : \n";
            if (this.entrances != null)
            {
                foreach (KeyValuePair<string, Dictionary<string, string>> element in this.entrances)
                {
                    contenusDeLObjet += element.Key + " : \n";
                    foreach (KeyValuePair<string, string> elementB in element.Value)
                    {
                        contenusDeLObjet += elementB.Key + " : " + elementB.Value + "\n";
                    }
                } }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "    -> Locations : \n";
            if (this.locations != null)
            {
                foreach (KeyValuePair<string, dynamic> element in this.locations)
                {
                    contenusDeLObjet += element.Key + " : " + element.Value + "\n";
                }
            }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "    -> Skipped Locations : \n";
            if (this.skipped_locations != null)
            {
                foreach (KeyValuePair<string, string> element in this.skipped_locations)
                {
                    contenusDeLObjet += element.Key + " : " + element.Value + "\n";
                }
            }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "    -> Woth Locations : \n";
            if (this.woth_locations != null)
            {
                foreach (KeyValuePair<string, Dictionary<string, string>> element in this.woth_locations)
                {
                    contenusDeLObjet += element.Key + "\n";
                    foreach (KeyValuePair<string, string> elementB in element.Value)
                    {
                        contenusDeLObjet += elementB.Key + " : " + elementB.Value + "\n";
                    }
                } }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "    -> Goal Locations : \n";
            if (this.goal_locations != null)
            {
                foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, string>>> element in this.goal_locations)
                {
                    contenusDeLObjet += element.Key + "\n";
                    foreach (KeyValuePair<string, Dictionary<string, string>> elementB in element.Value)
                    {
                        contenusDeLObjet += elementB.Key + "\n";
                        foreach (KeyValuePair<string, string> elementC in elementB.Value)
                        {
                            contenusDeLObjet += elementC.Key + " : " + elementC.Value + "\n";
                        }
                    }
                }
            }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "    -> Gossip Stone : \n";
            if (this.gossip_stones != null)
            {
                foreach (KeyValuePair<string, Dictionary<string,dynamic>> element in this.gossip_stones)
                {
                    contenusDeLObjet += element.Key + "\n";
                    foreach (KeyValuePair<string, dynamic> elementB in element.Value)
                    {
                        contenusDeLObjet += elementB.Key + " : " + elementB.Value + "\n";
                    }
                }
            }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "    -> Playthrough : \n";
            if (this.playthrough != null)
            {
                foreach (KeyValuePair<string, Dictionary<string, string>> element in this.playthrough)
                {
                    contenusDeLObjet += element.Key + "\n";
                    foreach (KeyValuePair<string, string> elementB in element.Value)
                    {
                        contenusDeLObjet += elementB.Key + " : " + elementB.Value + "\n";
                    }
                }
            }
            else
            {
                contenusDeLObjet += "\n";
            }
            /*
            return
                $"Version :  {this.Version} \n" +
                $"Version :  {this.BarrenRegions} \n" +
                $"Version :  {this.Dungeons} \n" +
                $"Version :  {this.EmptyDungeons} \n" +
                $"Version :  {this.EnableDistributionFile} \n" +
                $"Version :  {this.Entrances} \n" +
                $"Version :  {this.Seed} \n" +
                $"Version :  {this.randomized_settings} \n" +
                $"Version :  {this.Trials} \n" +
                $"Version :  {this.SkippedLocations} \n" +
                $"Version :  {this.Songs} \n" +
                $"Version :  {this.WothLocations} \n" +
                $"Version :  {this.settings} \n" +
                $"Version :  {this.file_ hash} \n";
            */
            return contenusDeLObjet;
        }
    }
}