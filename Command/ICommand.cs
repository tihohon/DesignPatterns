namespace Command;

public interface ICommand
{
    public void Execute();
    public void UnExecute();
}