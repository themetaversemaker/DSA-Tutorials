namespace ReverseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int totalValue = 0;
            Stack<int> userNumbers = new Stack<int>();
            Console.WriteLine("Enter the total numbers :: ");
            totalValue = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------\nEnter the {0} numbers", count);
            while (count != totalValue)
            {
                userNumbers.Push(int.Parse(Console.ReadLine()));
                count++;
            }
            Console.WriteLine("------------------\n Reversed Number\n------------------");
            foreach (int i in userNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}