// Напишите программу, которая заполнит спирально массив 4 на 4.

void PrintArray(int[,] inArray, int num1)
{
    Console.Clear();
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {

            Console.SetCursorPosition(j * 4, i * 2);
            Console.Write(inArray[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] FillArrayRight(int[,] Array, int corrIndex, int numR)
{
    for (int i = corrIndex; i < Array.GetLength(0) - corrIndex; i++)
    {
        numR++;
        Array[corrIndex, i] = numR;
    }
    return Array;
}

int[,] FillArrayDown(int[,] Array, int corrIndex, int numD)
{
    for (int i = corrIndex + 1; i < Array.GetLength(0) - corrIndex; i++)
    {
        numD++;
        Array[i, Array.GetLength(0) - corrIndex - 1] = numD;
    }
    return Array;
}

int[,] FillArrayLeft(int[,] Array, int corrIndex, int numL)
{
    for (int i = Array.GetLength(0) - corrIndex - 1; i > corrIndex; i--)
    {
        numL++;
        Array[Array.GetLength(0) - corrIndex - 1, i - 1] = numL;
    }
    return Array;
}

int[,] FillArrayUp(int[,] Array, int corrIndex, int numU)
{
    for (int i = Array.GetLength(0) - corrIndex - 2; i > corrIndex; i--)
    {
        numU++;
        Array[i, corrIndex] = numU;
    }
    return Array;
}

Console.Clear();
Console.Write("Задайте размер матрицы: ");
int size = int.Parse(Console.ReadLine());
int number = 0;
int correctionIndex = 0;
int direction = 0;
int[,] Array1 = new int[size, size];
for (int i = 0; i < size * 2 + 1; i++)
{
    direction = i % 4;
    correctionIndex = i / 4;
    switch (direction)
    {
        case 0:
            Array1 = FillArrayRight(Array1, correctionIndex, number);
            break;
        case 1:
            Array1 = FillArrayDown(Array1, correctionIndex, number);
            break;
        case 2:
            Array1 = FillArrayLeft(Array1, correctionIndex, number);
            break;
        case 3:
            Array1 = FillArrayUp(Array1, correctionIndex, number);
            break;
    }
    number = number + (size * 2 - i) / 2;
}
PrintArray(Array1, number);