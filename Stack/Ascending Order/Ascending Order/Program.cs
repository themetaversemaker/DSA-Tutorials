using System.Collections;

namespace Ascending_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalValue = 0;
            int count = 0;
            Stack<int> userInput = new Stack<int>();

            Console.WriteLine("Enter the total Value");
            totalValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the {0} values :: ", totalValue);
            while (count != totalValue)
            {
                userInput.Push(int.Parse(Console.ReadLine()));
                count++;
            }            
            foreach (int i in userInput)
            {
                Console.WriteLine(i);
            }
            userInput = SortAscending(userInput);
            foreach (int i in userInput)
            {
                Console.WriteLine(i);
            }
            userInput = SortDescending(userInput);
            foreach (int i in userInput)
            {
                Console.WriteLine(i);
            }
        }

        
        public static Stack<int> SortAscending(Stack<int> stack)
        {
            Stack<int> result = new Stack<int>();
            while (stack.Count > 0)
            {
                int val = stack.Pop();
                while (result.Count > 0 && result.Peek() < val) 
                {
                    stack.Push(result.Pop());
                }
                result.Push(val);
            }
            return result;
                
        }

        public static Stack<int> SortDescending(Stack<int> stack)
        {
            Stack<int> res = new Stack<int>();
            while(stack.Count > 0)
            {
                int currentVal = stack.Pop();
                while(res.Count>0 && res.Peek() > currentVal)
                {
                    stack.Push(res.Pop());
                }
                res.Push(currentVal);
            }
            return res;
        }

    }
}