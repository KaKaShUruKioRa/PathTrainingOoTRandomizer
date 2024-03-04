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
            // Vérifie si la région existe
            if (world.Regions.Contains(regionName))
            {
                // Vérifie si le joueur peut accéder à la région
                if (player.CanAccessRegion(regionName))
                {
                    // Déplace le joueur dans la région
                    player.CurrentRegion = regionName;
                    Console.WriteLine($"Vous êtes maintenant dans la région {regionName}");
                }
                else
                {
                    Console.WriteLine($"Vous ne pouvez pas accéder à la région {regionName} pour le moment");
                }
            }
            else
            {
                Console.WriteLine($"La région {regionName} n'existe pas");
            }
        }
    }
}