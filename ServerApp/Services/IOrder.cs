using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerApp.Data;

namespace ServerApp.Services
{
    public interface IOrder
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
        Order GetById(int id);
    }
}
