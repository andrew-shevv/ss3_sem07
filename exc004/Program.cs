// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольный

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

int GetSumOfDiagonal(int[,] array2D)
{
    int limit;
    int sum = 0;
    if (array2D.GetLength(0) > array2D.GetLength(1))
    {
        limit = array2D.GetLength(1);
    }
    else limit = array2D.GetLength(0);

    for (int i = 0; i < limit; i++)
    {
        sum += array2D[i, i];
    }
    return sum;
}

Console.Write("Input vertical length: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Input horizontal length: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] matrix = CreateArray2D(rows, columns);

Console.WriteLine();
PrintArray2D(matrix);

Console.WriteLine($"\nSum of elements on main diagonal = {GetSumOfDiagonal(matrix)}");