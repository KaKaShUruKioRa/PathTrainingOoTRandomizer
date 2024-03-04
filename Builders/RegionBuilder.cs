using PathTrainingOoTRandomizer.Models;

namespace PathTrainingOoTRandomizer.Builders
{
    // Builder pour construire des régions
    public class RegionBuilder
    {
        private Region Region = new Region("test",0,0,0,0,0,0);

        public RegionBuilder(string name, string description, string requierement)
        {
            this.Region = new Region {
                Name = name,
                Description = description,
                Requierement = requierement,
                Checks = new List<Check>(),
                Songs = new List<Song>(),
                GossipStones = new List<GossipStone>(),
                Dungeons = new List<Dungeon>(),
                PossibleActions = new List<PossibleAction>(),
                GoldenSkulltulas = new List<GoldenSkulltula>(),
            };
    }

    public RegionBuilder AddCheck(string regionName, Check check)
        {
            if (this.Region != null)
            {
                this.Region.Checks.Add(check);
            }
            return this;
        }
        public RegionBuilder AddHint(string name, GossipStone gossipStone) {

            this.Region.GossipStones.Add(gossipStone);
            return this;
        }

        public RegionBuilder AddDungeon(string regionName, Dungeon dungeon)
        {
            if (this.Region != null)
            {
                this.Region.Dungeons.Add(dungeon);
            }
            return this;
        }
        public RegionBuilder AddGoldenSkulltulas(string name, GoldenSkulltula goldenSkulltulas)
        {

            this.Region.GoldenSkulltulas.Add(goldenSkulltulas);
            return this;
        }
        public RegionBuilder AddPossibleActions(string name, PossibleAction possibleAction)
        {

            this.Region.PossibleActions.Add(possibleAction);
            return this;
        }

        public Region Build()
        {
            return this.Region;
        }
    }
}