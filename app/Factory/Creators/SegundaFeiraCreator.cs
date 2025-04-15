using System.Collections.Generic;

public class SegundaFeiraCreator : SorveteCreator
{
    public override ISorvete CriarSorvete()
    {
        return new ComboSegunda();
    }
}