//  Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Input vertical length: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Input horizontal length: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array2D = new double[rows, columns];

Random rand = new Random();

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array2D[i, j] = rand.NextDouble() * 20 - 10;
        Console.Write($" {Math.Round(array2D[i, j], 1)} ");
    }
    Console.WriteLine();
}