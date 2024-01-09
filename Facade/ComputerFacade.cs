namespace Facade;

public class ComputerFacade
{
    public Cpu GetCpu()
    {
        return new Cpu();
    }
    public HardDisk GetHardDisk()
    {
        return new HardDisk();
    }
    public Ram GetRam()
    {
        return new Ram();
    }
}