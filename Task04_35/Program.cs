//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов 
//массива, значения которых лежат в отрезке [10,99]. Пример для массива из 5, а не 123 элементов
//В своём решении сделайте для 123 [5, 18, 123, 6, 2] -> 1  [1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

int[] array = new int[123];
void FilArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1, 150);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int FindCountNums(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 && arr[i] < 100)
        {
            count = count + 1;
        }
    }
    return count;
}

FilArray(array);
PrintArray(array);
Console.WriteLine();
int result = FindCountNums(array);
Console.WriteLine($"Количество элементов массива, лежащих в интерваое [10,99] = {result}");
