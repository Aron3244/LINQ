using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Where");
            Console.WriteLine("2.OrderBy");
            Console.WriteLine("3.Select");
            Console.WriteLine("4.Skip");
            Console.WriteLine("5.TakeWhile");
            Console.WriteLine("6.ThenByLINQ");
            Console.WriteLine("7.Average");
            Console.WriteLine("8.Max");
            Console.WriteLine("9.Total");
            Console.WriteLine("10.Any");
           

            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Where();
                    break;

                case 2:
                    OrderBy();
                    break;

                case 3:
                    Select();
                    break;

                case 4:
                    Skip();
                    break;
                case 5:
                    TakeWhile();
                    break;
                
                case 6:
                    ThenByLINQ();
                    break;
                case 7:
                    Average();
                    break;
                case 8:
                    Max();
                    break;

                case 9:
                    Total();
                    break;
                
                    
                case 10:
                    Any();
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }
        }

        public static void Where()
        {
            var takeWhile = ProductList.Products.Where(x => x.Price > 50);

            foreach (var item in takeWhile)
            {
                Console.WriteLine(item.Price);
            }
        }
        public static void OrderBy()
        {
            var thenByResult = ClientsList.Clients
                .OrderBy(x => x.Name)
                .ThenBy(x => x.City);

            
            foreach (var item in thenByResult)
            {
                Console.WriteLine(item.Name + " " + item.City);
            }

        }

        public static void Select()
        {
            var result = ProductList.Products
                        .Select(x => new
                        {
                            Name = x.Name,

                        });
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }
        }

        public static void Skip()
        {
            var thenByResult = ProductList.Products
                .OrderBy(x => x.Price);
            var skip = ProductList.Products.Skip(3);

            foreach (var item in skip)
            {
                Console.WriteLine(item.Name);
            }
        }

        public static void TakeWhile()
        {

            var whileskip = ProductList.Products.SkipWhile(x => x.Price > 100);

            foreach (var item in whileskip)
            {
                Console.WriteLine(item.Price);
            }



        }

        public static void ThenByLINQ()
        {
           
        
            var thenByResult = ClientsList.Clients
                .OrderBy(x => x.Name)
                 .ThenBy(x => x.Id);

           



            foreach (var item in thenByResult)
            {
                Console.WriteLine(item.Name + " " + item.Id);
            }
        }
        static void Average()
        {
            var averageAge = ProductList.Products.Average(x => x.Price);

            Console.WriteLine("The average Price is " + averageAge);

        }

        static void Max()
        {
            var averageAge = ProductList.Products.Max(x => x.Price);

            Console.WriteLine (averageAge);

        }

        static void Total()
        {
            var total = ProductList.Products.Count();

            Console.WriteLine(total);
        }

        public static void Any()
        {

            bool result = ProductList.Products.Any(x => x.Price > 500);

            Console.WriteLine(result);
        }
    }
}
