// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

int N = 60;
int N2 = N;
int prod = 1;

while (N2 > 10)
{
    N2 /= 10;
    prod *= 10;
}

while (prod >= 1)
{
    if (prod != 1) Console.Write(N / prod + ",");
    else Console.Write(N / prod);
    N %= prod;
    prod /= 10;
}

