// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
int Prompt(string message)
{
    System.Console.Write(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}
int value_01 = Prompt("Введите положительное целое число -> ");
if (value_01 < 2)
{
    System.Console.Write("Недопустимо маленькое значение");
}
else
{
    for (int count = 2; count <= value_01; count = count + 2)
    {
        System.Console.Write(count + ", ");
    }
}
