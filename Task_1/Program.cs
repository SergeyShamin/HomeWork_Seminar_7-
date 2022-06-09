/* Задайте двумерный массив. Напишите программу, которая упордочит по убыванию 
элементы каждой строки увумерного массива.
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

void SortLine(int[,] array, int lineNumber)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int k = j + 1; k < array.GetLength(1); k++)
        {
            if (array[lineNumber, j] < array[lineNumber, k])
            {
                int n = array[lineNumber, j];

                array[lineNumber, j] = array[lineNumber, k];
                array[lineNumber, k] = n;
            }
        }
    }
}

void SortAllLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        SortLine(array, i);
    }
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
int secondDim = ReadDim("Введите размерность 2: ");
int[,] array = InitArray(firstDim, secondDim);

PrintArray(array);

SortAllLines(array);

PrintArray(array);