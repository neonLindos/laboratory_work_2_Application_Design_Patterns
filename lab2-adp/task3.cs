namespace lab2_adp
{
    internal class task3
    {
        public enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        public class Calculator
        {
            public double PerformOperation(Operation op, double a, double b)
            {
                switch (op)
                {
                    case Operation.Add:
                        return a + b;
                    case Operation.Subtract:
                        return a - b;
                    case Operation.Multiply:
                        return a * b;
                    case Operation.Divide:
                        if (b == 0)
                        {
                            throw new DivideByZeroException("Cannot divide by zero.");
                        }
                        return a / b;
                    default:
                        throw new InvalidOperationException("Unknown operation.");
                }
            }
        }

        public static void testCalculator()
        {
            Calculator calculator = new Calculator();
            double sum = calculator.PerformOperation(Operation.Add, 5, 3);
            Console.WriteLine($"5 + 3 = {sum}");
            double difference = calculator.PerformOperation(Operation.Subtract, 5, 3);
            Console.WriteLine($"5 - 3 = {difference}");
            double product = calculator.PerformOperation(Operation.Multiply, 5, 3);
            Console.WriteLine($"5 * 3 = {product}");
            double quotient = calculator.PerformOperation(Operation.Divide, 5, 2);
            Console.WriteLine($"5 / 2 = {quotient}");
        }
    }
}
