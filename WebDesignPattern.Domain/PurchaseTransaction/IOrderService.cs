using System;

namespace WebDesignPattern.Domain.PurchaseTransaction;

public interface IOrderService
{
    Order Create(Order order);
}
