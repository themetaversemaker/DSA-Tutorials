//  A letter means push and an asterisk means pop in the
//  following sequence.  Give the contents of s[0], ..., s[4] after the execution of
//  Sedgewick Program 4.4 (or the array implementation of a stack in the
//  ADT Lecture).

//  L A * S T I * N * F I R * S T * * O U * T * * * * * * 

namespace StackChallenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char[] arr = new char[] { 'L', 'A', '*', 'S', 'T', 'I', '*', 'N', '*', 'F', 'I', 'R', '*', 'S', 'T', '*', '*', 'O', 'U', '*', 'T', '*', '*', '*', '*', '*', '*' };
            Stack<char> inputPattern = new Stack<char>();
            foreach (char c in arr)
            {
                if (c != '*')
                {
                    inputPattern.Push(c);
                }

            }
            Console.WriteLine($"s[0] :: {inputPattern.Pop()}");
            Console.WriteLine($"s[1] :: {inputPattern.Pop()}");
            Console.WriteLine($"s[2] :: {inputPattern.Pop()}");
            Console.WriteLine($"s[3] :: {inputPattern.Pop()}");
            Console.WriteLine($"s[4] :: {inputPattern.Pop()}");
        }
    }
}