// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int[,] CreateArray2D(int verticalLength, int horizontalLength, int minValue = -9, int maxValue = 9)
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

Console.Write("Input vertical length: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Input horizontal length: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] matrix = CreateArray2D(rows, columns);

Console.WriteLine();
PrintArray2D(matrix);
Console.WriteLine();

Console.Write("Input vertical position of element: ");
int verticalIndex = int.Parse(Console.ReadLine()!);
Console.Write("Input horizontal position of element: ");
int horizontalIndex = int.Parse(Console.ReadLine()!);

if (verticalIndex < rows
    && verticalIndex >= 0
    && horizontalIndex < columns
    && horizontalIndex >= 0
)
{
    Console.WriteLine($"\n{matrix[verticalIndex, horizontalIndex]}");
}
else Console.WriteLine("\nElement doesn't exist in the array");