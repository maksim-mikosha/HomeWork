// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите массив из чисел, разделяя элементы пробелами или запятыми");
Console.Write("Ввод массива - ");
string userString = Console.ReadLine();
int[] userArray = new int[CalcArrayLength(userString)];

int CalcArrayLength(string userString)
{
    int countArrayLength = 1;
    for (int i = 0; i < userString.Length; i++)
    {
        if (userString[i].ToString() == " " || userString[i].ToString() == ",")
        {
            countArrayLength++;
        }
    }
    return countArrayLength;
}

void ParseStringToArray(string userString)
{
    int count = 0;
    
    for (int i = 0; i < userString.Length; i++)
    {
        string tempString = string.Empty;
        while (userString[i].ToString() != " " & userString[i].ToString() != ",")
        {
            tempString += userString[i];
            i++;
            if (i == userString.Length )
            {
                break;
            }
        }

            userArray[count] = Convert.ToInt32(tempString);
            count++;
    }
}

void CheckNumbers(int[] array)
{
    int countNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            countNumbers++;
        }
    }
    Console.WriteLine($"Вы ввели следуещее количество чисел больше нуля - {countNumbers}");
}

void WriteArray(int[] userArray)
{
    for (int i = 0; i < userArray.Length; i++)
    {
        Console.Write($"{userArray[i]} ");
    }
    Console.WriteLine();
}

ParseStringToArray(userString);
WriteArray(userArray);
CheckNumbers(userArray);