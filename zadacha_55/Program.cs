// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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
double[] ColumnsAverage(int[,] newMatrix)
{
    double[] average = new double[newMatrix.GetLength(1)];
    for (int j = 0; j < newMatrix.GetLength(1); j++ )
    {
        int Sum = 0;
        for (int i = 0; i < newMatrix.GetLength(0); i++)
        {
             Sum = Sum + newMatrix[i,j]; 
        }
        average[j] = Math.Round((Convert.ToDouble(Sum) / Convert.ToDouble(newMatrix.GetLength(0))),1);
    }
    return average;
}
void PrintArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"# {i+1} = {array[i]}  ");
    }
}
Console.Write(" Введите количество строк массива ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write(" Введите количество столбцов массива ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int [ m, n];
FillArray(matrix, 0, 10);
PrintMatrix(matrix);
double[] columnsAverage = ColumnsAverage(matrix);
Console.WriteLine(" Среднее арифметическое столбцов: ");
PrintArray(columnsAverage);

