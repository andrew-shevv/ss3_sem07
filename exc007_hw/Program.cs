// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rows = 4;
int columns = 5;

int[,] array2D = new int[rows, columns];

double[] meanColumns = new double[columns];

Random rand = new Random();

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array2D[i, j] = rand.Next(1, 10);
        meanColumns[j] += Convert.ToDouble(array2D[i, j]) / rows;
        Console.Write($" {array2D[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Mean average of each column: " + string.Join("; ", meanColumns.Select(x => Math.Round(x, 1))));