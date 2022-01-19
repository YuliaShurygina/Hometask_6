// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
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
bool SomeNumber(int[,] Array, int number)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i,j] == number)
                return true;
        }
    }
    return false;
}           
void PrintIndexes(int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             if (array[i,j] == number)
                 Console.WriteLine($"[{i} , {j}] ");
         }
    }
}
int[,] matrix = FillArray(4, 6, 0, 10);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine(" Введите число n: ");
int n = int.Parse(Console.ReadLine()??"0");
bool contain = SomeNumber(matrix, n);
if (contain == true)
    {
        Console.WriteLine($"Позиции заданного числа в массиве: ");
        PrintIndexes(matrix, n);
    }
else
    Console.WriteLine($"Такого элемента нет! ");

