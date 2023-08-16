
// A letter means push and an asterisk means pop in the
// following sequence.  Give the sequence of values returned by the pop operations
// when this sequence of operations is performed on an initially empty LIFO stack.
// E A S * Y * Q U E * * * S T * * * I O * N * * *
namespace Push_Pop_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[] { 'E','A','S','*','Y','*','Q','U','E','*','*','*','S','T','*','*','*','I','O','*','N','*','*','*' };
            Stack<char> inputPattern = new Stack<char>() { };
            foreach (char c in arr)
            {
                if (c != '*') 
                {
                    inputPattern.Push(c);
                }
                else
                {
                    Console.WriteLine($"Element Popped :: {inputPattern.Pop()}");
                }
            }

        }
    }
}