// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
//последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3 ; [6 7 3 6] -> 36 21

// void FillArray(int[] col)
// {
//     for (int i = 0; i < col.Length; i++)
//     {
//         col[i] = new Random().Next(1, 10);
//     }
// }
// void PrintArray(int[] col)
// {
//     for (int i = 0; i < col.Length; i++)
//     {
//         Console.Write($"{col[i]}  ");
//     }
// }

// int[] array = new int[5];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();

// int size = array.Length;
// int[] arrProduct = new int[size / 2 + size % 2];
// if (size % 2 != 1)
// {
//     for (int i = 0; i < size / 2; i++)
//     {
//         arrProduct[i] = array[i] * array[size - 1 - i];
//         Console.Write($"{arrProduct[i]} ");
//     }
// }
// else
// {
//     for (int i = 0; i < size / 2; i++)
//     {
//         arrProduct[i] = array[i] * array[size - 1 - i];
//         Console.Write($"{arrProduct[i]} ");
//     }
//     arrProduct[size / 2] = array[size / 2];
//     Console.Write($"{arrProduct[size / 2]} ");
// }

void FillArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1, 10);
    }
}
void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]}  ");
    }
}

int[] array = new int[5];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int size = array.Length;
int[] arrProduct = new int[size / 2 + size % 2];
int j = size - 1;
for (int i = 0; i < arrProduct.Length; i++)
{
    if (i == j)
    {
        arrProduct[i] = array[j];
        break;
    }
    arrProduct[i] = array[i] * array[j];
    j--;
}
PrintArray(arrProduct);



