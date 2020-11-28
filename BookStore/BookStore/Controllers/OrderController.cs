using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.ModelDtos;
using BookStore.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpPost]
        public IActionResult GetOrder(OrderDto order)
        {
            orderService.Create(order);
            return Ok();
        }
    }
}