using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_adp
{
    internal class task6
    {
        public class MathOperations
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
        }

        public class Client
        {
            private readonly MathOperations _math = new MathOperations();

            public void Run()
            {
                int result = _math.Add(3, 5);
                Console.WriteLine($"Result: {result}");
            }
        }

    }
}
