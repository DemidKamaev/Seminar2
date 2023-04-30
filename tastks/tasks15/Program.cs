// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// Здесь почти решил, что-то где-то с логикой не то

System.Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 5);
{
    System.Console.WriteLine("Нет");
}   
else if (num < 7)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}
