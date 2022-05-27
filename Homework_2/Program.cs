/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int GetSumnOddNumbers(int[] array)
{ 
    int sum = 0;
    for (int i = 0; i < array.Length; i++){
        if (i % 2 != 0)
            sum += array[i];
    }
return sum;
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

int SumnOddNum = GetSumnOddNumbers(arr);

Console.WriteLine();
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях в массиве: {SumnOddNum}");