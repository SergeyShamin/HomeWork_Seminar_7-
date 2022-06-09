/* Задайте две матрицы.Напишите программу, которая будет находить произведение
двух матриц.
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

int[,] Multiply(int[,] array1, int[,] array2)
{
    int n = array1.GetLength(0);
    int m = array2.GetLength(1);
    int t = array1.GetLength(1);

    int[,] result = new int[n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            int sum = 0;

            

            for (int k = 0; k < t; k++)
            {
                sum += array1[i, k] * array2[k, j];
            }

            result[i, j] = sum;
        }
    }

    return result;
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

int firstDimA = ReadDim("Введите размерность 1 матрицы A: ");
int secondDimA = ReadDim("Введите размерность 2 матрицы A: ");
int firstDimB = ReadDim("Введите размерность 1 матрицы B: ");
int secondDimB = ReadDim("Введите размерность 2 матрицы B: ");

int[,] array1 = InitArray(firstDimA, secondDimA);
int[,] array2 = InitArray(firstDimB, secondDimB);

PrintArray(array1);
PrintArray(array2);

if (array1.GetLength(1) != array2.GetLength(0))
{
    Console.WriteLine("Матрицы не согласованны");
    return;
}

int[,] result = Multiply(array1, array2);

PrintArray(result);