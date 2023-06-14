// Задача 15: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, 
//является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7 || number < 1)
{
    Console.WriteLine("Введено некорректное число, попробуйте снова!");
}
else 
    if (number >= 1 && number <= 5)
    {
        Console.WriteLine("Будний день");
    }
    else
        if (number > 5 && number <= 7)
        {
            Console.WriteLine("Выходной день");
        }