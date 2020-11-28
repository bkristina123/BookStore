using BookStore.Data;
using BookStore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly BookStoreDbContex context;

        public OrderRepository(BookStoreDbContex context)
        {
            this.context = context;
        }

        public void Create(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }
    }
}
