using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderClient.OrderService;

namespace OrderClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Send initial message to start the workflow service  
            Console.WriteLine("Sending start message");
            var startProxy = new StartOrderClient();
            string orderId = startProxy.StartOrder("Kim Abercrombie");

            // The workflow service is now waiting for the second message to be sent  
            Console.WriteLine("Workflow service is idle...");
            Console.WriteLine("Press [ENTER] to send an add item message to reactivate the workflow service...");
            Console.ReadLine();

            // Send the second message  
            Console.WriteLine("Sending add item message");
            var addProxy = new AddItemClient();
            var item = new AddItem
            {
                p_itemId = "Zune HD",
                p_orderId = orderId
            };

            string orderResult = addProxy.AddItem(item);
            Console.WriteLine("Service returned: " + orderResult);
            Console.ReadLine();
        }
    }
}
