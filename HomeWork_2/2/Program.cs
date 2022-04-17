Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());               //Ввод данных так потому что string не допускает значение NULL, VS Code проинформировал
string stringNumber = Convert.ToString(number);

Console.WriteLine("Ваше число - " + stringNumber);

if (stringNumber.Length <= 2)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
    Console.WriteLine("Третья цифра - " + stringNumber[2]);
}