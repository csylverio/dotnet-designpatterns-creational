using Microsoft.AspNetCore.Mvc;
using WebDesignPattern.Api.DTOs;
using WebDesignPattern.Domain.PurchaseTransaction;

namespace WebDesignPattern.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BuilderController : ControllerBase
{
    private readonly IOrderService _orderService;
    private readonly IOrderBuilder _orderBuilder;

    public BuilderController(IOrderService orderService, IOrderBuilder orderBuilder)
    {
        _orderService = orderService;
        _orderBuilder = orderBuilder;
    }


    /// <summary>
    /// Executa processo com builder para criar pedido
    /// </summary>
    [HttpPost("create")]
    public IActionResult Create([FromBody] OrderDTO orderDTO)
    {
        IOrderBuilder orderBuilder = _orderBuilder.SetCustomerId(orderDTO.CustomerId)
           .SetPaymentMethod(orderDTO.PaymentMethodId)
           .SetShippingMethod(orderDTO.ShippingMethodId)
           .SetDiscount(orderDTO.Discount)
           .AddItem(5, 6)
           .AddItem(7, 8);

        foreach (var item in orderDTO.Items)
        {
            orderBuilder.AddItem(item.ProductId, item.Quantity);
        }

        Order order = orderBuilder.Build();
        order =_orderService.Create(order);

        // TODO: converter em DTO
        return Ok(order);
    }
}
