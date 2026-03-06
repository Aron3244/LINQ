using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class ProductList
    {
        public static readonly List<Product> Products = new List<Product>
        {
                new Product()
            {
                Id = 1,
                Name = "Komm",
                Category = "Söök",
                Price = 1,
                Amount = 1,
           },
                 new Product()
            {
                Id = 2,
                Name = "Arvuti",
                Category = "Elektroonika",
                Price = 700,
                Amount = 4,
           },
                  new Product()
            {
                Id = 3,
                Name = "Auto",
                Category = "Trantsport",
                Price = 10000,
                Amount = 500,
           },
                   new Product()
            {
                Id = 4,
                Name = "Sai",
                Category = "Söök",
                Price = 2,
                Amount = 1,
           },
                    new Product()
            {
                Id = 5,
                Name = "Telefon",
                Category = "Elektroonika",
                Price = 500,
                Amount = 2,
           },
                     new Product()
            {
                Id = 6,
                Name = "T-särk",
                Category = "Riided",
                Price = 10,
                Amount = 1,
           },
                      new Product()
            {
                Id = 7,
                Name = "kala",
                Category = "Söök",
                Price = 2,
                Amount = 1,
           },
                       new Product()
            {
                Id = 8,
                Name = "Piim",
                Category = "Jook",
                Price = 1,
                Amount = 1,
           },
                        new Product()
            {
                Id = 9,
                Name = "Müts",
                Category = "Riided",
                Price = 5,
                Amount = 1,
           },
                         new Product()
            {
                Id = 10,
                Name = "Buss",
                Category = "Trantsport",
                Price = 80000,
                Amount = 1000,
           },
        };

    }
}
