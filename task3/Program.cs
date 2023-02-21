// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите длину массива ");

int lenArr()
{
    int len = Convert.ToInt32(Console.ReadLine());
    return len;
}

int[] createArr(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++){
        arr[i] = new Random().Next(0,100);
    }
    return arr;
}

void show(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"[{arr[i]}] ");
    }
}

show(createArr(lenArr()));
