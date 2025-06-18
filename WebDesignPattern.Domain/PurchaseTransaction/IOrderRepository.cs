using System;

namespace WebDesignPattern.Domain.PurchaseTransaction;

public interface IOrderRepository
{
    void Add(Order order);
}
