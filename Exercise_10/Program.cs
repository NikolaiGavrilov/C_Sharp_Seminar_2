//Задача 10: Напишите программу, которая 
//принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число:");
int yourNum = Convert.ToInt32(Console.ReadLine());
int secondDigit = 0;
if (yourNum > 99 && yourNum < 999 || yourNum < -99 && yourNum > -999)
{
    yourNum = yourNum / 10;
    secondDigit = yourNum % 10;
    if (secondDigit < 0)
    {
        secondDigit = secondDigit * (-1);
    }
    Console.WriteLine("Вторая цифра числа: " + secondDigit);
}
else
{
    Console.WriteLine("Введено некорректное число.");
    Console.WriteLine("Попробуйте перезапустить программу и ввести ТРЕХЗНАЧНОЕ число.");
}