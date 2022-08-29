// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateArray2D(int verticalLength, int horizontalLength)
{
    int[,] array2D = new int[verticalLength, horizontalLength];

    for (int i = 0; i < verticalLength; i++)
    {
        for (int j = 0; j < horizontalLength; j++)
        {
            array2D[i, j] = i + j;
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

Console.Write("Input vertical length: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Input horizontal length: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] matrix = CreateArray2D(rows, columns);

Console.WriteLine();
PrintArray2D(matrix);