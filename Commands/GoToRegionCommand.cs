using PathTrainingOoTRandomizer.Models;

namespace PathTrainingOoTRandomizer.Commands
{
    public class GoToRegionCommand
    {
        public GoToRegionCommand(World world, string regionName)
        {
            this.world = world;
        }

        private readonly World world;



        public void Execute(Player player, Region regionName)
        {
            // V�rifie si la r�gion existe
            if (world.Regions.Contains(regionName))
            {
                // V�rifie si le joueur peut acc�der � la r�gion
                if (player.CanAccessRegion(regionName))
                {
                    // D�place le joueur dans la r�gion
                    player.CurrentRegion = regionName;
                    Console.WriteLine($"Vous �tes maintenant dans la r�gion {regionName}");
                }
                else
                {
                    Console.WriteLine($"Vous ne pouvez pas acc�der � la r�gion {regionName} pour le moment");
                }
            }
            else
            {
                Console.WriteLine($"La r�gion {regionName} n'existe pas");
            }
        }
    }
}