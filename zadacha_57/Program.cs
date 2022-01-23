// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
void FillArray(int[,] array, int start, int end)
{

    for (int i = 0; i < array.GetLength(0); i++)

        for (int j = 0; j < array.GetLength(1); j++)

            array[i, j] = new Random().Next(start, end);

}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void OrderingRows(int[,] someMatrix)
{
    for (int i = 0; i < someMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < someMatrix.GetLength(1); j++)
        {
            for (int k = 1; k < someMatrix.GetLength(1); k++)
            {
                if (someMatrix[i, k] > someMatrix[i,k-1])
                {
                    int number = someMatrix[i, k];
                    someMatrix[i, k] = someMatrix[i, k-1];
                    someMatrix[i, k-1] = number;
                }
            }
        }
    }
}

int[,] matrix = new int[4, 5];
FillArray(matrix, 1, 10);
PrintArray(matrix);
Console.WriteLine();
OrderingRows(matrix);
PrintArray(matrix);