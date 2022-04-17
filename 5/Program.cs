Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ваше число - " + number);

int index = 2;

if (number < index)
{
    Console.WriteLine("Отсутствуют четные числа или введено отрицательное число!");
}
else
{
    Console.Write("Четные числа от 1 до " + number + " - ");
    while (number >= index)
    {
        Console.Write(index + " ");
        index += 2;
    }
}