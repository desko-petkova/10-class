namespace SumArrElement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] arr =
            {
                { -1, 0, 2 },
                { 4, 5, 6 },
                { 7, 8, 2 }
            };

            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
          
            for(int i = 0; i < rows; i++)
            {
                int sum = 0;        // 1) нулираме сумата за реда
                for (int j= 0; j< cols; j++)
                {
                    sum += arr[i, j]; // 2) добавяме елементите от текущия ред
                }
                Console.WriteLine($"Sum of elements in row {i+1} is {sum}");

            }


        }
    }
}
