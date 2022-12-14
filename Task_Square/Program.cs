// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) 
// требуется вычислить его площадь

void InputCoordinates(int[] coord)
{
    Console.WriteLine("Введите координаты вершин треугольника (x1,y1), (x2,y2) и (x3,y3)");
    for (int i = 0; i < coord.Length; i++)
        coord[i] =int.Parse(Console.ReadLine());
}

Console.Clear();
int n = 6; // количество координат
int[] coordinates = new int [n];
InputCoordinates(coordinates);
Console.WriteLine($"[{string.Join(", ", coordinates)}]");

// решение через определитель второго порядка
double square = Math.Abs((coordinates[0] - coordinates[4]) * (coordinates[3] - coordinates[5]) 
                - (coordinates[2] - coordinates[4]) * (coordinates[1] - coordinates[5])) / 2;
Console.WriteLine($"Площадь треугольника: {square}");
