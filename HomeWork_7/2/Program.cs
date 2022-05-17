//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int rowArray = Input("Введите количество строк в массиве - ");
int columnsArray = Input("Введите количество столбцов в массиве - ");

int[,] arrayOfNumbers = new int[rowArray, columnsArray];

Console.WriteLine("Заполняю массив случайными числами.");
FillArray(arrayOfNumbers);
int searchOfNumber = Input("Введите число для поиска - ");
bool resultOfSearch = false;

for (int i = 0; i < rowArray; i++)
{
    for (int j = 0; j < columnsArray; j++)
    {
        if (arrayOfNumbers[i,j] == searchOfNumber)
        {
            Console.WriteLine($"Число {searchOfNumber} есть в массиве на позиции [{i}, {j}]");
            resultOfSearch = true;
            break;
        }
    }
}

if (!resultOfSearch)
{
    Console.WriteLine($"Число {searchOfNumber} отсутствует в массиве");
}  

Console.WriteLine("Заполненный массив");
PrintArray(arrayOfNumbers);

void FillArray(int[,] array)
{
    for (int i = 0; i < rowArray; i++)
    {
        for (int j = 0; j < columnsArray; j++)
        {
            arrayOfNumbers[i, j] = new Random().Next(0, 11);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < rowArray; i++)
    {
        for (int j = 0; j < columnsArray; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}