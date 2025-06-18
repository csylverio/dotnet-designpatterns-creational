using System;

namespace WebDesignPattern.Api.SingletonExample;

// <summary>
/// Exemplo de Singleton utilizando Lazy<T> (thread-safe).
/// Garante que a instância será criada apenas quando usada,
/// e somente uma vez durante todo o ciclo de vida da aplicação.
/// </summary>
public sealed class MyLazySingleton
{
    private static readonly Lazy<MyLazySingleton> _instance =
        new(() => new MyLazySingleton());

    private readonly Guid _id = Guid.NewGuid();

    private MyLazySingleton()
    {
        Console.WriteLine("MyLazySingleton instance created");
    }

    /// <summary>
    /// Retorna a instância única do Singleton.
    /// </summary>
    public static MyLazySingleton GetInstance() => _instance.Value;

    /// <summary>
    /// Retorna o identificador único da instância.
    /// </summary>
    public string GetId() => _id.ToString();
}