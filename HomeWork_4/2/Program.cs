// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число - ");
string numberString = Console.ReadLine();

int result = 0;

for (int i = 0; i < numberString.Length; i++)
{
    result += Convert.ToInt32(numberString[i].ToString());
}

Console.WriteLine($"Сумма цифр в числе {numberString} равна {result}");