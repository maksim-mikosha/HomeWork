// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int numberOne = Input("Введите число M - ");
int numberTwo = Input("Введите число N - ");

Console.WriteLine($"Функция Аккермана при значениях A({numberOne}, {numberTwo}) равна {Function(numberOne, numberTwo)}");

int Function(int numberOne, int numberTwo)
{
    if (numberOne == 0)
        return numberTwo + 1;
    else if ((numberOne != 0) && (numberTwo == 0))
        return Function(numberOne - 1, 1);
    else
        return Function(numberOne - 1, Function(numberOne, numberTwo - 1));
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}