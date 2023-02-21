

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("input number");
bool is_digit = false;


string input()
{
    string? strNum = Convert.ToString(Console.ReadLine());
    if (strNum.All(char.IsDigit))
    {
        is_digit = true;
        return strNum;
    }
    else
    {
        return "Not Digit";
    }
}


int sumNum(string strNum)
{
    int sum = 0;
    if (is_digit)
    {
        for (int i = 0; i < strNum.Length; i++)
        {
            sum = sum + Convert.ToInt32(strNum[i]) - 48;
        }
        return sum;
    }
    else
    {
        return -1;
    }
}


void Show(int num)
{
    Console.WriteLine($"сумма цифр в числе :{num}");
}


Show(sumNum(input()));