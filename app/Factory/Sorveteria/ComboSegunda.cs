using System;

public class ComboSegunda : ISorvete
{
    public string sabor()
    {
        return "chocolate";
    }

    public string cobertura()
    {
        return "morango";
    }

    public string corpo(){
        return "casquinha";
    }
    
    public void MostrarInformacoes()
    {
        Console.WriteLine($"Sabor: {sabor()}, Cobertura: {cobertura()}, Recipiente: {corpo()}");
    }
}