//В матрице чисел найти сумму элементов главной диагонали
void FillArray(int [,] array, int start, int end)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(start, end);
        }
    }
}
void PrintMatrix( int[,] Array)
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
int SumDiagonal(int[,] someMatrix)
{
    int sum = 0;
    for (int i = 0; i < someMatrix.GetLength(0);i++)
    {
        for (int j = 0; j < someMatrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + someMatrix[i,j];
            }
        }
    }
    return sum;
}
Console.Write(" Введите количество строк массива ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write(" Введите количество столбцов массива ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int [ m, n];
FillArray(matrix, 0, 10);
PrintMatrix(matrix);
int sumOfMainDiagonal = SumDiagonal(matrix);
Console.WriteLine($" Сумма элементов главной диагонали равна {sumOfMainDiagonal}  ");