// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArray2D(int verticalLength, int horizontalLength, int minValue = 1, int maxValue = 9)
{
    int[,] array2D = new int[verticalLength, horizontalLength];

    Random rand = new Random();

    for (int i = 0; i < verticalLength; i++)
    {
        for (int j = 0; j < horizontalLength; j++)
        {
            array2D[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }
    return array2D;
}

void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($" {array2D[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] AverageOfColumns(int[,] array2D)
{
    double[] meanColumnsArray = new double[array2D.GetLength(1)];

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            meanColumnsArray[j] += Convert.ToDouble(array2D[i, j]) / array2D.GetLength(0);
        }
    }
    return meanColumnsArray;
}

Console.Write("Input vertical length: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Input horizontal length: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] matrix = CreateArray2D(rows, columns);

Console.WriteLine();
PrintArray2D(matrix);

Console.WriteLine("\nMean average of each column: " + string.Join("; ", AverageOfColumns(matrix).Select(x => Math.Round(x, 1))));