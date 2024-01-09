namespace Adapter;

public class BirdAdapter : IToyDuck
{
    private readonly IBird _bird;

    public BirdAdapter(IBird bird)
    {
        _bird = bird;
    }

    public void DoSound()
    {
        _bird.Cry();
    }
}