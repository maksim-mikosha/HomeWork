//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int xA = EnterValue("x", "A");
int yA = EnterValue("y", "A");
int zA = EnterValue("z", "A");
int xB = EnterValue("x", "B");
int yB = EnterValue("y", "B");
int zB = EnterValue("z", "B");

int EnterValue(string positionName, string pointName)
{
    Console.Write($"Введите координату {positionName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

Console.WriteLine($"Введенные координаты  А ({xA} , {yA} , {zA}) и B ({xB} , {yB}, {zB})");

int diffX = xB - xA;
int diffY = yB - yA;
int diffZ = zB - zA;
double result = Math.Sqrt(Math.Pow(diffX,2) + Math.Pow(diffY,2) + Math.Pow(diffZ,2));

Console.WriteLine($"Расстояние между точками равно - {result}");