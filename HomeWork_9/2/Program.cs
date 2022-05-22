// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int numberOne = Input("Введите число M - ");
int numberTwo = Input("Введите число N - ");
int summary = 0;

if (numberOne < numberTwo)
{
    summary = SummaryNumbers(numberOne, numberTwo);
    Console.WriteLine($"Сумма чисел в промежутке от {numberOne} до {numberTwo} равна {summary}");
}
else
{
    summary = SummaryNumbers(numberTwo, numberOne);
    Console.WriteLine($"Сумма чисел в промежутке от {numberTwo} до {numberOne} равна {summary}");
}

int SummaryNumbers(int numberOne, int numberTwo)
{
    summary += numberOne;
    if (numberOne == numberTwo) return summary;
    return SummaryNumbers(++numberOne, numberTwo);
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}