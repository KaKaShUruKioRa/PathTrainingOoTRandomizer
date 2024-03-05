using PathTrainingOoTRandomizer.Interfaces;

namespace PathTrainingOoTRandomizer.Commands
{
    public class HelpCommand : ICommand
    {
        private readonly ICommand[] commands;

        public string Name { get { return "help"; } }
        public string Description { get { return "Displays the list of available commands."; } }

        public HelpCommand(ICommand[] commands)
        {
            this.commands = commands;
        }

        public void Execute(string[] args)
        {
            Console.WriteLine("Available commands:");
            foreach (var command in commands)
            {
                Console.WriteLine($"{command.Name}: {command.Description}");
            }
        }
    }
}