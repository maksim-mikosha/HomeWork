// Дополнительное задание
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 

Console.Write("Введите число для проверки - ");
int number = Convert.ToInt32(Console.ReadLine());

if (Check(number))
{
    Console.WriteLine("Число одновременно кратно 7 и 23!");
}
else
{
    Console.WriteLine("Число не кратно 7 и 23!");
}

bool Check (int number)
{
    int modNumber7 = number % 7;
    int modNumber23 = number % 23;
    bool result = false;
    if (modNumber7 == 0 & modNumber23 == 0)
    {
        result = true;
    }
    return result;
}

// Более ситуативный вариант, когда пользователь сам выбирает на какие числа проводить проверку кратности.

// Console.Write("Введите число для проверки - ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите первое число для проверки кратности - ");
// int numberForCheckA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число для проверки кратности - ");
// int numberForCheckB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Проверяем кратно ли число {number} одновременно {numberForCheckA} и {numberForCheckB}");

// if (Check(number, numberForCheckA, numberForCheckB))
// {
//     Console.WriteLine($"Число одновременно кратно {numberForCheckA} и {numberForCheckB}!");
// }
// else
// {
//     Console.WriteLine($"Число не кратно {numberForCheckA} и {numberForCheckB}!");
// }

// bool Check (int number, int numberForCheckA, int numberForCheckB)
// {
//     int modNumberA = number % numberForCheckA;
//     int modNumberB = number % numberForCheckB;
//     bool result = false;
//     if (modNumberA == 0 & modNumberB == 0)
//     {
//         result = true;
//     }
//     return result;
// }