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
        }
    }
}