using System.Collections.Specialized;

namespace Array_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] drivers = { "Ricciardo", "Leclerc", "Hamilton", "Perez" };
            Console.WriteLine("Total Drivers :: "+drivers.Length);
            Console.WriteLine("Race Winner :: " + drivers[0]);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Complete Array Elements ::");
            foreach (string driver in drivers)
            {
                Console.WriteLine(driver);
            }
            Console.WriteLine("----------------------------");
            Array.Reverse(drivers);
            Console.WriteLine("Reversing the Array ::");
            foreach (string driver in drivers)
            {
                Console.WriteLine(driver);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Hamilton's Position in array :: "+ Array.IndexOf(drivers, "Hamilton"));
        }
    }
}