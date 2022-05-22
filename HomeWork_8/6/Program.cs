// Задача 62: Заполните спирально массив 4 на 4
int rowArray = 4;
int columnsArray = 4;

int[,] arrayOfNumbers = new int[rowArray, columnsArray];

FillArray(arrayOfNumbers);
PrintArray(arrayOfNumbers);

void FillArray(int[,] array)
{
    int countNumber = 1;
    int i = 0;
    int j = 0;

    while (countNumber <= arrayOfNumbers.GetLength(0) * arrayOfNumbers.GetLength(1))
    {
        array[i, j] = countNumber;
        countNumber++;
        if (i <= j + 1 && i + j < arrayOfNumbers.GetLength(0) - 1)
            j++;
        else if (i < j && i + j >= arrayOfNumbers.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > arrayOfNumbers.GetLength(0) - 1)
            j--;
        else
            i--;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < rowArray; i++)
    {
        for (int j = 0; j < columnsArray; j++)
        {
            if (array[i, j] <= 9)
            {
                Console.Write(array[i, j] + "  ");
            }
            else
            {
                Console.Write(array[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}