namespace Command;

public class OpenWindow : ICommand
{
    private readonly Window _window;

    public OpenWindow(Window window)
    {
        _window = window;
    }

    public void Execute()
    {
        _window.Open();
    }

    public void UnExecute()
    {
        _window.Close();
    }
}