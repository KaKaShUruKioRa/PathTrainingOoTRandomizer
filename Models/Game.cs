
namespace PathTrainingOoTRandomizer.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public World World { get; set; }
        public Player Player { get; set; }

        public Game()
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            this.Id = this.GetHashCode();
            this.Name = string.Empty;
            this.Description = string.Empty;

            this.Player = new Player();
            this.World = new World();
        }

        public override string ToString()
        {
            string contenusDeLObjet = "\n -- " + this.GetType() + " -- \n";

            contenusDeLObjet += 
                "    Id : " + this.Id +
                "    Name : " + this.Name +
                "    Description : " + this.Description +
                "\n    -> World : " + this.World + "        " + 
                "\n    -> Player : " + this.Player + "        ";

            /*
            return
                $"Id :  {this.Id} \n" +
                $"Name :  {this.Name} \n" +
                $"Description :  {this.Description} \n" +
                $"World :  {this.World} \n" +
                $"Player :  {this.Player} \n";
            */

            return contenusDeLObjet;
        }
    }
}