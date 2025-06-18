using System;

namespace WebDesignPattern.Api.FactoryExample;

public class CsvParser : DocumentParser
{
    public override string Parse(string filePath)
    {
        Console.WriteLine("Executa conversão do arquivo para CSV.");
        return $"Parsing CSV: {filePath}";
    }
}
