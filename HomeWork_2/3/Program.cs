Console.Write("Введите цифру - ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7 || number <= 0 )
{
    Console.WriteLine("Ввод недопустимого значения!");
}
else
{
    if (number >= 6)
    {
        Console.WriteLine("День является выходным!");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}