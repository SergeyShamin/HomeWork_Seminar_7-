/* Сформируйте трехмерный массив из неповторяющихся двузначных чисел.
Напишие программу, которая будет построчно выводить массив, добавляя индексы
каждого элемента.
*/ 

int ReadDim(string str)
{
    Console.WriteLine(str);

    return int.Parse(Console.ReadLine());
}

int[,,] InitArray(int firstDim, int secondDim, int thirdDim)
{
    int[,,] array = new int[firstDim, secondDim, thirdDim];
    Random random = new Random();

    for (int i = 0; i < firstDim; i++)
    {
        for (int j = 0; j < secondDim; j++)
        {
            for (int k = 0; k < thirdDim; k++)
            {
                array[i, j, k] = random.Next(100, 1000);
            }
        }
    }

    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]} {i} {j} {k}");
            }
        }
    }
}

int firstDim = ReadDim("Введите размерность 1 матрицы A: ");
int secondDim = ReadDim("Введите размерность 2 матрицы A: ");
int thirdDim = ReadDim("Введите размерность 3 матрицы A: ");

int[,,] array1 = InitArray(firstDim, secondDim, thirdDim);

PrintArray(array1);