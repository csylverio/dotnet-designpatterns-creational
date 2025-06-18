using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebDesignPattern.Api.FactoryExample;

namespace WebDesignPattern.Api.Controllers;


[Route("api/[controller]")]
[ApiController]
public class FactoryController : ControllerBase
{
    private readonly IDocumentParserFactory _documentParserFactory;
    
    public FactoryController(IDocumentParserFactory documentParserFactory)
    {
        _documentParserFactory = documentParserFactory;
    }

    /// <summary>
    /// Executa processo com FactoryMethod para criar documento
    /// </summary>
    [HttpGet("{filename}")]
    public IActionResult Convert(string filename)
    {
        var extension = Path.GetExtension(filename);
        var document = _documentParserFactory.Create(extension);
        var ret = document.Parse(filename);
        return Ok(ret);
    }
}
