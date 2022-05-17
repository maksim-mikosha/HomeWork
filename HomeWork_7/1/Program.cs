//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int rowArray = Input("Введите количество строк в массиве - ");
int columnsArray = Input("Введите количество столбцов в массиве - ");

double[,] arrayOfDouble = new double[rowArray, columnsArray];

FillArray(arrayOfDouble);
PrintArray(arrayOfDouble);

void FillArray(double[,] array)
{
    for (int i = 0; i < rowArray; i++)
    {
        for (int j = 0; j < columnsArray; j++)
        {
            arrayOfDouble[i, j] = Math.Round(NewRandomDouble(-10.0, 10.0), 1);
        }
    }
}

void PrintArray(double[,] array)
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

double NewRandomDouble(double minimum, double maximum)
{
    Random random = new Random();
    return random.NextDouble() * (maximum - minimum) + minimum;
}

int Input(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}