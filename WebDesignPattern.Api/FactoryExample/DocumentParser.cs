using System;

namespace WebDesignPattern.Api.FactoryExample;


/// <summary>
/// Representa um produto do DocumentoParser
/// </summary>
public abstract class DocumentParser
{
      public abstract string Parse(string filePath);
}
