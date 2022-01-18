// Показать двумерный массив размером m×n заполненный вещественными числами
double[,] FillArray(int m, int n)
{
    double[,] someMatrix = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        someMatrix[i,j] = (new Random()).Next(-20,80)/10.0;
    }
    return someMatrix;
}
void PrintArray(double [,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]}  ");
        }
        Console.WriteLine();
    }
}

Console.Write($"Введите количество строк m: ");
int m = int.Parse(Console.ReadLine() ??"0");
Console.Write($"Введите количество столбцов n: ");
int n = int.Parse(Console.ReadLine() ??"0");
double[,] matrix = FillArray(m,n);
PrintArray(matrix);