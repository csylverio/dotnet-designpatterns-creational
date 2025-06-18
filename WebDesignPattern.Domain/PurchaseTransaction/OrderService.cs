using System;

namespace WebDesignPattern.Domain.PurchaseTransaction;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;
    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public Order Create(Order order)
    {
        _orderRepository.Add(order);

        return order;
    }
}
