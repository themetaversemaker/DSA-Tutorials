namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalCharacters = 0;
            int count = 0;
            Stack<char> userInput = new Stack<char>();
            Stack<int> userOutput = new Stack<int>();
            Console.WriteLine("Enter total Characters");
            totalCharacters = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the {totalCharacters} characters");
            while(count != totalCharacters)
            {
                userInput.Push(char.Parse(Console.ReadLine()));
                count++;
            }
            Console.WriteLine("------------\nYour Input Characters\n------------");
            //foreach ( char c in userInput.ToArray() ) { Console.WriteLine(c); }
            userInput = CharacterSorter(userInput);
            foreach(char val in userInput) { Console.WriteLine(val); }
            foreach(int val in userInput) { Console.WriteLine(val); }

        }

        public static Stack<char> CharacterSorter(Stack<char> input)
        {
            Stack<char> temp = new Stack<char>();
            char currentChar;
            while(input.Count > 0)
            {
                currentChar = input.Pop();
                while(temp.Count > 0 && (Convert.ToInt32(temp.Peek()) < Convert.ToInt32(currentChar)))
                {
                    input.Push((temp.Pop()));
                }
                temp.Push(currentChar);
            }
            return temp;
        }
    }
}