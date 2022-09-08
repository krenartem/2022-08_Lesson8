// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
int[,] CreateArray(int x, int y)
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

int[] SummarizeRows(int[,] InArray)
{
    int[] SumRowsArray = new int[InArray.GetLength(0)];
    int sum = 0;
    for (int j = 0; j < InArray.GetLength(0); j++)
    {
        for (int k = 0; k < InArray.GetLength(1); k++)
        {
            sum = sum + InArray[j, k];
        }
        SumRowsArray[j] = sum;
        sum = 0;
    }
    Console.WriteLine("Сумма значений в строках " + String.Join(" ", SumRowsArray));
    return SumRowsArray;
}

void FindMin(int[] InArray)
{
    int min = InArray[0];
    int minIndex = 0;
    for (int i = 1; i < InArray.Length; i++)
    {
        if (InArray[i] < min)
        {
            min = InArray[i];
            minIndex = i;
        }
    }
    Console.WriteLine($"Наименьшая суммой элементов: индекс строки {minIndex}, номер строки {minIndex + 1}");
    Console.WriteLine($"Сумма элементов в строке: {min}");
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
int[] SumOfRows = SummarizeRows(ArrayForCalculates);
FindMin(SumOfRows);