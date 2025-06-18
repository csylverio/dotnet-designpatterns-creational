using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebDesignPattern.Api.SingletonExample;

namespace WebDesignPattern.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SingletonController : ControllerBase
{
    private readonly Guid _guid = Guid.NewGuid();
    private readonly INormalClass _normalClass;

    public SingletonController(INormalClass normalClass)
    {
        _normalClass = normalClass;
    }

    /// <summary>
    /// Retorna o GUID do Singleton clássico.
    /// </summary>
    [HttpGet("classic")]
    public IActionResult GetSingletonGuid()
    {
        string singletonGuid = MySingleton.GetInstance().GetId();
        return Ok(new
        {
            SingletonGuid = singletonGuid,
            ControllerRequestGuid = _guid.ToString()
        });
    }

    /// <summary>
    /// Retorna o GUID do Singleton com Lazy<T>.
    /// </summary>
    [HttpGet("lazy")]
    public IActionResult GetLazySingletonGuid()
    {
        string lazySingletonGuid = MyLazySingleton.GetInstance().GetId();
        return Ok(new
        {
            LazySingletonGuid = lazySingletonGuid,
            ControllerRequestGuid = _guid.ToString()
        });
    }

        /// <summary>
    /// Retorna o GUID do Singleton por meia de injeção de dependência
    /// </summary>
    [HttpGet("di")]
    public IActionResult GetDiSingletonGuid()
    {
        string diSingletonGuid = _normalClass.GetId();
        return Ok(new
        {
            DiSingletonGuid = diSingletonGuid,
            ControllerRequestGuid = _guid.ToString()
        });
    }
}
