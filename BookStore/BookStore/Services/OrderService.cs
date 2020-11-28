using BookStore.Data;
using BookStore.ModelDtos;
using BookStore.Repositories.Interfaces;
using BookStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepo;
        private readonly IBookService bookService;

        public OrderService(IOrderRepository orderRepo, IBookService bookService)
        {
            this.orderRepo = orderRepo;
            this.bookService = bookService;
        }

        public void Create(OrderDto order)
        {
            var books = bookService.GetByIds(order.BookIds);

            var newOrder = new Order
            {
                Name = order.Name,
                Surname = order.Surname,
                Email = order.Email,
                Phone = order.Phone,
                FullPrice = books.Sum(x => x.Price),
                BookOrders = order.BookIds.Select(x => new BookOrders
                {
                    BookId = x
                }).ToList(),

            };

            orderRepo.Create(newOrder);
        }
    }
}
