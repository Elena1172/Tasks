// программа находит наибольшее число из трех введенных чисел
Console.WriteLine("Введите три числа:");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
double max = a;
if(b > a){
    max = b;
}
if(c > max){
    max = c;
}
Console.WriteLine($"Наибольшее значение из трех чисел = {max}");