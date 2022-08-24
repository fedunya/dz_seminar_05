// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateArrayRandom(int length, int max)
{
    double[] array = new double[length];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(random.NextDouble() * max, 3);
    }
    return array;
}

void PrintArray(double[] array)
{
    int length = array.Length;
    Console.Write($"[{array[0]}");
    for (int i = 1; i < length; i++)
    {
        Console.Write($", {array[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}

void MaxMinusMinElements(double[] array, out double max, out double min)
{
    min = array[0];
    max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        if (max < array[i])
        {
            max = array[i];
        }
    }    
}

Console.Write("Введите размер массива: ");
int lengthArray = int.Parse(Console.ReadLine()!);
var arr = CreateArrayRandom(lengthArray, 10);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
double maxElement, minElement;
MaxMinusMinElements(arr, out maxElement, out minElement);
Console.WriteLine("Max элемент массива: " + maxElement);
Console.WriteLine("Min элемент массива: " + minElement);
double result = Math.Round(maxElement - minElement, 3);
Console.WriteLine();
Console.WriteLine("Разница между max и min элементами: " + result);
