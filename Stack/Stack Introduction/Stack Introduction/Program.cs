namespace Stack_Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Ricciardo");
            stack.Push("Perez");
            stack.Push("Hamilton");
            stack.Push("Leclerc");
            Console.WriteLine("The elements in Stack\n-------------------");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("The top element in stack :: {0}  ",stack.Peek());
            Console.WriteLine("Total elements in stack :: {0}", stack.Count);
            stack.Pop();
            Console.WriteLine("The top element in stack :: {0}  ", stack.Peek());
            Console.WriteLine("Total elements in stack :: {0}",stack.Count);

        }
    }
}