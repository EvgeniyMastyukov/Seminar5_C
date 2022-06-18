//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных
//позициях. [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0

void FillArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1, 10);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
Console.WriteLine("Введите размер массива: ");
int num = int.Parse(Console.ReadLine());

int[] arr = new int[num];
FillArray(arr);
PrintArray(arr);
int FindSumUnevenIndex(int[] nums)
{
    int sum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (i % 2 ==1)
        {
            sum = sum + nums[i];
        }
    }
    return sum;
}
int res = FindSumUnevenIndex(arr);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {res}");