using System.Collections.Generic;

public class SorveteCollectionCreator : SorveteCreator
{
    // construi uma lista de classes de sorvete (espera receber um sorvete concreto e retorna 1 istancia)
    // e constroir X numero de classes.
    private readonly ISorvete _sorvete;
    private readonly int _quantidade;

    public SorveteCollectionCreator(ISorvete sorvete, int quantidade)
    {
        _sorvete = sorvete;
        _quantidade = quantidade;
    }

    public List<ISorvete> CriarSorvetes()
    {
        var lista = new List<ISorvete>();
        for (int i = 0; i < _quantidade; i++)
        {
            lista.Add(_sorvete);
        }
        return lista;
    }

    public override ISorvete CriarSorvete()
    {
        // para nao quebrar a herança
        return _sorvete;
    }
}