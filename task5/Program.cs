// вычислить а в степени n

// вариант 1 через цикл

Console.WriteLine(PowerFor(2, 10));
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

// вариант 2 через рекурсию

Console.WriteLine(PowerRecurciv(2, 10));
int PowerRecurciv(int a, int n)
{
    if(n == 0) return 1;
    else return PowerRecurciv(a, n - 1) * a;
}

// вариант 2 через рекурсию укороченная запись с помощью тернального оператора
Console.WriteLine(PowerRecur(2, 10));
int PowerRecur(int a, int n)
{
    return n == 0 ? 1 : PowerRecur(a, n - 1) * a;
}

Console.WriteLine(PowerRecMath(2, 10));

// вариант 3 через рекурсию с учетом мат формул a в степени n = a*a в стерени n/2
int PowerRecMath(int a, int n)
{
    if(n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n /2);
    else return PowerRecMath(a, n - 1) * a;
}
