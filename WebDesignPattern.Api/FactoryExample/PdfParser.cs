using System;

namespace WebDesignPattern.Api.FactoryExample;

public class PdfParser : DocumentParser
{
    public override string Parse(string filePath)
    {
        Console.WriteLine("Executa conversão do arquivo para PDF.");
        return $"Parsing PDF: {filePath}";
    }
}
