Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
bool even = (a % 2) == 0;
if (even == true) Console.WriteLine($"{a} четное");
if (even == false) Console.WriteLine($"{a} нечетное");
