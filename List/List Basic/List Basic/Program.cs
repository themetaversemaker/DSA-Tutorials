namespace List_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Enter the total element count :: ");
            int count = int.Parse(Console.ReadLine());
            while(count > 0) 
            {
                Console.WriteLine("Enter the value :: ");
                list.Add(int.Parse(Console.ReadLine()));
                count--;
            }
            Console.Clear();
            Console.WriteLine("Select the Operation\n-----------------\n");
            Console.WriteLine("1.Display the list Content\n2.Check the list size\n3.Add new value to list\n" +
                "4.Remove a value\n5.Remove a range of Values\n6.Sort the list");
            string choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                case "1":
                    DisplayList(list);
                break;

                case "2":
                    Console.WriteLine($"The total elements in list :: {list.Count} and capacity is :: {list.Capacity}");
                break;

                case "3":
                    Console.WriteLine("Enter the new value :: ");
                    list.Add(int.Parse(Console.ReadLine()));
                    DisplayList(list);
                break;

                case "4":
                    Console.WriteLine("Enter the Value to Delete :: ");
                    list.Remove(int.Parse(Console.ReadLine()));
                    DisplayList(list) ;
                break;

                case "5":
                    Console.WriteLine("Remove the range of values to be deleted :: ");
                    list.RemoveRange(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    DisplayList(list);
                break;

                case "6":
                    list.Sort();
                    DisplayList(list);
                    break;

            }
        }

        public static void DisplayList(List<int> listData)
        {
            foreach(int value in listData)
            {
                Console.WriteLine(value);
            }
        }

        
    }
}