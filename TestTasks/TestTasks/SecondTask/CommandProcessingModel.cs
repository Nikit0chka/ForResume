namespace CommandProcessingModel;

public interface ICommandHandler
{
    Task HandleAsync(string commandName, string info);
}

public abstract class CommandHandler : ICommandHandler
{
    private ICommandHandler _nextHandler;

    public void SetNext(ICommandHandler handler)
    {
        _nextHandler = handler;
    }

    public virtual async Task HandleAsync(string commandName, string info)
    {
        if (_nextHandler != null)
        {
            await _nextHandler.HandleAsync(commandName, info);
        }
    }
}

public class Command1Handler : CommandHandler
{
    public override async Task HandleAsync(string commandName, string info)
    {
        if (commandName == "Command1")
        {
            Console.WriteLine("Command 1 working " + info);
        }
        else
        {
            await base.HandleAsync(commandName, info);
        }
    }
}

public class Command2Handler : CommandHandler
{
    public override async Task HandleAsync(string commandName, string info)
    {
        if (commandName == "Command2")
        {
            Console.WriteLine("Command 2 working " + info);
        }
        else
        {
            await base.HandleAsync(commandName, info);
        }
    }
}

public class CommandHandlersController : CommandHandler
{
    private List<CommandHandler> _commandHandlers;

    public CommandHandlersController(List<CommandHandler> commandHandlers)
    {
        _commandHandlers = commandHandlers;
        BiuldHandlers();
    }

    public async Task StartHendlAsync(string commandName, string info)
    {
        await _commandHandlers[0].HandleAsync(commandName, info);
    }

    private void BiuldHandlers()
    {
        for (int i = 0; i < _commandHandlers.Count - 1; i++)
            _commandHandlers[i].SetNext(_commandHandlers[i + 1]);
    }
}