using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class ClientsList
    {

        public static readonly List<Client> Clients = new List<Client>
        {
            new Client
            {
                Id = 1,
                Name = "Malle",
                City = "Tallinn"
            },
             new Client
            {
                Id = 2,
                Name = "Kalle",
                City = "Tartu"
            },
              new Client
            {
                Id = 3,
                Name = "Muri",
                City = "Pärbu"
            },
               new Client
            {
                Id = 4,
                Name = "Mart",
                City = "Kuresaare"
            },
                new Client
            {
                Id = 5,
                Name = "Olle",
                City = "Tallinn"
            },
        };
    }
}
