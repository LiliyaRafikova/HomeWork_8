//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите количество строк матрицы: ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов матрицы: ");
        int col = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[row, col];
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(21);
                Console.Write(matrix[i, j] + "\t");
           }
         Console.WriteLine();
         }
         int minRowSum = int.MaxValue;
         int indexMinRow = 0;
 
             for (int i = 0; i < matrix.GetLength(0); i++)
             {
                int rowSum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                    rowSum += matrix[i, j];
                
                if (rowSum < minRowSum)
                {
                    minRowSum = rowSum;
                    indexMinRow = i;
                }
             }
 
             Console.WriteLine($"Строка с минимальной суммой элементов: {indexMinRow+1}");
                 for(int j = 0;j<matrix.GetLength(1);j++)
                      Console.Write(matrix[indexMinRow, j] + "\t");
    }
}
