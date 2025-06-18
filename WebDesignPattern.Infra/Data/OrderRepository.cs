using System;
using WebDesignPattern.Domain.PurchaseTransaction;

namespace WebDesignPattern.Infra.Data;

public class OrderRepository : IOrderRepository
{
    public void Add(Order order)
    {
       Console.WriteLine("OrderRepository.Add");
    }
}
