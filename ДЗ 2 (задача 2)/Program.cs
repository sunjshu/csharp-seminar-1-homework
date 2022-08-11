Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
bool aIsBigger = a>b ;
Console.WriteLine($"MAX { (a > b ? a : b) },MIN {(a < b ? a : b) }");
