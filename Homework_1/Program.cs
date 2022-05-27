/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int[] InitArray(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

int GetSummFromArray(int[] arr)
{
    int summ = 0;

    foreach (int item in arr)
    {
        if (item % 2 == 0)
            summ += 1;
    }
    return summ;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
        Console.Write($"{item} ");
}

Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine());
int[] arr = InitArray(length);


Console.WriteLine("Полученный массив:");
PrintArray(arr);

int MassiveSumm = GetSummFromArray(arr);

Console.WriteLine();
Console.WriteLine($"Колличество четных чисел: {MassiveSumm}.");
