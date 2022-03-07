// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Выберете в скольких осях будем работать (2/3): ");
int Choice = int.Parse(Console.ReadLine());
switch (Choice)
{
    case 2:

        Console.WriteLine("Введите координыты точки 1 ");
        Console.Write("Введите X ");
        int X1 = int.Parse(Console.ReadLine());
        Console.Write("Введите Y ");
        int Y1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите координыты точки 2 ");
        Console.Write("Введите X ");
        int X2 = int.Parse(Console.ReadLine());
        Console.Write("Введите Y ");
        int Y2 = int.Parse(Console.ReadLine());
        double distance = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
        Console.WriteLine(" Расстояние между точками равно " + distance);
        break;

    case 3:
        Console.WriteLine("Введите координыты точки 1 ");
        Console.Write("Введите X ");
        int XV1 = int.Parse(Console.ReadLine());
        Console.Write("Введите Y ");
        int YV1 = int.Parse(Console.ReadLine());
        Console.Write("Введите Z ");
        int ZV1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите координыты точки 2 ");
        Console.Write("Введите X ");
        int XV2 = int.Parse(Console.ReadLine());
        Console.Write("Введите Y ");
        int YV2 = int.Parse(Console.ReadLine());
        Console.Write("Введите Z ");
        int ZV2 = int.Parse(Console.ReadLine());
        double distanceV = Math.Sqrt(Math.Pow(XV1 - XV2, 2) + Math.Pow(YV1 - YV2, 2) + Math.Pow(ZV1 - ZV2, 2));
        Console.WriteLine(" Расстояние между точками равно " + distanceV);
        break;
        default:
        Console.WriteLine("Введите значение соответствующее 2 или же 3 осям пространства т.е 2 или 3 ");
        break;
}




