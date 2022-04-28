//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Введите длину массива - ");
int length = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = GetArray(length);
int result = SumNumbers(arrayNumbers);

Console.Write("Случайно сгенерированный массив : ");
WriteArray(arrayNumbers);
Console.Write($"Сумма элементов, стоящих на нечётных позициях : {result}");

int SumNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        sum += array[i];
        i++;
    }
    return sum;
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
        array[i] = new Random().Next(-20, 21);
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