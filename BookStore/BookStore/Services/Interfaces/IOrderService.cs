﻿using BookStore.ModelDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services.Interfaces
{
    public interface IOrderService
    {
        void Create(OrderDto order);
    }
}
