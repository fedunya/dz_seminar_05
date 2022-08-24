// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRandom(int length, int min, int max)
{
    int[] array = new int[length];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
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

int CountEvenNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

Console.Write("Введите размер массива: ");
int lengthArray = int.Parse(Console.ReadLine()!);
var arr = CreateArrayRandom(lengthArray, 100, 1000);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("Количество четных чисел в массиве: " + CountEvenNumbers(arr));
