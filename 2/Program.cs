Console.Write("Введите первое число - ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число - ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ваши числа - " + numberA + " " + numberB);

int maxNumber = numberA;

if (numberA == numberB)
{
    Console.WriteLine("Введенные числа равны!");
}
else
{
    if (maxNumber < numberB)
    {
        maxNumber = numberB;
    }
    Console.WriteLine("Наибольшее число " + maxNumber);
}