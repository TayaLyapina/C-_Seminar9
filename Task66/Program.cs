/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int start = ReadInt("Введите M: ");
int end = ReadInt("Введите N: ");
SumOfNumbers(start, end);

Console.Write($"M = {start}; N = {end} -> ");
Console.Write(SumOfNumbers(start, end));

int SumOfNumbers(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else 
    {
        return n+m+SumOfNumbers(m+1, n-1);
    }
    
}


int ReadInt(string message)
{
Console.Write(message);
return int.Parse(Console.ReadLine());
}