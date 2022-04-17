Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ваше число - " + number);

void Result(int num)
{
    int divNumbers100 = num / 100;
    int divNumbers10 = num % 10;
    int secondNumber = (num - divNumbers100 * 100 - divNumbers10) / 10;
   
    Console.WriteLine("Вторая цифра - " + secondNumber);
   
}

Result(number);