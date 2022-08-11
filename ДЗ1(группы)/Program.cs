Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
bool isSquare = b*b ==a ;
if (isSquare==true) Console.WriteLine ("ДА");
if (isSquare==false) Console.WriteLine ("НЕТ");
