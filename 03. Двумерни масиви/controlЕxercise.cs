namespace controlЕxercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Въвеждане на размерите на матрицата
            Console.Write("Въведете брой редове: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Въведете брой колони: ");
            int n = int.Parse(Console.ReadLine());


            // 2. Създаване на матрица
            int[,] matrix = new int[m, n];

            // 3. Попълване на матрицата (от конзолата)
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());  
                }
            }
            Console.WriteLine();

            // 4. Извеждане на матрицата
            Console.WriteLine("Матрицата е:");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // 5. Намиране на минимален и максимален елемент
            int min = matrix[0, 0];
            int max = matrix[0, 0];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < min)
                        min = matrix[i, j];

                    if (matrix[i, j] > max)
                        max = matrix[i, j];
                }
            }


            // 6. Извеждане на резултатите
            Console.WriteLine($"Минимален елемент: {min}");
            Console.WriteLine($"Максимален елемент: {max}");

            // 7. Да се намери първият срещнат елемент със стойност 2 и да се изведат неговите индекси.

            bool found = false;
            int rowIndex = 0;
            int colIndex = 0;

            for (int i = 0; i < m ; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 2)
                    {
                        rowIndex = i;
                        colIndex = j;
                        found = true;
                        break;
                    }
                }
            }

            if (found)
            {
                Console.WriteLine($"Елементът 2 е намерен на индекс [{rowIndex}, {colIndex}]");
            }
            else
            {
                Console.WriteLine("Елементът не е намерен.");
            }
        }
    }
}
