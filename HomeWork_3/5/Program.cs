// Дополнительное задание
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого 

Console.Write("Введите первое число - ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число - ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (Check(numberA, numberB))
{
    Console.WriteLine("Одно из чисел является квадратом другого!");
}
else
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого!");
}

bool Check (int numberA, int numberB)
{
    double sqrNumberA = Math.Pow(numberA, 2);
    double sqrNumberB = Math.Pow(numberB, 2);
    bool result = false;
    if (sqrNumberA == numberB || sqrNumberB == numberA)
    {
        result = true;
    }
    return result;
}