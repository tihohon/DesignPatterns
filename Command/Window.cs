namespace Command;

public class Window
{
    public bool IsOpen;

    public void Open()
    {
        IsOpen = true;
    }
    
    public void Close()
    {
        IsOpen = false;
    }
}