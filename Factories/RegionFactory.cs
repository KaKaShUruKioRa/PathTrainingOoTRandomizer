using PathTrainingOoTRandomizer.Builders;
using PathTrainingOoTRandomizer.Models;

namespace PathTrainingOoTRandomizer.Factories 
{
    // Factory pour cr�er des r�gions
    public class RegionFactory
    {
        public static Region CreateRegion()
        {
            var builder = new RegionBuilder("Desert","hahah","bebe");

            builder.AddCheck("Temple Entrance",
                new Check( "Light up 2 torches", "Magic", "Magie" ));

            List<string> colors = new List<string>();
            List<string> hintedLocations = new List<string>();
            List<string> hintedItems = new List<string>();

            builder.AddHint("Temple Entrance",
                new GossipStone("text", colors, hintedLocations, hintedItems));

            // Ajouter d'autres lieux et checks/hints si n�cessaire...

            return builder.Build();
        }

        // Ajouter d'autres m�thodes de fabrique pour cr�er diff�rentes r�gions...
    }
}