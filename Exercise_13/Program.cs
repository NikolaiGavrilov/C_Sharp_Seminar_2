//Задача 13: Напишите программу, которая выводит третью 
//цифру заданного числа или сообщает, что 
//третьей цифры нет.

Console.WriteLine("Введите трехзначное или большее число: ");
int yourNum = Convert.ToInt32(Console.ReadLine());
int thirdDigit = 0;

if (yourNum > 99 || yourNum < -99)
{
    while (yourNum > 999 || yourNum < -999)
    {
        yourNum = yourNum / 10;
    }
    thirdDigit = yourNum % 10;
    Console.WriteLine ("Третья цифра числа - " + thirdDigit);
}
else
{
    Console.WriteLine ("В числе нет третьей цифры");
}

