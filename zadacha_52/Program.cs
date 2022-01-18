// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
int[,] FillArray(int rows, int columns, int start, int end)
{
    Random random = new Random();
    int[,] newMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newMatrix[i,j] = random.Next(start, end);
        }
    }
    return newMatrix;
}
void PrintArray(int [,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($" {Array[i,j]} ");
        }
        Console.WriteLine();
    }
}
int[,] ChangeElement(int[,] array)
{
    int[,] someMatrix = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
          if (i % 2 == 0 && j % 2 == 0)
              someMatrix[i,j] = array[i,j] * array[i,j];
          else 
              someMatrix[i,j] = array[i,j];
        }
    }
    return someMatrix;
}
int[,] matrix = FillArray(4, 6, -10, 10);
PrintArray(matrix);
int[,] changedMatrix = ChangeElement(matrix);
Console.WriteLine();
PrintArray(changedMatrix);