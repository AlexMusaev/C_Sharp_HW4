// Задание 1. Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Напишите число А:");
int firs_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите число В");
int second_number = Convert.ToInt32(Console.ReadLine());
int result = 1;

for (int i = 1; i < second_number + 1; i++)
{
    result = result*firs_number;
}
Console.WriteLine($"Число {firs_number} в натуральной степени {second_number} получается {result}");

// Задание 2. Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Напишите ваше целое число: ");
int usNumber = Convert.ToInt32(Console.ReadLine());
string sNumbers = usNumber.ToString();
char [] array = sNumbers.ToCharArray();

int index = 0;
int len = array.Length;
int result = 0;

if (usNumber > 0) 
{
    while (index < len)
    {
        string num = array[index].ToString();
        int finNum = Convert.ToInt32(num);
        result = result + finNum;
        index++;
    }
}
else 
{
    index = 1;
    while (index < len)
    {
        string num = array[index].ToString();
        int finNum = Convert.ToInt32(num);
        result = result + finNum;
        index++;
    }
}
Console.WriteLine($"Сумма цифр в вашем числе равна: {result}");


// // Задание 3. Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]

int [] array = new int [8];

int rand = array.Length;

for (int i = 0; i < rand; i++) 
{
    array[i] = new Random().Next(0,100);
    Console.Write($"{array[i]} ");
}

