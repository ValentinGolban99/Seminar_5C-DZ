// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[4];
int neverNumber = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
    if (array[i] % 2 == 0) neverNumber++; 
}


Console.WriteLine();
Console.WriteLine($"Кол-во четных чисел = {neverNumber}");




// for (int i = 0; i < array.Length; i++) // array.Length = 10
// {
// array[i] = new Random().Next(10,1000);
// Console.Write(array[i] + " ");
// if (array[i] >= 10 && array[i] <= 99) count++;
// }
// System.Console.WriteLine();
// Console.WriteLine(count);