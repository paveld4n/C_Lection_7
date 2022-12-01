// Собрать строку с числами от a до b, a<=b

// Вариант 1 Через цикл
/*Console.Write(NumbersFor(1, 10));

string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}
*/
// вариант 2 Через рекурсию

Console.Write(NembersRecursiv(1, 15));

string NembersRecursiv(int a, int b)
{
    if(a < b) return $"{a} " + NembersRecursiv(a + 1, b);
    else return String.Empty; // необходимо указать условия выхода из метода
}