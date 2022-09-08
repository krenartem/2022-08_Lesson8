// Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
int[,] CreateArray(int x, int y)
{
    int[,] RandomArray = new int[x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            RandomArray[i, j] = new Random().Next(-10, 11);
        }
    }
    return RandomArray;
}

int[,] SortArray(int[,] InArray)
{
    for (int i = 0; i < InArray.GetLength(0); i++)
    {
        for (int j = 0; j < InArray.GetLength(0); j++)
        {
            for (int k = 0; k < InArray.GetLength(1) - 1; k++)
            {
                if (InArray[j, k] < InArray[j, k + 1])
                {
                    int temp = InArray[j, k];
                    InArray[j, k] = InArray[j, k + 1];
                    InArray[j, k + 1] = temp;
                }

            }
        }
    }
    return InArray;
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
Console.Write("Задайте размер двумерного массива через пробел:");
string size = Console.ReadLine();
string[] numbers = size.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int x = Convert.ToInt32(numbers[0]);
int y = Convert.ToInt32(numbers[1]);
int[,] ArrayForCalculates = CreateArray(x, y);
Console.WriteLine("Создан массив:");
PrintArray(ArrayForCalculates);
int[,] SortedArray = SortArray(ArrayForCalculates);
Console.WriteLine("Массив после сортировки:");
PrintArray(SortedArray);