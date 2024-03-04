namespace PathTrainingOoTRandomizer.Commands
{
    public class GoCommand : ICommand
    {
        private string regionName;
        string ICommand.Name { get; } = "ReadName";
        string ICommand.Description { get; } = "ReadDescription";

        public GoCommand(string regionName)
        {
            this.regionName = regionName;
        }

        public void Execute(string[] args)
        {
            // Logique pour aller dans la région spécifiée
        }
    }
}