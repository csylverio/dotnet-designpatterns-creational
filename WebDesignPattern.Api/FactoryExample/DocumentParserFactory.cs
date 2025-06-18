using System;

namespace WebDesignPattern.Api.FactoryExample;

public class DocumentParserFactory : IDocumentParserFactory
{
    public DocumentParser Create(string extension)
    {
        // Remove o ponto inicial, se houver
        if (extension.StartsWith("."))
            extension = extension.Substring(1);


        DocumentParser documentParser;
        switch (extension)
        {
            case "pdf":
                documentParser = new PdfParser();
                break;
            case "csv":
                documentParser = new CsvParser();
                break;
            default:
                throw new NotSupportedException("Type not supported!");
        }

        return documentParser;
    }
}
