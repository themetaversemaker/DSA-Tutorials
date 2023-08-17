namespace Queue_Operations
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int totalDrivers = 0;
            Queue<string> drivers = new Queue<string>();
            Console.WriteLine("Enter the total drivers :: ");
            totalDrivers = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the name of {totalDrivers} drivers ");
            while(count!=totalDrivers)
            {
                drivers.Enqueue(Console.ReadLine());
                count++;
            }
            Console.WriteLine($"Peek operation :: {drivers.Peek()}");
            Console.WriteLine($"First Out :: {drivers.Dequeue()}");

        }
    }
}