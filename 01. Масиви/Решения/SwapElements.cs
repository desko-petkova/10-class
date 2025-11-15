namespace SwapElements
{
    internal class Program
    {
        //задача 8. Размяна на най-големия и най-малкия елемент
        static void Main(string[] args)
        {
            int maxIndex = 0;
            int minIndex = 0;

            int[] arr = { 7, 2, 3, 4, 5, 6, 1};

            // печат на входния масив
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[maxIndex]) maxIndex = i;
                if (arr[i] < arr[minIndex]) minIndex = i;
            }

            // размяна
            int temp = arr[maxIndex];
            arr[maxIndex] = arr[minIndex];
            arr[minIndex] = temp;

            // печат на резултата
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
