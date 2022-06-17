// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли 
//заданное число в массиве. 4; массив [6, 7, 19, 345, 3] -> нет 
//3; массив [6, 7, 19, 345, 3] -> да
int[] arr = new int[5];
int num = 4;

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(1, 6);
    }
}
void PrintArray(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        Console.Write(nums[i] + " ");
    }
}

void IndexOf(int[] array, int find)
{
    int position = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find)
        {
            position = i;
            break;            
        }        

    }
    if(position == -1) Console.WriteLine($"Числа {find} нет в заданном массиве");
    else Console.WriteLine($"Число {find} есть в заданном массиве, позиция {position}");

}

FillArray(arr);
PrintArray(arr);
Console.WriteLine();
IndexOf(arr,num);

