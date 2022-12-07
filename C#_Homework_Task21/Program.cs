// на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Console.WriteLine("Введите координаты x первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты x первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты x второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты z второй точки");
int z2 = Convert.ToInt32(Console.ReadLine());

double SegmentLength(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int X = x2 - x1;
    int Y = y2 - y1;
    int Z = z2 - z1;
    double result = 0;
    result = Math.Sqrt((X * X) + (Y * Y) + (Z * Z));
    return result;

}

Console.WriteLine($"Расстояние между точками равно {Math.Round(SegmentLength(x1, y1, z1,x2, y2, z2), 2)}");
