namespace Array_Greatest_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayCount = 0;

            int listCount = 0;

            int sum = 0;

            int[] values = new int[5];

            Console.WriteLine("Enter the 5 numbers");

            while (arrayCount != 5)
            {
                int currentValue = int.Parse(Console.ReadLine());

                values[arrayCount] = currentValue;

                arrayCount++;
            }
            Console.WriteLine("==================================");

            foreach (int value in values)
            {
                sum += value;
            }
            Console.WriteLine("Total Sum :: "+sum);          

            Console.WriteLine("Largest Value :: "+LargestNumber(values).ToString());

            Console.WriteLine("Largest Value :: "+ SmallNumber(LargestNumber(values),values));
        }

        public static int LargestNumber(int[] series)
        {
            int largestNumber = 0;

            foreach (int value in series)
            {
                if(value > largestNumber)
                {
                    largestNumber = value;
                }
            }
            return largestNumber;
        }

        public static string SmallNumber(int largestValue,int[] series)
        {
            int smallNumber = largestValue;

            foreach (int value in series)
            {
                if (value < smallNumber)
                {
                    smallNumber = value;
                }
            }

            return smallNumber.ToString();
        }
    }
}