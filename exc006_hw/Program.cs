// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int rows = 4;
int columns = 5;

int[,] array2D = new int[rows, columns];

Random rand = new Random();

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array2D[i, j] = rand.Next(1, 10);
        Console.Write($" {array2D[i, j]} ");
    }
    Console.WriteLine();
}

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
    Console.WriteLine($"{array2D[verticalIndex, horizontalIndex]}");
}
else Console.WriteLine("Element doesn't exist in the array");