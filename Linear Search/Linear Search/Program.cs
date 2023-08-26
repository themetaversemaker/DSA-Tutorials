namespace Linear_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int count = 0;
            Console.WriteLine("Linear Search\n-------\n");
            Console.WriteLine("Player 1 :: Enter three driver names");
            while (count != 3)
            {
                list.Add(Console.ReadLine());
                count++;
            }
            Console.Clear();
            Console.WriteLine("Player 2 :: Enter a driver name :: ");
            string name = Console.ReadLine();
            bool result = LinearSearch(list, name);
            Console.Clear();
            if(result)
            {
                Console.WriteLine("CORRECT! You guessed it!");
            }
            else
            {
                Console.WriteLine("OOPS! You didn't get it right");
            }
        }

        private static bool LinearSearch(List<string> list, string name) 
        {
            foreach(string item in list)
            {
                if(item == name)
                    return true;
            }
            return false;
        }
    }

}