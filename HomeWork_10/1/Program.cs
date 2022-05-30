// //Задача 73: Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, 
// так чтобы в одной группе все числа были взаимно просты (все числа в группе друг на друга не делятся)? 
// Найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰. Можно использовать рекурсию.

int inputNumber = Input("Введите число N - ");

int amountRow = 0;
CountGroup(inputNumber);
int[,] arrayOfNumbers = new int[amountRow, inputNumber];

FillArray(arrayOfNumbers);
PrintArray(arrayOfNumbers);

void FillArray(int[,] array)
{
    array[0, 0] = 1;
    int value = 2;
    for (int k = value; k < inputNumber; value++)
    {
        int i = 1;
        int j = 0;
        if (CheckValue(array, value))
        {
            array[i, j] = value;
            break;
        }
    }
}

bool CheckValue(int[,] array, int value)
{
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); i++)
        {
            if (array[i, j] % value == 0)
            {
                if (value % array[i, j] == 0)
                {
                    return false;
                }
            }
        }
    }
    return true;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"Группа {i + 1} : ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] != 0)
            {
                Console.Write($"{array[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}

int CountGroup(int inputNumber)
{
    if (inputNumber < 1)
    {
        return amountRow;
    }
    else
    {
        inputNumber = inputNumber / 2;
        amountRow++;
        return CountGroup(inputNumber);
    }
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}