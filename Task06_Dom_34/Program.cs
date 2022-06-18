//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

void FillArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(100, 1000);
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

int FindEvenNum(int[] nums)
{
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}
int result = FindEvenNum(arr);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве = {result}");