//Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int rowArray = Input("Введите количество строк в массиве - ");
int columnsArray = Input("Введите количество столбцов в массиве - ");

int[,] arrayOfNumbers = new int[rowArray, columnsArray];
int rowLocationMinimum = 0;
int columnLocationMinimum = 0;
int[,] arrayWithoutMinimum = new int[rowArray - 1, columnsArray - 1];

Console.WriteLine("Заполняю массив случайными числами.");
FillArray(arrayOfNumbers);
Console.WriteLine("Заполненный массив");
PrintArray(arrayOfNumbers, rowArray, columnsArray);
SearchMinimum(arrayOfNumbers);

Console.WriteLine($"Координаты наименьшего значения массива - [{rowLocationMinimum}, {columnLocationMinimum}]");

for (int i = 0; i < rowArray; i++)
{
    if (i == rowLocationMinimum) continue;
    if (i > rowLocationMinimum)
    {
        for (int j = 0; j < columnsArray; j++)
        {
            if (j == columnLocationMinimum) continue;
            if (j > columnLocationMinimum)
            {
                arrayWithoutMinimum[i - 1, j - 1] = arrayOfNumbers[i, j];
            }
            else
            {
                arrayWithoutMinimum[i - 1, j] = arrayOfNumbers[i, j];
            }
        }
    }
    else
    {
        for (int j = 0; j < columnsArray; j++)
        {
            if (j == columnLocationMinimum) continue;
            if (j > columnLocationMinimum)
            {
                arrayWithoutMinimum[i, j - 1] = arrayOfNumbers[i, j];
            }
            else
            {
                arrayWithoutMinimum[i, j] = arrayOfNumbers[i, j];
            }
        }
    }

}

Console.WriteLine("Новый массив");
PrintArray(arrayWithoutMinimum, rowArray - 1, columnsArray - 1);

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
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

void PrintArray(int[,] array, int rowArray, int columnsArray)
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

void SearchMinimum(int[,] array)
{
    int mimimumFromArray = arrayOfNumbers[0, 0];
    for (int i = 0; i < rowArray; i++)
    {
        for (int j = 0; j < columnsArray; j++)
        {
            if (arrayOfNumbers[i, j] < mimimumFromArray)
            {
                mimimumFromArray = arrayOfNumbers[i, j];
                rowLocationMinimum = i;
                columnLocationMinimum = j;
            }
        }
    }
}