// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Введите массив из 8-ми чисел, разделяя элементы пробелами или запятыми");
Console.Write("Ввод массива - ");
string userString = Console.ReadLine();
int[] userArray = new int[8];

if (userString.Length < 15)
{
    Console.WriteLine("Некорректный ввод элементов массива!");
    return;
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

void WriteArray(int[] userArray)
{
    for (int i = 0; i < userArray.Length; i++)
    {
        Console.Write($"{userArray[i]} ");
    }
}

ParseStringToArray(userString);
WriteArray(userArray);
