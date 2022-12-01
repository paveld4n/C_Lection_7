// Вычислить Факториал

// вариант через цикл
Console.WriteLine(FactorialFor(10));

int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

// вариант через рекурсию

Console.WriteLine(FactorialRecursiv(11));

int FactorialRecursiv(int n)
{
    if(n == 1) return 1;
    else return n * FactorialRecursiv(n - 1);
}
