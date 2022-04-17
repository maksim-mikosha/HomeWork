Console.Write("Введите первое число - ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число - ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число - ");
int numberC = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ваши числа - " + numberA + " " + numberB + " " + numberC);

int maxNumber = numberA;

if (numberA == numberB && numberA == numberC && numberB == numberC)
{
    Console.WriteLine("Введенные числа равны!");
}
else
{
    if (maxNumber < numberB)
    {
        maxNumber = numberB;
    }
    
    if (maxNumber < numberC)
    {
        maxNumber = numberC;
    }
   
    Console.WriteLine("Наибольшее число " + maxNumber);
}