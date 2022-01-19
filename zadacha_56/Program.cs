//Написать программу, которая обменивает элементы первой строки и последней строки
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
void Replace(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int i = matrix.GetLength(0) - 1;
        int number = matrix[0,j];
        matrix[0,j] = matrix[i,j];
        matrix[i,j] = number;
    }
}
Console.Write(" Введите количество строк массива ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write(" Введите количество столбцов массива ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int [ m, n];
FillArray(matrix, 0, 10);
PrintMatrix(matrix);
Console.WriteLine(" Меняем элементы первой строки и последней ");
Replace(matrix);
PrintMatrix(matrix);
