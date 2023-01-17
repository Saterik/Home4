//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
{
    int sum = 0;
    int temp = 0;
    while (number > 0)
    {
        temp = number % 10;
        sum = sum + temp;
        number = number / 10;
    }
    Console.WriteLine($"Сумма чисел числа равна -> {sum}");
}