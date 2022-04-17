Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ваше число - " + number);

int divNumbers10 = number % 10;

Console.WriteLine("Последняя цифра - " + divNumbers10);