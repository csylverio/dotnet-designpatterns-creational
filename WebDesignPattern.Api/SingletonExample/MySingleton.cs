using System;

namespace WebDesignPattern.Api.SingletonExample;

/// <summary>
/// Exemplo de singleton 
/// Este exemplo não é thread-safe. A versão moderna em C# e recomendada usa Lazy<T>.
/// </summary>
public class MySingleton
{
    private static MySingleton? _instance;
    private Guid _id = Guid.NewGuid();

    private MySingleton()
    {
        Console.WriteLine("MySingleton instance created");
    }

    public static MySingleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new MySingleton();
        }

        return _instance;
    }

    public string GetId()
    {
        return _id.ToString();
    }
}
