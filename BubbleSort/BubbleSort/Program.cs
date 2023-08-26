namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 22, 33, 66, 11, 99, 44, 22 };
            int arrayLength = array.Length;
            while(arrayLength != 0)
            {
                for(int i = 0; i < arrayLength-1; i++)
                {
                    if (array[i] > array[i+1])
                    {
                        Swapper(array,i,i+1);
                    }
                }
                arrayLength--;
            }
            ArrayDisplayer(array);
        }

        public static void Swapper(int[] values,int i,int j)
        {
            if(i == j) return;
            int temp = values[i];
            values[i] = values[j];
            values[j] = temp;
        }

        public static void ArrayDisplayer(int[] finalArray)
        {
            foreach(int value in finalArray)
            {
                Console.WriteLine(value);
            }
        }
    }
}