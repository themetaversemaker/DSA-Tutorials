namespace Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8};
            Console.WriteLine("Enter the value to search :: ");
            int valueToSearch = int.Parse(Console.ReadLine());
            int position = BooleanSearch(values,valueToSearch);
            Console.WriteLine($"The value {valueToSearch} is present at index {position}");
        }

        public static int BooleanSearch(int[] values,int valuesToSearch)
        {
            int startPos = 0;
            int endPos = values.Length - 1;
            while (startPos <= endPos)
            {
                int midPos = (startPos + endPos) / 2;
                if (values[midPos] == valuesToSearch)
                {
                    return midPos;
                }
                else if (values[midPos] > valuesToSearch)
                {
                    endPos = midPos-1;
                }
                else
                {
                    startPos = midPos+1;
                }

            }
            return -1;
        }
    }
}