// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> Четное

int Prompt(string message)
{
    System.Console.Write(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}
int value_01 = Prompt("Введите число -> ");

if ((value_01 % 2) == 0)
{
    System.Console.Write("Вы ввели четное число");
}
else
{
    System.Console.Write("Вы ввели нечетное число");
}