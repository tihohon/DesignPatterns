namespace FactoryMethod;

public class FamilyFactory : AnimalFactory
{
    private readonly Guid _father;
    private readonly Guid _mather;

    public FamilyFactory(Guid father, Guid mather)
    {
        _father = father;
        _mather = mather;
    }

    public override Animal Create()
    {
        return new Duck( "RealName", _father, _mather, 4);
    }
}