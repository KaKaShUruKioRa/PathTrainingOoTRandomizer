using PathTrainingOoTRandomizer.Models;

namespace PathTrainingOoTRandomizer.Component
{
    public class Dungeon
    {
        public Dungeon(string name, int numberOfChecks, int numberOfSongs, int numberOfHints, int numberOfGoldenSkulltulas, int numberOPossibleActions)
        {
            this.Name = name;
            this.Description = "Description";
            this.Requierement = "Requierement";

            // Crée une Liste dans this.Checks si la demande est supérier à 0 et Ajout des Check à celle-ci
            if (numberOfChecks > 0)
            {
                this.Checks = new List<Check>();

                for (int i = numberOfChecks; i > 0; i--)
                {
                    var tempCheck = new Check("name", "description", new Item());
                    this.Checks.Add(tempCheck);
                }
            }

            // Crée une Liste dans this.Songs et Ajout des Songs à celle-ci
            if (numberOfSongs > 0)
            {
                this.Songs = new List<Song>();

                for (int i = numberOfSongs; i > 0; i--)
                {
                    var tempSong = new Song();
                    this.Songs.Add(tempSong);
                }
            }

            // Crée une List dans this.Hints et Ajout des GossipStones à celle-ci
            if (numberOfHints > 0)
            {
                this.GossipStones = new List<GossipStone>();

                for (int i = numberOfHints; i > 0; i--)
                {
                    var tempColors = new List<string>();
                    tempColors.Add("colors");
                    var tempHintedLocations = new List<string>();
                    tempHintedLocations.Add("hintedLocation");
                    var tempHintedItems = new List<string>();
                    tempHintedItems.Add("hintedItem");

                    var tempHint = new GossipStone("name", tempColors, tempHintedLocations, tempHintedItems);
                    this.GossipStones.Add(tempHint);
                }
            }

            // Crée une List dans this.PossibleAction et Ajout des Actions Possible à celle-ci
            if (numberOPossibleActions > 0)
            {
                this.PossibleActions = new List<PossibleAction>();

                for (int i = numberOPossibleActions; i > 0; i--)
                {
                    var tempPossibleActions = new PossibleAction();
                    this.PossibleActions.Add(tempPossibleActions);
                }
            }

            // Crée une List dans this.GoldenSkulltulas et Ajout des Skulltulas D'or à celle-ci
            if (numberOfGoldenSkulltulas > 0)
            {
                this.GoldenSkulltulas = new List<GoldenSkulltula>();

                for (int i = numberOPossibleActions; i > 0; i--)
                {
                    var tempPossibleActions = new GoldenSkulltula();
                    this.GoldenSkulltulas.Add(tempPossibleActions);
                }
            }
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Requierement { get; set; }
        public Boss boss { get; set; }
        public List<Check> Checks { get; set; }
        public List<Song> Songs { get; set; }
        public List<GossipStone> GossipStones { get; set; }
        public List<GoldenSkulltula> GoldenSkulltulas { get; set; }
        public List<PossibleAction> PossibleActions { get; set; }

        //Template de Création des Listes
        /*
        public void CreateList<T>()
        {
            this.GossipStone = new List<T>();
        }
        public void AddElementinList(List<T> list)
        {
            var tempPossibleActions = new T("name", "description", "token");
            this.GoldenSkulltulas.Add(tempPossibleActions);
        }
        */
        public override string ToString()
        {
            string contenusDeLObjet = "\n -- " + this.GetType() + " -- \n";

            contenusDeLObjet +=
                "    Name : " + this.Name +
                "    Description : " + this.Description +
                "    Requierement : " + this.Requierement;
            contenusDeLObjet += "\n    -> Checks :        ";
            if (this.Checks != null)
            {
                foreach (var element in this.Checks)
                {
                    contenusDeLObjet += element;
                }
            }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "\n    -> Songs :        ";
            if (this.Songs != null)
            {
                foreach (var element in this.Songs)
                {
                    contenusDeLObjet += element;
                }
            }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "\n    -> GossipStones :        ";
            if (this.GossipStones != null)
            {
                foreach (var element in this.GossipStones)
                {
                    contenusDeLObjet += element;
                }
            }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "\n    -> Golden Skulltulas :        ";
            if (this.GoldenSkulltulas != null)
            {
                foreach (var element in this.GoldenSkulltulas)
                {
                    contenusDeLObjet += element;
                }
            }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "\n    -> Possible Actions :        ";
            if (this.PossibleActions != null)
            {
                foreach (var element in this.PossibleActions)
                {
                    contenusDeLObjet += element;
                }
            }
            else
            {
                contenusDeLObjet += "\n";
            }

            /*
            return
                $"Name :         {this.Name} \n" +
                $"Description :         {this.Description} \n" +
                $"Requierement :         {this.Requierement} \n" +
                $"Checks :         {this.Checks} \n" +
                $"Songs :         {this.Songs} \n" +
                $"GossipStones :         {this.GossipStones} \n" +
                $"GoldenSkulltulas :         {this.GoldenSkulltulas} \n" +
                $"PossibleActions :         {this.PossibleActions} \n";
            */

            return contenusDeLObjet;
        }
    }
}