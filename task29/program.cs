//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
int  size, i, num_ar;
Console.WriteLine("Введите размер массива:");
size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
for (i = 0; i < size; i++)
{
    Console.WriteLine("Введите что число добавить в массив:");
    num_ar = Convert.ToInt32(Console.ReadLine());
    array [i] = num_ar;
}
foreach (int array_new in array )
{
    Console.Write($"{array_new} ");
}