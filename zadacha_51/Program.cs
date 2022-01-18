// Задать двумерный массив следующим правилом: Aₘₙ = m+n
int[,] FillArray(int rows, int columns)
{
    int[,] newMatrix = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newMatrix[i,j] = i + j;          // если нужно, чтобы элементы считались не от нуля то i + j + 2
        }
    }
    return newMatrix;
}
void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]} ");
        }
        Console.WriteLine();
    }
}
Console.Write($"Введите количество строк m: ");
int m = int.Parse(Console.ReadLine() ??"0");
Console.Write($"Введите количество столбцов n: ");
int n = int.Parse(Console.ReadLine() ??"0");
int[,] matrix = FillArray(m, n);
PrintArray(matrix);


