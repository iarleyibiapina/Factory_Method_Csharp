public class TercaFeiraCreator  : SorveteCreator
{
    public override ISorvete CriarSorvete()
    {
        return new ComboTerca();
    }
}