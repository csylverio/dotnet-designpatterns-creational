using System;

namespace WebDesignPattern.Api.SingletonExample;

public class NormalClass : INormalClass
{
    private Guid _id = Guid.NewGuid();

    public NormalClass()
    {
        Console.WriteLine("NormalClass instance created");
    }

    public string GetId()
    {
        return _id.ToString();
    }
}
