//Показать четные числа от 1 до N
Console.WriteLine("Введите число до которого показывать четные числа : ");
int num = int.Parse(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
    if(i%2==0)
    {
        Console.Write(i + " ");
    }
}