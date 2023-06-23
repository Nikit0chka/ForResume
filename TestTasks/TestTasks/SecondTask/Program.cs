using CommandProcessingModel;

internal class Program
{
    static async Task Main(string[] args)
    {
        List<CommandHandler> _handlers = new List<CommandHandler>
        {
            new Command1Handler(),
            new Command2Handler()
        };

        List<string> commands = new List<string>
        {
            "Command1;hello",
            "Command2;beatboks",
            "Command1;TeamLeadLoh!"
        };

        CommandHandlersController commandHandlersController = new CommandHandlersController(_handlers);

        foreach (var command in commands)
            await commandHandlersController.StartHendlAsync(command.Split(';')[0], command.Split(';')[1]);
    }
}