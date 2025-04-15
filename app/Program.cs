using System;

namespace Aps_Leonardo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma fabrica e definindo este criador
            SorveteCreator creator = new SegundaFeiraCreator();
            ISorvete sorvete = creator.CriarSorvete();
            sorvete.MostrarInformacoes();

            // Mudando a fábrica dinamicamente, informando outro criador
            creator = new TercaFeiraCreator();
            ISorvete sorveteDois = creator.CriarSorvete();
            sorveteDois.MostrarInformacoes();
        }
    }
}
