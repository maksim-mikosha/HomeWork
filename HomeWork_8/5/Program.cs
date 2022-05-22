//Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int listArray = Input("Введите количество слоев/листов в массиве - ");
int rowArray = Input("Введите количество строк в массиве - ");
int columnsArray = Input("Введите количество столбцов в массиве - ");
int sizeArray = listArray * rowArray * columnsArray;
int maxNumbers = 90;        //максимальное количество двузначных чисел
bool checkValue;

int[,,] arrayOfNumbers = new int[listArray, rowArray, columnsArray];

if (sizeArray > maxNumbers)
{
    Console.WriteLine("Заполнение массива неповторяющимися числами не возможно!");
    return;
}

Console.WriteLine("Заполняю массив случайными числами.");

FillArray(arrayOfNumbers);
PrintArray(arrayOfNumbers);

void FillArray(int[,,] array)
{
    int tempValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                for (int h = 1; h <= maxNumbers; h++)
                {
                    checkValue = true;
                    tempValue = new Random().Next(10, 100);
                    CheckForUnique(arrayOfNumbers, tempValue);
                    if (checkValue)
                    {
                        array[i, j, k] = tempValue;
                        break;
                    }
                }
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"[{i}, {j}, {k}] - {array[i, j, k]}");
            }
        }
        Console.WriteLine();
    }
}

bool CheckForUnique(int[,,] array, int value)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (value == array[i, j, k])
                {
                    checkValue = false;
                    return checkValue;
                }
            }
        }
    }
    return checkValue;
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}