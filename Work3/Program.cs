/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] GetMatrix()
{
    int[,] matrix = new int[4, 4];
    Random rnd = new Random();
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void ArithmeticOfColumn(int[,] array)
{
    int count = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
     for (int k = 0; k < array.GetLength(0); k++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == count)
                    sum = sum + array[i, j];
            }

        }
        double aritchmetic = sum / array.GetLength(1);
        Console.Write($"{aritchmetic}; ");
        count = count + 1;
    }
}

int[,] matrix = GetMatrix();
PrintArray(matrix);
Console.WriteLine();
ArithmeticOfColumn(matrix);
