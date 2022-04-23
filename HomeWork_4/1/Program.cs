// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("В какую степень возводим первое число? Ввод - ");
int powNumber = Convert.ToInt32(Console.ReadLine());

if (powNumber >= 1)
{
    Console.WriteLine($"Число {number} в степени {powNumber} равно {Check(number, powNumber)}");
}
else
{
    Console.WriteLine("Некорректный ввод степени для числа!");
}

double Check (int number, int powNumber)
{
    double result = number;
    for (int i = 1; i < powNumber; i++)
    {
        result = result * number;
    }
    return result;
}