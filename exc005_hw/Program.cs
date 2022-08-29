//  Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateArray2D(int verticalLength, int horizontalLength, double minValue = -10, int maxValue = 10)
{
    double[,] array2D = new double[verticalLength, horizontalLength];

    Random rand = new Random();

    for (int i = 0; i < verticalLength; i++)
    {
        for (int j = 0; j < horizontalLength; j++)
        {
            array2D[i, j] = rand.NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return array2D;
}

void PrintArray2D(double[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($" {Math.Round(array2D[i, j], 1)} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input vertical length: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Input horizontal length: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] matrix = CreateArray2D(rows, columns);

Console.WriteLine();
PrintArray2D(matrix);