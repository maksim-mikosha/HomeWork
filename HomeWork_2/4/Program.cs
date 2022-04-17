Console.WriteLine("--==Игра Угадайка!==--");
Console.WriteLine("Загадываю случайное число");

int randomNumber = new Random().Next(10, 1000);
int countTry = 1;

while (countTry <= 3)
{
    Console.Write("Угадывай! Попытка № " + countTry + " - ");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    if (userNumber == randomNumber)
    {
        Console.WriteLine("Поздравляю! Ты справился :)");
        break;
    }
    else
    {
        Check(randomNumber, userNumber);
    }
    countTry++;
}

if (countTry > 3)
{
    Console.WriteLine("Попытки закончились. Удачи в следующий раз.");
    Console.WriteLine("Загаданное число - " + randomNumber);
}

void Check(int numberA, int numberB)
{
    if (numberA > numberB)
    {
        Console.WriteLine("Загаданное число больше");
    }
    else
    {
        Console.WriteLine("Загаданное число меньше");
    }
}