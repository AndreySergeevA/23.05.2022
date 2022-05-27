/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int[] InitArray(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(-30, 100);
    }

    return arr;
}

void PrintDiffMinMax(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    double difference = arr.Max() - arr.Min();
    Console.WriteLine();
    Console.WriteLine($"Минимальное значение массива: {arr.Min()}, максимальное значение массива: {arr.Max()}");
    Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет: {difference}");
}


Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine());
int[] arr = InitArray(length);

Console.WriteLine("Полученный массив:");
PrintDiffMinMax(arr);

