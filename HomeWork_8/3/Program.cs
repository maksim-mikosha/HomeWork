//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int rowArray = Input("Введите количество строк в массиве - ");
int columnsArray = Input("Введите количество столбцов в массиве - ");

int[,] arrayOfNumbers = new int[rowArray, columnsArray];

Console.WriteLine("Заполняю массив случайными числами.");
FillArray(arrayOfNumbers);
Console.WriteLine("Изначальный массив");
PrintArray(arrayOfNumbers);

int minimumIndexRow = CalculationIndexRows(arrayOfNumbers);

Console.WriteLine("Строка с наименьшей суммой элементов");
for (int i = 0; i < columnsArray; i++)
{
    Console.Write(arrayOfNumbers[minimumIndexRow, i] + " ");
}

int CalculationIndexRows(int[,] array)
{
    int[] arraySummaryNumbersRow = new int[rowArray];
    for (int i = 0; i < rowArray; i++)
    {
        for (int j = 0; j < columnsArray; j++)
        {
            arraySummaryNumbersRow[i] += arrayOfNumbers[i, j];
        }
    }

    int minimumValue = arraySummaryNumbersRow[0];
    int minimumIndex = 0;
    for (int i = 1; i < arraySummaryNumbersRow.Length; i++)
    {
        if (minimumValue > arraySummaryNumbersRow[i])
        {
            minimumValue = arraySummaryNumbersRow[i];
            minimumIndex = i;
        }
    }
    return minimumIndex;
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