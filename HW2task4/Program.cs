//По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите число 1 ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2 ");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    if (num1 == num2 * num2)
    {
        Console.WriteLine(num1 + " Являеться квадратом числа " + num2);
    }
    else
    {
        Console.WriteLine(num1 + " Не являеться квадратом числа " + num2);
    }
}
else
{
    if (num2 == num1 * num1)
    {
        Console.WriteLine(num2 + "  Являеться квадратом числа " + num1);
    }
    else
    {
        Console.WriteLine(num2 + "  Не являеться квадратом числа " + num1);
    }
}
