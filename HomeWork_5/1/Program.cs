// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Введите длину массива - ");
int length = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = GetArray(length);
int countEvenNumbers = CheckEvenNumbers(arrayNumbers);

Console.Write("Случайно сгенерированный массив -");
WriteArray(arrayNumbers);
Console.Write($"Количество четных чисел в массиве - {countEvenNumbers}");

int CheckEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] GetArray(int length)
{
    int[] newArray = new int[length];
    FillArray(newArray);
    return newArray;
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}