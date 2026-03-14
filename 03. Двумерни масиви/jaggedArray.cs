namespace jagged
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Създаване на назъбен масив с 3 реда
            int[][] jagged = new int[3][];

            // 2. Инициализация на всеки ред
            jagged[0] = new int[] { 1, 2 };
            jagged[1] = new int[] { 3, 4, 5, 6 };
            jagged[2] = new int[] { 7 };

            // 3. Достъп до конкретен елемент
            int x = jagged[1][2];

            // 4. Извеждане на резултати
            Console.WriteLine($"Value of element jagged[1][2]: {x}");     // стойност на елемент
            Console.WriteLine($"Number of rows: {jagged.Length}");        // брой редове
            Console.WriteLine($"number of elements in the second row:{jagged[1].Length}");  // брой елементи във втория ред

            // 2. Изпълнение на задачите
            PrintJaggedArray(jagged);              // Задача 1
            PrintRowLengths(jagged);               // Задача 2
            PrintEvenElements(jagged);             // Задача 3
            PrintMaxPerRow(jagged);                // Задача 4

            Console.WriteLine("===================================");
            int totalSum = SumAllElements(jagged); // Задача 5
            Console.WriteLine($"Task 5 (sum of all elements): {totalSum}");
            Console.WriteLine();

            Console.WriteLine("===================================");
            int[] rowSums = SumPerRow(jagged);     // Задача 6
            Console.WriteLine("Task 6 (sum per row):");
            Console.WriteLine(string.Join(" ", rowSums));
        }
        // --------------------------------------------------
        // Задача 1: Извеждане на всички елементи
        // --------------------------------------------------
        static void PrintJaggedArray(int[][] arr)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Task 1: Print jagged array");

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        // --------------------------------------------------
        // Задача 2: Брой елементи във всеки ред
        // --------------------------------------------------
        static void PrintRowLengths(int[][] arr)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Task 2: Length of each row");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Row {i}: {arr[i].Length} element(s)");
            }

            Console.WriteLine();
        }

        // --------------------------------------------------
        // Задача 3: Извеждане само на четните елементи
        // --------------------------------------------------
        static void PrintEvenElements(int[][] arr)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Task 3: Even elements");

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] % 2 == 0)
                    {
                        Console.Write(arr[i][j] + " ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        // --------------------------------------------------
        // Задача 4: Максимален елемент във всеки ред
        // --------------------------------------------------
        static void PrintMaxPerRow(int[][] arr)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Task 4: Max element per row");

            for (int i = 0; i < arr.Length; i++)
            {
                int max = arr[i][0];

                for (int j = 1; j < arr[i].Length; j++)
                {
                    if (arr[i][j] > max)
                    {
                        max = arr[i][j];
                    }
                }

                Console.WriteLine($"Row {i}: max = {max}");
            }

            Console.WriteLine();
        }

        // --------------------------------------------------
        // Задача 5: Сума на всички елементи
        // --------------------------------------------------
        static int SumAllElements(int[][] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    sum += arr[i][j];
                }
            }

            return sum;
        }

        // --------------------------------------------------
        // Задача 6: Сума на елементите по редове
        // --------------------------------------------------
        static int[] SumPerRow(int[][] arr)
        {
            int[] sums = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                int currentSum = 0;

                for (int j = 0; j < arr[i].Length; j++)
                {
                    currentSum += arr[i][j];
                }

                sums[i] = currentSum;
            }

            return sums;
        }
    }

}

