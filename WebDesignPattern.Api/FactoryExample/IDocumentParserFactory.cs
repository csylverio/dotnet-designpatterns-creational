using System;

namespace WebDesignPattern.Api.FactoryExample;

public interface IDocumentParserFactory
{
    DocumentParser Create(string extension);
}
