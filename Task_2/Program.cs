/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.
*/ 

int ReadDim(string str)
{
    Console.WriteLine(str);

    return int.Parse(Console.ReadLine());
}

int[,] InitArray(int firstDim, int secondDim)
{
    int[,] array = new int[firstDim, secondDim];
    Random random = new Random();

    for (int i = 0; i < firstDim; i++)
    {
        for (int j = 0; j < secondDim; j++)
        {
            array[i, j] = random.Next(0, 100);
        }
    }

    return array;
}

int IndexOfMinSum(int[,] array)
{
    int index = -1;
    int minSum = int.MaxValue;

    for (int i = 0; i < array.GetLength(0);i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }

        if (sum < minSum)
        {
            minSum = sum;
            index = i;
        }
    }

    return index;
}

void PrintArray(int[,] array)
{
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }

        Console.WriteLine();
    }
}

int firstDim = ReadDim("Введите размерность 1: ");
int[,] array = InitArray(firstDim, firstDim);

PrintArray(array);

int index = IndexOfMinSum(array);

Console.WriteLine($"Индекс строки: {index}");