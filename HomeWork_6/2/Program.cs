// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double ImputValue (string numberName)
{
    Console.Write($"Введите число {numberName}: ");
    return Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Введите необходимые числа для расчета");
double k1 = ImputValue("k1");
double b1 = ImputValue("b1");
double k2 = ImputValue("k2");
double b2 = ImputValue("b2");
double x = (b2 - b1) / (k1 - k2);
double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;

Console.WriteLine($"Точка пересечения двух прямых - ({x}; {y})");