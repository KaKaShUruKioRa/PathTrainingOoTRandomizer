namespace PathTrainingOoTRandomizer.Commands
{
    public class StartCommand : ICommand
    {
        public string Name { get { return "start"; } }
        public string Description { get { return "Starts the game."; } }

        public void Execute(string[] args)
        {
            // Logique pour d�marrer le jeu
            Console.WriteLine("The game is starting...");
        }
    }
}