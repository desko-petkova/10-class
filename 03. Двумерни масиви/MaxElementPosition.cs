namespace MaxElementPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Максимален елемент + позиция (ред, колона)
            int[,] matrix = new int[3, 3];

            for(int i = 0;  i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int max = matrix[0, 0]; // 1) стартова стойност
            int maxRow = 0;
            int maxCol = 0;

            for (int i = 0; i < rows; i++)           // 2) обхождаме редове
            {
                for (int j = 0; j < cols; j++)       // 3) обхождаме колони
                {
                    if (matrix[i, j] > max)          // 4) сравняваме
                    {
                        max = matrix[i, j];          // 5) обновяваме максимума
                        maxRow = i;                  // 6) пазим позицията
                        maxCol = j;
                    }
                }
            }

            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Row = {maxRow}");
            Console.WriteLine($"Col = {maxCol}");

        }
    }
}
