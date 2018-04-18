namespace Command.Core
{
    public interface ICommandBus
    {
        void Publish<TCommand>(TCommand command) where TCommand : ICommand;
    }
}