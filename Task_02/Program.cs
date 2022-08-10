// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7

int Prompt(string message)
{
    System.Console.Write(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}
int value_01 = Prompt("Введите первое число -> ");
int value_02 = Prompt("Введите второе число -> ");
int value_03 = Prompt("Введите третье число -> ");

int Value_max = value_01;
if (value_02 > Value_max)
{
Value_max = value_02;    
}
if (value_03 > Value_max)
{
Value_max = value_03;   
}
System.Console.Write($"Max = {Value_max} ");
