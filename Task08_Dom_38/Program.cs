//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(double[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1, 100);
    }
}
void PrintArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
Console.WriteLine("Введите размер массива: ");
int number = int.Parse(Console.ReadLine());

double [] arr = new double [number];
FillArray(arr);
PrintArray(arr);
double DiffMaxMin(double [] nums)
{
    int maxPosition = 0;
    int minPosition = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if(nums[i] < nums[minPosition])
        {
            minPosition = i;
        }
        if(nums[i] > nums[maxPosition])
        {
            maxPosition = i;
        }
    }
    double diff = nums[maxPosition] - nums[minPosition];
    return diff;
} 
double res = DiffMaxMin(arr);
Console.WriteLine();
Console.WriteLine($"Разница межу Макс и Мин элементом = {res}");