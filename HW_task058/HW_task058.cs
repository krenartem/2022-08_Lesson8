// Задайте две матрицы.
// Напишите программу,
// которая будет находить произведение двух матриц.
int[,] CreateMatrix(int x, int y)
{
    int[,] RandomArray = new int[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            RandomArray[i, j] = new Random().Next(1, 10);
        }
    }
    return RandomArray;
}

int[,] MatrixMultiplication(int[,] Matrix1, int[,] Matrix2)
{
    int[,] MatrixMultipleResult = new int[Matrix1.GetLength(0), Matrix2.GetLength(1)];
    int tempresult = 0;
    for (int i = 0; i < Matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < Matrix2.GetLength(0); k++)
            {
                tempresult = tempresult + Matrix1[i, k] * Matrix2[k, j];
            }
            MatrixMultipleResult[i, j] = tempresult;
            tempresult = 0;
        }
    }
    return MatrixMultipleResult;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Создаем 2 матрицы...");
int x = new Random().Next(1, 11);
int y = new Random().Next(1, 11);
int z = new Random().Next(1, 11);
int[,] Array1 = CreateMatrix(x, y);
Console.WriteLine("Матрица 1:");
PrintArray(Array1);
int[,] Array2 = CreateMatrix(y, z);
Console.WriteLine("Матрица 2:");
PrintArray(Array2);
int[,] MultipleMatrix = MatrixMultiplication(Array1, Array2);
Console.WriteLine("Произведение матриц:");
PrintArray(MultipleMatrix);