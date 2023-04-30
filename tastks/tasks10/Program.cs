// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// Не решил задачку

int number = new Random(). Next(100,1000);
System.Console.WriteLine($"Трехзначное случайное число {number}" );
int ic = number/100;
int j = number % 10;
int result = ic/10-j;
System.Console.WriteLine($"Results {result}" );
