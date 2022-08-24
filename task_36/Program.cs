// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumUnevenElements(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        result = result + array[i];
    }
    return result;
}


Console.Write("Введите размер массива: ");
int lengthArray = int.Parse(Console.ReadLine()!);
var arr = CreateArrayRandom(lengthArray, -99, 100);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("Сумма нечетных элементов массива: " + SumUnevenElements(arr));
