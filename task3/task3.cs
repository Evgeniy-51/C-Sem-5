// Задача 3*: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

int[] arr = new int[10];
Random rnd = new Random();
int minVal = 1,
    maxVal = 99;
int min = maxVal,
    max = minVal;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(minVal, maxVal);
    if (arr[i] < min) min = arr[i];
    if (arr[i] > max) max = arr[i];
}

System.Console.WriteLine(string.Join(",  ", arr));
System.Console.WriteLine("max =  " + max);
System.Console.WriteLine("min =  " + min);
System.Console.WriteLine("Разность =  " + (max - min));