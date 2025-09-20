using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_adp
{
    internal class task1
    {
         
        public class OrderService()
        {

            public void CreateOrUpdateOrder(string productName, int quantity, double price)
            {
                // Implementation for creating or updating an order
                double totalPrice = quantity * price;
                Console.WriteLine($"Order for {productName} updated. New total: {totalPrice}");

            }
        }

    }
}
