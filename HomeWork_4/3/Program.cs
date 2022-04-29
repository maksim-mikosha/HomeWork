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
        // string tempString = string.Empty;                                        // Не совсем рабочий блок за обработку чисел больше 1 цифры
        // while (Convert.ToString(userString[i]) != " " || Convert.ToString(userString[i]) != ",")
        // {
        //     if (i != userString.Length - 1)
        //     {
        //         tempString += userString[i];
        //         i++;
        //     }
        //     else
        //     {
        //         tempString += userString[i];
        //         continue;
        //     }
        // }
        //-------------------Второй вариант--------------- проверить
//         if (Convert.ToString(userString[i]) == " " || Convert.ToString(userString[i]) == ",")
//         {
//             continue;
//         }
        
//         string tempString = userString[i];
//         i++;                                        
//         while (Convert.ToString(userString[i]) != " " || Convert.ToString(userString[i]) != ",")
//         {
//             if (i != userString.Length - 1)
//             {
//                 tempString += userString[i];
//                 i++;
//             }
//             else
//             {
//                 tempString += userString[i];
//                 continue;
//             }
//         }
        
        if (Convert.ToString(userString[i]) == " " || Convert.ToString(userString[i]) == ",")
        {
            continue;
        }

        userArray[count] = Convert.ToInt32(userString[i].ToString());
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
