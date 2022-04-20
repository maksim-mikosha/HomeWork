// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.Write("Введите 5-ти значное число - ");
string stringNumber = Console.ReadLine();

if (stringNumber.Length != 5)
{
    Console.WriteLine("Некорректный ввод!");
}

int index = 0;
int count = stringNumber.Length - 1;
bool result1 = chekPalindrom(stringNumber);
bool result2 = chekPalindrom(stringNumber);

bool chekPalindrom (string stringNumber)
{
    bool result;
    if (stringNumber[count] == stringNumber[index])
    {
        result = true;
    }
    else 
    {
        result = false;
    }
    count--;
    index++;
    return result;
}

if (result1 && result2)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число НЕ является палиндромом");
}