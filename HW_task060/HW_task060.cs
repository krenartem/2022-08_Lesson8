// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
int[,,] Create3DArray(int x, int y, int z)
{
    int[,,] RandomArray = new int[x, y, z];
    int number = 10;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                RandomArray[i, j, k] = number;
                number++;
            }
        }
    }
    return RandomArray;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write(inArray[i, j, k] + "(" + i + "," + j + "," + k + ") ");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
Console.WriteLine("Создаем массив...");
int x = new Random().Next(2, 5);
int y = new Random().Next(2, 5);
int z = new Random().Next(2, 5);
int[,,] Array1 = Create3DArray(x, y, z);
PrintArray(Array1);