namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = UserData(6);
            SelectionSort(values);
            foreach(int i in values)
            {
                Console.WriteLine(i);
            }
        }

        public static void SelectionSort(int[] userArray)
        {
            for (int index = userArray.Length - 1; index > 0; index--)
            {
                int initalPos = 0;

                //7|9|0|2|5|2
                for (int i = 1; i <= index; i++)
                {
                    if (userArray[i] > userArray[initalPos])
                    {
                        initalPos = i;
                    }
                }
                Swapper(userArray, initalPos, index);
            }
        }

        public static void Swapper(int[] array, int initalPos, int swappedPos)
        {
            if (array[initalPos] == array[swappedPos])
            {
                return;
            }
            int temp = array[initalPos];
            array[initalPos] = array[swappedPos];
            array[swappedPos] = temp;
        }

        public static int[] UserData(int count)
        {
            int[] userInput = new int[count];
            for (int i = 0; i < count; i++)
            {
                userInput[i] = int.Parse(Console.ReadLine());
            }
            return userInput;
        }
    }
}