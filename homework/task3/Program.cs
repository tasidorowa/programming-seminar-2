﻿// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

int num = 87;

if (num >= 10 && num <= 99)
{
    if (num / 10 > num % 10)
    {
        Console.Write("наибольшая цифра = " + num / 10);
    }
    else
    {
        Console.Write("наибольшая цифра = " + num % 10);
    }
}
else
{
    Console.Write("число не двухзначное");
}