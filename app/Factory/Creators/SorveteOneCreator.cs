public class SorveteOneCreator : SorveteCreator
{
    // construi uma classe de sorvete (espera receber um sorvete concreto e retorna 1 istancia)
    private readonly ISorvete _sorvete;

    public SorveteOneCreator(ISorvete sorvete)
    {
        _sorvete = sorvete;
    }

    public override ISorvete CriarSorvete()
    {
        return _sorvete;
    }
}