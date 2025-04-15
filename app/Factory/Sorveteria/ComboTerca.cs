using System;

public class ComboTerca : ISorvete
{
    public string sabor()
    {
        return "baunilha";
    }
    
    public string cobertura()
    {
        return "chocolate";
    }
    
    public string corpo(){
        return "copo";
    }

    public void MostrarInformacoes()
    {
        Console.WriteLine($"Sabor: {sabor()}, Cobertura: {cobertura()}, Recipiente: {corpo()}");
    }
}
