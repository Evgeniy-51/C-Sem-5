// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int[] arr = new int[10];
Random rnd = new Random();
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100, 999);
    if (arr[i] % 2 == 0) count++;
}

System.Console.WriteLine(String.Join(",  ", arr));
System.Console.WriteLine("Четных чисел " + count);
