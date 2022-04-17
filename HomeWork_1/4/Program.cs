Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ваше число - " + number);

int divNumber = number % 2;

if (divNumber == 1)
{
    Console.WriteLine("Введенное число не чётное!");
}
else
{
    Console.WriteLine("Введенное число чётное!");
}