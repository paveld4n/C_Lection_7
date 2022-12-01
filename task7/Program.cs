// Игра в пирамидки. переместить блинчики с пирамиды 1 на кторой блины по ваозрастанию на пирамиду 3 с учетом возрастания.

void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
//          исходный шпиль    финальный шпиль  промежуточный шпиль  количество блинчиков
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}
Towers();