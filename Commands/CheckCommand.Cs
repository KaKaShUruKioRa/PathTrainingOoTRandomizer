namespace PathTrainingOoTRandomizer.Commands
{
    public class CheckCommand : ICommand
    {
        private string checkName;
        string ICommand.Name { get; } = "ReadName";
        string ICommand.Description { get; } = "ReadDescription";

        public CheckCommand(string checkName)
        {
            this.checkName = checkName;
        }

        public void Execute(string[] args)
        {
            // Logique pour vérifier le check spécifié
        }
    }
}