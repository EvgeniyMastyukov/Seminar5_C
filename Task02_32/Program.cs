// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на
//соответствующие отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] arr = new int[4];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-4, 5);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
Console.WriteLine("Заменим знак элемента массива на противоположный:");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = -arr[i];
    Console.Write($"{arr[i]} ");
}