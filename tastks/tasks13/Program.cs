// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Артем, я пытался, опять логики не хватило. Нужна помощь в разборе.

int[] number = new int[4];
number[0] = Convert.ToInt32(Console.ReadLine());
number[1] = Convert.ToInt32(Console.ReadLine());
number[2] = Convert.ToInt32(Console.ReadLine());
number[3] = Convert.ToInt32(Console.ReadLine());
number[4] = Convert.ToInt32(Console.ReadLine());

if (number[2])
{
    System.Console.WriteLine("Выводит 3ю цифру");
}
else
{
    System.Console.WriteLine("Трерьей цифры нет");
}
