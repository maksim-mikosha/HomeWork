// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
int number = Input("Введите число - ");
int count = 1;

OutputResult(number, count);

void OutputResult(int number, int count)
{
    if (number >= count)
    {
        Console.Write(number + " ");
        number--;
        OutputResult(number, count);
    }
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}