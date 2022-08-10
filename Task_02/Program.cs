int Prompt(string message)
{
    System.Console.Write(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}
int value_01 = Prompt("Введите первое число -> ");
int value_02 = Prompt("Введите второе число -> ");
if (value_01 > value_02)
{
    System.Console.Write($"Max = {value_01} Min = {value_02}");
}
else
{
    if (value_01 < value_02)
    {
        System.Console.Write($"Max = {value_02} Min = {value_01}");
    }
    else
    {
        System.Console.Write($"Numbers {value_02} and {value_01} are equal");
    }
}