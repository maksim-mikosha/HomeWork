//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int rowArray = Input("Введите количество строк в массиве - ");
int columnsArray = Input("Введите количество столбцов в массиве - ");
double averageNumbersColumn;

int[,] arrayOfNumbers = new int[rowArray, columnsArray];

Console.WriteLine("Заполняю массив случайными числами.");
FillArray(arrayOfNumbers);
Console.WriteLine("Заполненный массив");
PrintArray(arrayOfNumbers);

Console.Write("Среднее арифметическое каждого столбца: ");
for (int i = 0; i < columnsArray; i++)
{
    averageNumbersColumn = 0;
    for (int j = 0; j < rowArray; j++)
    {
        averageNumbersColumn += arrayOfNumbers[j, i];
    }
    averageNumbersColumn = Math.Round(averageNumbersColumn / rowArray, 1);
    Console.Write(averageNumbersColumn + " ");
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