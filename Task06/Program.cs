// программа определяет введенное пользователем число является 
//четным либо нечетным
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0){
    Console.Write($"Число {number} четное.");
}
else{
    Console.Write($"Число {number} нечетное.");
}
