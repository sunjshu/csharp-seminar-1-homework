Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());
int max;
if (a > b)
{
    max = a;
}
else
{
    max = b;
}

if (max < c)
{
    max = c;
};
Console.WriteLine($" {max} ");