using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class OrderList
    {
        public static readonly List<Order> Orders = new List<Order>
        {
                new Order()
            {
                Id = 1,
                ClientId = 5,
                ProductId = 3121,
                Amount = 100,
           
            },


                new Order()
            {
                Id = 2,
                ClientId = 7,
                ProductId = 3331,
                Amount = 111,

            },

                new Order()
            {
                Id = 3,
                ClientId = 9,
                ProductId = 5543,
                Amount = 1,

            },

                new Order()
            {
                Id = 4,
                ClientId = 10,
                ProductId = 2331,
                Amount = 31,

            },

                new Order()
            {
                Id = 5,
                ClientId = 2,
                ProductId = 3561,
                Amount = 4,

            },

                new Order()
            {
                Id = 6,
                ClientId = 1,
                ProductId = 3177,
                Amount = 1000,

            },

                new Order()
            {
                Id = 7,
                ClientId = 3,
                ProductId = 7232,
                Amount = 12,

            },

                new Order()
            {
                Id = 8,
                ClientId = 12,
                ProductId = 7141,
                Amount = 67,

            },

                new Order()
            {
                Id = 9,
                ClientId = 14,
                ProductId = 8831,
                Amount = 68,

            },

                new Order()
            {
                Id = 10,
                ClientId = 20,
                ProductId = 3991,
                Amount = 67,

            },
        };
    }
}
