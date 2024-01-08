namespace Command;

public class Remote
{
    ICommand _button1;
    ICommand _button2;
    ICommand _button3;
    private Stack<ICommand> _remember;

    public Remote(ICommand button1, ICommand button2, ICommand button3)
    {
        _button1 = button1;
        _button2 = button2;
        _button3 = button3;
        _remember = new Stack<ICommand>();
    }

    public void PressButton1()
    {
        _button1.Execute();
        _remember.Push(_button1);
    }
    public void PressButton2()
    {
        _button2.Execute();
        _remember.Push(_button2);
    }
    public void PressButton3()
    {
        _button3.Execute();
        _remember.Push(_button3);
    }

    public void Tenet(int rollbackCount)
    {
        while (_remember.Any() && rollbackCount > 0)
        {
            _remember.Pop().UnExecute();
            rollbackCount--;
        }
    }
}