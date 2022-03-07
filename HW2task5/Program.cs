// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Введите коодинаты точки ");
Console.Write("Введите коодинату X  ");
int X = int.Parse(Console.ReadLine());
Console.Write("Введите коодинату Y  ");
int Y = int.Parse(Console.ReadLine());
if (X > 0 && Y > 0)
{
    Console.WriteLine("Точка с координатой " + '(' + X + ',' + Y + ')' + " Находится в 1 четверти");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Точка с координатой " + '(' + X + ',' + Y + ')' + " Находится в 2 четверти");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Точка с координатой " + '(' + X + ',' + Y + ')' + " Находится в 3 четверти");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Точка с координатой " + '(' + X + ',' + Y + ')' + " Находится в 4 четверти");
}
