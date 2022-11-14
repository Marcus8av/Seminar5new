/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

System.Console.WriteLine("Введите количество массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(99, 1000);

if(array[i] %2 == 0)
{
count++;
}
}
System.Console.WriteLine($"[{string.Join(", ", array)}]");

System.Console.WriteLine($"Четных чисел в массиве =  {count}");