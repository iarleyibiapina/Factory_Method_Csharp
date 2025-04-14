using System;

namespace Aps_Leonardo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um combo de segunda-feira
            SorveteCreator creatorSegunda = new SorveteOneCreator(new ComboSegunda());
            ISorvete sorveteSegunda = creatorSegunda.CriarSorvete();
            Console.WriteLine($"Sabor: {sorveteSegunda.sabor()}, Cobertura: {sorveteSegunda.cobertura()}, Base: {sorveteSegunda.corpo()}");
    
            // Criando um combo de terça-feira
            SorveteCreator creatorTerca = new SorveteOneCreator(new ComboTerca());
            ISorvete sorveteTerca = creatorTerca.CriarSorvete();
            Console.WriteLine($"Sabor: {sorveteTerca.sabor()}, Cobertura: {sorveteTerca.cobertura()}, Base: {sorveteTerca.corpo()}");

            // Criando uma colecao de sorvetes
            var criador = new SorveteCollectionCreator(new ComboSegunda(), 3);
            var lista = criador.CriarSorvetes();
            foreach (var item in lista)
            {
                Console.WriteLine("Sorvetes criados:");
                Console.WriteLine($"Sabor: {item.sabor()}, Cobertura: {item.cobertura()}, Base: {item.corpo()}");
            }
        }
    }
}
