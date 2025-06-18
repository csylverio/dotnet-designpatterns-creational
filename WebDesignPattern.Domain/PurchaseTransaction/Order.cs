using System;
using WebDesignPattern.Domain.CustomerRelationshipManagement;

namespace WebDesignPattern.Domain.PurchaseTransaction;

public class Order
{
    public Order()
    {
    }

    public Order(Customer customer, decimal discount, List<Item> items)
    {
        Customer = customer;
        Discount = discount;
        Items = items;
    }

    public int Id { get; set; }
    public Customer? Customer { get; private set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public OrderStatus Status { get; set; } = OrderStatus.Pending;

    // Relacionamento com itens (1 pedido → N itens)
    public List<Item> Items { get; set; } = new List<Item>();

    public decimal Discount { get; set; } = 0;

    public decimal TotalAmount
    {
        //TODO: regras de calculo do desconto
        get { return Items.Sum(item => item.TotalPrice) * (Discount / 100); }
    }
}
