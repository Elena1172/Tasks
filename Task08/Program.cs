// Программа выводит ряд четных чисел от 1 до набранного пользователем числа
Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (number > 0){
    while(count <= number){
        if(count % 2 == 0){
            
            Console.Write(count + " ");
        }
        count ++;
    }

}
else{
    Console.Write("Вы ввели ненатуральное число");
}