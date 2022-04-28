// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Введите длину массива - ");
int length = Convert.ToInt32(Console.ReadLine());
double[] arrayNumbers = GetArray(length);
double result = MaxNumber(arrayNumbers) - MinNumber(arrayNumbers);

Console.Write("Случайно сгенерированный массив : ");
WriteArray(arrayNumbers);
Console.Write($"Разница между максимальным и минимальным элементов массива : {result}");

double MaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double MinNumber(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

double[] GetArray(int length)
{
    double[] newArray = new double[length];
    FillArray(newArray);
    return newArray;
}

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();
    }
}

void WriteArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}