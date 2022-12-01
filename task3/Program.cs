// Найти сумму чисел от 1 до N

// вариант 1 через цикл
Console.WriteLine(SumFor(12));

int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

// Вариант 2 через рекурсию
Console.WriteLine(SumRecursiv(11));

int SumRecursiv(int n)
{
    if (n == 0) return 0; // условние выхода из рекурсии (метода)
    else return n + SumRecursiv(n - 1);
}
