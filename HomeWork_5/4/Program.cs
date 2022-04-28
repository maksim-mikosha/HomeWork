//Доп.задание - В переменной string есть секретное сообщение, во второй есть пароль. Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.

Console.WriteLine("Введи пароль!");

string secretString = "password";
int countTry = 1;

while (countTry <= 3)
{
    Console.Write("Угадывай! Попытка № " + countTry + " - ");
    string userString = Console.ReadLine();
    if (userString == secretString)
    {
        Console.WriteLine("Поздравляю! Ты справился :)");
        break;
    }
    else
    {
        Console.WriteLine("Попробуй еще.");
    }
    countTry++;
}

if (countTry > 3)
{
    Console.WriteLine("Попытки закончились. Удачи в следующий раз.");
    Console.WriteLine("Пароль - " + secretString);
}