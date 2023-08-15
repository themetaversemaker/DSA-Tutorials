namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List in C#\n-----------------------------");
            List<string> drivers = new List<string>();
            drivers.Add("Ricciardo");
            drivers.Add("Leclerc");
            drivers.Add("Perez");
            drivers.Add("Hamilton");
            drivers.Add("Sainz");
            drivers.Add("Russel");
            foreach (string driver in drivers)
            {
                Console.WriteLine(driver);
            }
            Console.WriteLine("------------\nNew Driver added\n------------");
            drivers.Add("Piastri");
            foreach (string driver in drivers)
            {
                Console.WriteLine(driver);
            }
            Console.WriteLine("--------LIST OPERATIONS-------------");
            Console.WriteLine("Total elements in list :: "+drivers.Count());
            Console.WriteLine("Enter the driver name :: ");
            string name = Console.ReadLine();
            if (drivers.Contains(name))
            {
                Console.WriteLine(name +" has no penalty points");
            }
            else
            {
                Console.WriteLine(name + " has penalty points");
            }
            Console.WriteLine("--------------------------------");
            List<string>driverSquad2 = new List<string>() { "Verstappen","Norris","Alonso","Ocon","Gasly"};
            Console.WriteLine("Capacity of second List :: "+driverSquad2.Capacity);
            drivers.AddRange(driverSquad2);
            Console.WriteLine("------------AFTER MERGING TWO LISTS------------------------");
            foreach (string driver in drivers)
            { Console.WriteLine(driver); }
            drivers.Sort();
            Console.WriteLine("------------DRIVERS AFTER SORTING------------------------");
            foreach (string driver in drivers)
            { Console.WriteLine(driver); }
            Console.WriteLine("Position of Ocon :: "+ drivers.BinarySearch("Ocon"));
            Console.WriteLine("------------REMOVING A DRIVER------------------------");
            Console.WriteLine("Enter the position number :: ");
            string id = Console.ReadLine();
            int val = int.Parse(id);
            string driverName = drivers[val].ToString();
            drivers.Remove(driverName);
            Console.WriteLine("------------AFTER REMOVE OPERATION------------------------");
            foreach (string driver in drivers)
            { Console.WriteLine(driver); }
            Console.WriteLine("------------REMOVING A SERIES OF DRIVER------------------------");
            Console.WriteLine("Enter the start and total count number :: ");
            int startVal = int.Parse(Console.ReadLine());
            int endVal = int.Parse(Console.ReadLine());
            drivers.RemoveRange(startVal, endVal);
            foreach (string driver in drivers)
            { Console.WriteLine(driver); }
        }
    }
}