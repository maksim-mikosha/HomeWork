//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int firstRowArray = Input("Введите количество строк в массиве 1 - ");
int firstColumnsArray = Input("Введите количество столбцов в массиве 1 - ");
int[,] firstArray = new int[firstRowArray, firstColumnsArray];

int secondRowArray = Input("Введите количество строк в массиве 2 - ");
int secondColumnsArray = Input("Введите количество столбцов в массиве 2 - ");
int[,] secondArray = new int[secondRowArray, secondColumnsArray];

Console.WriteLine("Выполняю проверку на возможность произведения матриц");
if (firstColumnsArray == secondRowArray)
{
    Console.WriteLine("Произведение матриц возможно. Заполняю массивы случайными числами");
    FillArray(firstArray);
    FillArray(secondArray);

    Console.WriteLine("Изначальные массивы");
    PrintArray(firstArray);
    Console.WriteLine();
    PrintArray(secondArray);

    int[,] multiplicationArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    Multiplications(firstArray, secondArray, multiplicationArray);

    Console.WriteLine("Результат перемножения");
    PrintArray(multiplicationArray);
}
else
{
    Console.WriteLine("Произведение матриц невозможно!");
}

void Multiplications(int[,] firstArray, int[,] secondArray, int[,] multiplicationArray)
{
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < secondArray.GetLength(0); k++)
            {
                multiplicationArray[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}