namespace lab2_adp
{
    internal class task2
    {
        // Общая база
        public abstract class Car
        {
            public void Start()
            {
                Console.WriteLine("Car started.");
            }

            public void Stop()
            {
                Console.WriteLine("Car stopped.");
            }
        }

        public class Truck : Car
        {
            public Truck()
            {
                Console.WriteLine("Truck created.");
            }
        }
    }
}
