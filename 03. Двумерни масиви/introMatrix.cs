namespace Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1.Дефиниране и инициализация на двумерен масив
            int[,] matrix =
            {//  0  1  2  3  4 -> индекси на колоните
                {1, 2, 3, 4, 5 },       // ред 0
                {6, 7, 8, 9, 10 },      // ред 1
                {11, 12, 13, 14, 15 }   // ред 2
            };
            // 2. Достъп до конкретен елемент
            Console.WriteLine("Element matrix[1,3] = " + matrix[1, 3]);

            // 3. Общ брой елементи в матрицата
            int totalElements = matrix.Length;
            Console.WriteLine("Total elements = " + totalElements);

            // 4. Размери на матрицата
            int rows = matrix.GetLength(0);   // брой редове
            int cols = matrix.GetLength(1);   // брой колони

            Console.WriteLine("Rows = " + rows);
            Console.WriteLine("Columns = " + cols);


            // 5. Извеждане на матрицата във вид на таблица
            Console.WriteLine("Matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],3} ");

                }
                Console.WriteLine();

            }

        }

    }
}
