// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет (способ №2)
int[,] FillArray(int rows, int columns, int start, int end )
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
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
(int, int) FindMatrixIndexes(int [,] Array, int number)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i,j] == number)
               return (i,j);
        }
    }
    return(-1,-1);
}
int[,] matrix = FillArray(4, 6, 0, 10);
PrintArray(matrix);
Console.WriteLine();
Console.Write(" Введите число n: ");
int n = int.Parse(Console.ReadLine()??"0");
var result = FindMatrixIndexes(matrix, n);
if (result.Item1 == -1 && result.Item2 == -1)
    Console.WriteLine("Такого элемента нет! ");
else
    Console.WriteLine($" Число находится в массиве и имеет позицию [{result.Item1}, {result.Item2}] ");
