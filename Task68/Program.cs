/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int numberM = ReadInt("Введите M: ");
int numberN = ReadInt("Введите N: ");
Console.Write($"m = {numberM}, n = {numberN} -> A(m, n) = ");
Console.Write(AkkermanFunction(numberM, numberN));

int AkkermanFunction (int m, int n)
{
    if(m > 0 && n == 0)
        return AkkermanFunction(m -1, 1);
    if( m > 0 && n > 0)
        return AkkermanFunction(m - 1, AkkermanFunction(m, n-1));
    return n+1;
} 







int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}