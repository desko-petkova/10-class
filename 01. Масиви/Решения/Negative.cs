namespace Negative
{
    internal class Program
    {
        //задача 3. Брой на отрицателни елементи
        static void Main(string[] args)
        {
            int[] arr = { 5, -6, 7, -1, 9, -1, -5 };

            int countNeg = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    countNeg++;
            }

            Console.WriteLine("Negative count = " + countNeg);
        }
    }
}
