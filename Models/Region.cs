namespace PathTrainingOoTRandomizer.Models
{
    // Classe repr�sentant une r�gion du monde
    public class Region
    {
        public Region()
        {

        }

        public Region(string name,
                      int numberOfChecks,
                      int numberOfSongs,
                      int numberOfHints,
                      int numberOfGoldenSkulltula,
                      int numberOfDungeons,
                      int numberOPossibleActions)
        {
            this.Name = name;
            this.Description = "Description";
            this.Requierement = "Requierement";

            // Cr�e une Liste dans this.Checks si la demande est sup�rier � 0 et Ajout des Check � celle-ci
            if (numberOfChecks > 0)
            {
                this.Checks = new List<Check>();

                for (int i = numberOfChecks; i > 0; i--)
                {
                    var tempCheck = new Check("name", "description", new Item());
                    this.Checks.Add(tempCheck);
                }
            }

            // Cr�e une Liste dans this.Songs et Ajout des Songs � celle-ci
            if (numberOfSongs > 0)
            {
                this.Songs = new List<Song>();

                for (int i = numberOfSongs; i > 0; i--)
                {
                    var tempSong = new Song();
                    this.Songs.Add(tempSong);
                }
            }

            // Cr�e une List dans this.Hints et Ajout des GossipStones � celle-ci
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

            // Cr�e une List dans this.Dunhgeons et Ajoutes des Donjons � celle-ci
            if (numberOfDungeons > 0)
            {
                this.Dungeons = new List<Dungeon>();

                for (int i = numberOfDungeons; i > 0; i--)
                {
                    var tempDungeons = new Dungeon("name", 0, 0, 0, 0, 0);
                    this.Dungeons.Add(tempDungeons);
                }
            }

            // Cr�e une List dans this.PossibleAction et Ajout des Actions Possible � celle-ci
            if (numberOPossibleActions > 0)
            {
                this.PossibleActions = new List<PossibleAction>();

                for (int i = numberOPossibleActions; i > 0; i--)
                {
                    var tempPossibleActions = new PossibleAction();
                    this.PossibleActions.Add(tempPossibleActions);
                }
            }

            // Cr�e une List dans this.GoldenSkulltula et Ajout des Skulltulas D'or � celle-ci
            if (numberOfGoldenSkulltula > 0)
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
        // Ajoute d'autres propri�t�s selon la structure de ton fichier JSON

        public List<Check> Checks { get; set; }
        public List<Song> Songs { get; set; }
        public List<GossipStone> GossipStones { get; set; }
        public List<GoldenSkulltula> GoldenSkulltulas { get; set; }
        public List<Dungeon> Dungeons { get; set; }
        public List<PossibleAction> PossibleActions { get; set; }

        public override string ToString()
        {
            string contenusDeLObjet = "\n -- " + this.GetType() + " -- \n";

            contenusDeLObjet +=
                "    Name : " + this.Name +
                "    Description : " + this.Description +
                "    Requierement : " + this.Requierement +
                "\n    -> Checks :        ";
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
            if (this.Songs is not null)
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
            contenusDeLObjet += "\n    -> Gossip Stones :        ";
            if (this.GossipStones is not null)
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
            contenusDeLObjet += "\n    -> Golden Skulltulas : :        ";
            if (this.GoldenSkulltulas is not null)
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
            contenusDeLObjet += "\n    -> Dungeon :        ";
            if (this.Dungeons is not null)
            {
                foreach (var element in this.Dungeons)
                {
                    contenusDeLObjet += element;
                }
            }
            else
            {
                contenusDeLObjet += "\n";
            }
            contenusDeLObjet += "\n    -> Possible Actions :        ";
            if (this.PossibleActions is not null)
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
                $"Verions : {this.Name} \n" +
                $"Verions : {this.Description} \n" +
                $"Verions : {this.Requierement} \n" +
                $"Verions : {this.Checks} \n" +
                $"Verions : {this.Songs} \n" +
                $"Verions : {this.GossipStones} \n" +
                $"Verions : {this.GoldenSkulltulas} \n" +
                $"Verions : {this.Dungeons} \n" +
                $"Verions : {this.PossibleActions} \n";
            */

            return contenusDeLObjet;
        }
    }
}