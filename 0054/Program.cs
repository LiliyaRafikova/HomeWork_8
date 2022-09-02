internal class Program
{
    private static void Main(string[] args)
    {
        //  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
        Console.Write("Введите количество строк матрицы: ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов матрицы: ");
        int col = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[row, col];

        Console.WriteLine("Масиив до сортирвоки: ");

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(11);
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        //сортировка массива 
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for (int z = matrix.GetLength(1) - 1 - 1; z >= 0; z--)
                {
                    if (matrix[i, z] < matrix[i, z + 1])
                    {
                        int temp = matrix[i, z];
                        matrix[i, z] = matrix[i, z + 1];
                        matrix[i, z + 1] = temp;
                    }
                }
            }
        }
        Console.WriteLine("Масиив после сортирвоки: ");

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {

                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
