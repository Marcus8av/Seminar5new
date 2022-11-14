/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.*/

System.Console.WriteLine("Введите массив: ");
Random random = new Random();
int a = Convert.ToInt32(Console.ReadLine());
double [] array = new double [a];
double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
array[i] = random.NextDouble()*100;
max = array.Max();
min = array.Min();
}

System.Console.WriteLine( $"[{string.Join(", ", array)}]");
System.Console.WriteLine ($"Максимальное число в массиве = {max}");
System.Console.WriteLine ($"Максимальное число в массиве = {min}");
System.Console.WriteLine($"Разница между макcимальным и минимальным элементом массива = {max - min} ");

/*У меня получилось с вещественными числами, только почему то после запятой 
у меня много цифр и я не могу понять в чем причина и как это можно исправить*/