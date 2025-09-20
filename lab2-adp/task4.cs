using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_adp
{
    internal class task4
    {

        public class Service
        {
            public void DoSomething()
            {
                Console.WriteLine("Doing something...");
            }
        }

        public class Client
        {
            private readonly Service _service;

            public Client(Service service)
            {
                _service = service;
            }

            public void Execute()
            {
                _service.DoSomething();
            }
        }

    }
}
