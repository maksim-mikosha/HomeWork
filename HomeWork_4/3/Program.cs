// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Введите массив из 8-ми чисел, разделяя элементы пробелами или запятыми");
Console.Write("Ввод массива - ");
string userString = Console.ReadLine();
int[] userArray = new int[8];

if (userString.Length < userArray.Length * 2 - 1)
{
    Console.WriteLine("Вы ввели меньше 8 чисел, что недостаточно для формирования массива");
    return;
}

ParseStringToArray(userString);
WriteArray(userArray);

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
            if (i == userString.Length)
            {
                break;
            }
        }

        if (tempString == "")
        {
            continue;
        }
        else
        {
            userArray[count] = Convert.ToInt32(tempString);
            count++;
        }

        if (count == userArray.Length) break;
    }
}

void WriteArray(int[] userArray)
{
    for (int i = 0; i < userArray.Length; i++)
    {
        Console.Write($"{userArray[i]} ");
    }
}