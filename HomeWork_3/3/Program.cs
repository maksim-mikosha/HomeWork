// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N - ");
int number = Convert.ToInt32(Console.ReadLine());

int index = 1;

if (number <= 0)
{
    number = -number;
}

while (number >= index)
{
    double result = Square(index);
    Console.Write(result + " ");
    index ++;
}

double Square(int number)
{
    return Math.Pow(number, 3);
    // return number*number*number;       //Второй способ, но первый выглядит симпатичнее и не так топорно
}