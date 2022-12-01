// Собрать строку с числами от a до b, a>=b (от большего к меньшему)

// Вариант 1 Через цикл

Console.Write(NumbersFor(10, 1));

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}

// вариант 2 Через рекурсию
Console.WriteLine();

Console.Write(NembersRecursiv(1, 15));

string NembersRecursiv(int a, int b)
{
    if(a <= b) return NembersRecursiv(a + 1, b) + $"{a} ";
    else return String.Empty; // необходимо указать условия выхода из метода
}
