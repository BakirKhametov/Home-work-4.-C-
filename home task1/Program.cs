/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]
6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]*/

Console.Clear();
int[] array = new int[8];
void array1 (int[] array)
{
int length = array.Length;
for (int i = 0; i < length; i++)
{
    
    
    array[i] = new Random().Next(0,999);
    Console.Write($"{array[i]} | ");


}

}
array1(array);