// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
Console.WriteLine("Введите коэффициент k1 для первого уравнения:");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент b1 для первого уравнения:");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите коэффициент k2 для второго уравнения:");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2 для второго уравнения:");
double b2 = double.Parse(Console.ReadLine());

if (k1 == k2 && b1 == b2)
    Console.WriteLine("Прямые совпадают");
else if (k1 == k2)
    Console.WriteLine("Прямые параллельны");
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения: ({x}, {y})");
}