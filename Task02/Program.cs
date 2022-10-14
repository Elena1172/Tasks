// See https://aka.ms/new-console-template for more information
Console.Write("Введите число a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b: ");
double b = Convert.ToDouble(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Число a больше числа b.");
}
else if (b > a)
{
    Console.WriteLine("Число b больше числа a.");
}
else
{
    Console.WriteLine("Число a равно числу b.");
}