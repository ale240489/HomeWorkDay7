/* Напишите прошрамму, которая на вход принимает позиции элемента в
двумерном массиве, и возвращает значение этого элемента, или же
указание что этого элемента нет.*/

int [,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
       for (int j = 0; j < n; j++)
       {
            matrix[i,j] = rnd.Next (1,10);
       } 
    }
    return matrix;
}

void PrintArray (int[,] array)
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

void CheckingNumberOfArray(int[,] matrix, int a, int b)
{
    string not = "Такого числа нет";
    int numOfIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == a && j == b)
                {
                numOfIndex = matrix[i,j];
                Console.WriteLine($"на строке {a+1} в столбце {b+1} находися число {numOfIndex}");
                }
            else if (a>matrix.GetLength(0)||b>matrix.GetLength(1))
                {
                Console.WriteLine(not);
                return;
                }
        }
    }
}

int m = GetNumOfLengs("Введите количество строк");
int n = GetNumOfLengs("Введите количество столбцов");
int a = GetNumOfLengs("Введите строку искомого числа");
int b = GetNumOfLengs("Введите столбец искомого числа");
int[,] matrix = GetMatrix(m,n);
PrintArray(matrix);
Console.WriteLine();
CheckingNumberOfArray(matrix, a, b);

