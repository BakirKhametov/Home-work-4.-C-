/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(SumNumbers(number));

int SumNumbers (int num)
{
    int Sum = 0;
    while (number>0)
    {
        Sum = (number %10) + Sum;
        number = number/10;
    }
    return Sum;
    //Console.WriteLine(Sum);

}