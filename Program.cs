Console.WriteLine("Введите число 1: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int num3 = int.Parse(Console.ReadLine());
if (num > num2)
{
    if (num > num3)
    {
        Console.Write(num);
    }
else
{
    Console.Write(num3);
}
}
else if (num2 > num3)
{
    Console.Write(num2);
}
else
{
    Console.Write(num3);
}
