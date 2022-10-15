/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/


Console.Clear();
Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine(NumberDegree(numberA));

int NumberDegree(int number)
{

int Product = 1;

while(numberB>0)
{
    Product = numberA * Product;
    numberB = numberB-1;

}
return Product;
//Console.WriteLine(Product);
}