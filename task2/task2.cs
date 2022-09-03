using System;
// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму четных элементов, стоящих на нечётных позициях (позиция - индекс элемента в массиве).

Console.Clear();

int[] arr = new int[10];
Random rnd = new Random();
int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100);
    if (arr[i] % 2 == 0 && i % 2 != 0) sum += arr[i];
}

System.Console.WriteLine(String.Join(",  ", arr));
System.Console.WriteLine("Сумма чисел " + sum);
