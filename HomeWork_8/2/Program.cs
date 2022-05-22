//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int rowArray = Input("Введите количество строк в массиве - ");
int columnsArray = Input("Введите количество столбцов в массиве - ");

int[,] arrayOfNumbers = new int[rowArray, columnsArray];

Console.WriteLine("Заполняю массив случайными числами.");
FillArray(arrayOfNumbers);
Console.WriteLine("Изначальный массив");
PrintArray(arrayOfNumbers);
SortArray(arrayOfNumbers);
Console.WriteLine("Упорядоченный массив");
PrintArray(arrayOfNumbers);

void SortArray(int[,] array)
{
    for (int i = 0; i < rowArray; i++)
    {
        for (int j = 0; j < columnsArray - 1; j++)
        {
            for (int k = j + 1; k < columnsArray; k++)
            {
                int tempNumber;
                if (arrayOfNumbers[i, j] < arrayOfNumbers[i, k])
                {
                    tempNumber = arrayOfNumbers[i, j];
                    arrayOfNumbers[i, j] = arrayOfNumbers[i, k];
                    arrayOfNumbers[i, k] = tempNumber;
                }
            }
        }
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < rowArray; i++)
    {
        for (int j = 0; j < columnsArray; j++)
        {
            arrayOfNumbers[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < rowArray; i++)
    {
        for (int j = 0; j < columnsArray; j++)
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