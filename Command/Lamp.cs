namespace Command;

public class Lamp
{
    public bool IsOn;
    public int Bright; // push it to the limit push it
    
    public void TurnOn()
    {
        IsOn = true;
    }
    
    public void TurnOff()
    {
        IsOn = false;
    }

    public void AddBright(int brightToAdd)
    {
        Bright += brightToAdd;
    }
    
    public void SubtractBright(int brightToSubtract)
    {
        Bright -= brightToSubtract;
    }
}