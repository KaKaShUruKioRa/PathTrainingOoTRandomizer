namespace PathTrainingOoTRandomizer.Models
{
    public class World
    {
        public string? Name { get; set; } = "Name";
        public string? Description { get; set; } = "Description";
        public List<Region> Regions { set; get; }

        public World()
        {
            InitializeWorld();
        }

        public void InitializeWorld()
        {
            this.Name = string.Empty;
            this.Description = string.Empty;
            this.Regions = new List<Region>();
            CreateAllRegions();
            CreateAllDungeons();
        }

        public void CreateAllRegions()
        {
            // Creation des Regions                         Name,                   Checks, Songs,  Hints,   GoldenSkulltulas,   Dungeons,   PossibleActions  
            var KokiriForest = new Region("Kokiri Forest", 6, 0, 4, 3, 1, 0);
            var LostWoods = new Region("Lost Woods", 8, 0, 2, 2, 0, 0);
            var SecretForestMeadow = new Region("Sacred Forest Meadow", 1, 2, 3, 1, 1, 0);
            var HyruleField = new Region("Hyrule Field", 5, 1, 4, 1, 0, 0);
            var Market = new Region("Market", 6, 0, 0, 1, 0, 0);
            var TempleOfTime = new Region("Temple of Time", 1, 2, 4, 0, 0, 0);
            var HyruleCastle = new Region("Hyrule Castle", 1, 1, 3, 2, 0, 0);
            var LonLonRanch = new Region("Lon Lon Ranch", 2, 1, 0, 4, 0, 0);
            var KakarikoVillage = new Region("Kakariko Village", 13, 2, 1, 6, 1, 0);
            var Graveyard = new Region("Graveyard", 7, 1, 1, 2, 1, 0);
            var DeathMoutainTrail = new Region("Death Moutain Trail", 5, 0, 2, 3, 1, 0);
            var GoronCity = new Region("Goron City", 7, 0, 2, 2, 0, 0);
            var DeathMountainCrater = new Region("Death Mountain Crater", 4, 1, 2, 2, 1, 0);
            var ZorasRiver = new Region("Zora's River", 5, 0, 3, 5, 0, 0);
            var ZorasDomain = new Region("Zora's Domain", 3, 1, 1, 1, 0, 0);
            var ZorasFountain = new Region("Zora's Fountain", 3, 0, 2, 3, 2, 0);
            var LakeHylia = new Region("Lake Hylia", 6, 0, 3, 5, 1, 0);
            var GerudoValley = new Region("Gerudo Valley", 3, 0, 1, 3, 0, 0);
            var GerudoFortress = new Region("Gerudo Fortress", 3, 0, 0, 2, 1, 0);
            var HauntedWasteLand = new Region("Haunted Wasteland", 1, 0, 0, 1, 0, 0);
            var DesertColossus = new Region("Desert Colossus", 2, 1, 1, 3, 1, 0);
            var OusideGanonCastle = new Region("Ouside Ganon Castle", 1, 0, 0, 1, 1, 0);

            this.Regions.Add(KokiriForest);
            this.Regions.Add(LostWoods);
            this.Regions.Add(SecretForestMeadow);
            this.Regions.Add(HyruleField);
            this.Regions.Add(Market);
            this.Regions.Add(TempleOfTime);
            this.Regions.Add(HyruleCastle);
            this.Regions.Add(LonLonRanch);
            this.Regions.Add(KakarikoVillage);
            this.Regions.Add(Graveyard);
            this.Regions.Add(DeathMoutainTrail);
            this.Regions.Add(GoronCity);
            this.Regions.Add(DeathMountainCrater);
            this.Regions.Add(ZorasRiver);
            this.Regions.Add(ZorasDomain);
            this.Regions.Add(ZorasFountain);
            this.Regions.Add(LakeHylia);
            this.Regions.Add(GerudoValley);
            this.Regions.Add(GerudoFortress);
            this.Regions.Add(HauntedWasteLand);
            this.Regions.Add(DesertColossus);
            this.Regions.Add(OusideGanonCastle);
        }

        public void CreateAllDungeons()
        {
            // Creation des Dungeons                        Name,                   Checks,     Songs,  Hints,   GoldenSkulltulas,   PossibleActions  
            var DekuTree = new Dungeon("Deku Tree", 7, 0, 0, 4, 0);
            var DodongosCavern = new Dungeon("Dodongo's Cavern", 7, 0, 1, 5, 0);
            var JabuJabuBelly = new Dungeon("Jabu Jabu Belly", 4, 0, 0, 4, 0);
            var BottomOfTheWell = new Dungeon("Bottom Of The Well", 14, 0, 0, 3, 0);
            var ForestTemple = new Dungeon("Forest Temple", 14, 0, 0, 5, 0);
            var FireTemple = new Dungeon("Fire Temple", 15, 0, 0, 5, 0);
            var WaterTemple = new Dungeon("Water Temple", 11, 0, 0, 5, 0);
            var ShadowTemple = new Dungeon("Shadow Temple", 18, 0, 0, 5, 0);
            var SpiritTemple = new Dungeon("Spirit Temple", 20, 0, 0, 5, 0);
            var IceCavern = new Dungeon("Ice Cavern", 4, 1, 0, 3, 0);
            var GerudoTrainingGround = new Dungeon("Gerudo Training Ground", 22, 0, 0, 0, 0);
            var GanonsCastle = new Dungeon("Ganon's Castle", 16, 0, 0, 0, 0);
        }

        public override string ToString()
        {
            string contenusDeLObjet = "\n -- " + this.GetType() + " -- \n";

            contenusDeLObjet += 
                "    Name : " + this.Name + 
                "    Description : " + this.Description +
                "\n    -> Regions :        ";
            if (this.Regions is not null)
            {
                foreach (var element in this.Regions)
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
                $"Name : {this.Name} \n" +
                $"Description : {this.Description} \n" +
                $"Region : {this.Regions} \n";
            */

            return contenusDeLObjet;
        }
    }
}