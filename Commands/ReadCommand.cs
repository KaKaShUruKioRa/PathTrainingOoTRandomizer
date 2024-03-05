using PathTrainingOoTRandomizer.Interfaces;

namespace PathTrainingOoTRandomizer.Commands
{
    public class ReadCommand : ICommand
    {
        private string hintName;

        string ICommand.Name { get; } = "ReadName";
        string ICommand.Description { get; } = "ReadDescription";

        public ReadCommand(string hintName)
        {
            this.hintName = hintName;
        }


        public void Execute()
        {
            // Logique pour lire l'indice spécifié
        }

        public void Execute(string[] args)
        {
            throw new NotImplementedException();
        }
    }
}