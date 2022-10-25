/*Задайте двумерный массив размером m*n, и заполненный случайными 
вещественными числами*/

double [,] GetMatrix(int m, int n)
{
    double[,] matrix = new double[m,n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
       for (int j = 0; j < n; j++)
       {
            matrix[i,j] = Math.Round((rnd.NextDouble() * (10 - 1) + 1),2) ;
       } 
    }
    return matrix;
}

void PrintArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}

int GetNumOfLengs (string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int m = GetNumOfLengs("Введите количество строк");
int n = GetNumOfLengs("Введите количество столбцов");
double [,] matrix = GetMatrix(m, n);
PrintArray(matrix);