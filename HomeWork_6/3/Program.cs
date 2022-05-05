//  Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается
//  Продолжаем прокачивать приложение с командами. Добавить к программе, которая заканчивается, когда пишем exit еще 4 команды (их можно придумать самому).

int count = 1;
long countMax = Int32.MaxValue;
string secret = string.Empty;
string password = "password";

Console.WriteLine("Приветствую! Вот что я могу:");
Console.WriteLine("1. Оставить секретное сообщение - SetSecret");
Console.WriteLine("2. Установить пароль - SetPassword");
Console.WriteLine("3. Вывод секретного сообщения - Secret");
Console.WriteLine("4. Помощь - Help");
Console.WriteLine("5. Выход - Exit");
Console.WriteLine("Регистр вводимой комманды не имеет значения");

while (count != countMax)
{
    Console.WriteLine("Чем могу помочь?");
    Console.Write("Ввод команды - ");
    string userCommand = Console.ReadLine().ToLower();
    Console.WriteLine();
    count++;

    if (userCommand == "exit")
    {
        break;
    }
    else if (userCommand == "help")
    {
        Console.WriteLine("Список доступных комманд:");
        Console.WriteLine("1. Оставить секретное сообщение - SetSecret");
        Console.WriteLine("2. Установить пароль - SetPassword");
        Console.WriteLine("3. Вывод секретного сообщения - Secret");
        Console.WriteLine("4. Помощь - Help");
        Console.WriteLine("5. Выход - Exit");
        Console.WriteLine("Регистр вводимой комманды не имеет значения");
        Console.WriteLine();
    }
    else if (userCommand == "setsecret")
    {
        while (count != countMax)
        {
            Console.WriteLine("Для смены сообщения введите пароль");
            Console.WriteLine("Для возврата введите - Return");
            Console.Write("Введите команду или пароль - ");
            userCommand = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (userCommand == password)
            {
                Console.Write("Верный пароль. Введите новое секретное сообщение - ");
                secret = Console.ReadLine();
                Console.WriteLine("Секретное сообщение изменено!");
                Console.WriteLine();
                break;
            }
            else if (userCommand == "return")
            {
                break;
            }
            else
            {
                Console.WriteLine("Доступ запрещен! Повторите ввод или вернитесь назад");
                Console.WriteLine();
                continue;
            }
        }
    }
    else if (userCommand == "setpassword")
    {
        while (count != countMax)
        {
            Console.WriteLine("Введите предыдущий пароль");
            Console.WriteLine("Для возврата введите - Return");
            Console.Write("Введите команду или пароль - ");
            userCommand = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (userCommand == password)
            {
                Console.Write("Верный пароль. Введите новый пароль - ");
                password = Console.ReadLine();
                if (password == "")
                {
                    Console.WriteLine("Пароль не может быть пустым!");
                    Console.WriteLine("Пароль сброшен до состояния default.");
                    password = "password";
                }
                else
                {
                    Console.WriteLine("Пароль изменён!");
                    Console.WriteLine();
                }
                break;
            }
            else if (userCommand == "return")
            {
                break;
            }
            else
            {
                Console.WriteLine("Доступ запрещен! Повторите ввод или вернитесь назад");
                Console.WriteLine();
                continue;
            }
        }
    }
    else if (userCommand == "secret")
    {
        while (count != countMax)
        {
            Console.WriteLine("Для просмотра сообщения введите пароль");
            Console.WriteLine("Для возврата введите - Return");
            Console.Write("Введите команду или пароль  - ");
            userCommand = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (userCommand == password)
            {
                if (secret == "")
                {
                    Console.WriteLine("Упс. Здесь пока еще пусто.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Верный пароль. Секретное сообщение - {secret}");
                    Console.WriteLine();
                }
                break;
            }
            else if (userCommand == "return")
            {
                break;
            }
            else
            {
                Console.WriteLine("Доступ запрещен! Повторите ввод или вернитесь назад");
                Console.WriteLine();
                continue;
            }
        }
    }
    else
    {
        Console.WriteLine("Команда не распознана.");
        Console.WriteLine("Для помощи по командам введи - help");
        Console.WriteLine();
        continue;
    }
}

Console.WriteLine("До встречи!");