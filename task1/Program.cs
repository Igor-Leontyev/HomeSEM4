// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.WriteLine("input number");
int step(int[] arr)
{
    int result = arr[0];
    for (int i = 2; i <= arr[1]; i++)
    {
        result = arr[0] * result;
    }
    Console.WriteLine(result);
    return result;
}

int[] input()
{
    int[] arr = new int[2];
    arr[0] = Convert.ToInt32(Console.ReadLine());
    arr[1] = Convert.ToInt32(Console.ReadLine());

    return arr;
}
step(input());
