// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Задайте значение M и N");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int FunAkkermana (int m, int n)
{
    if (m==0) return n+1;
    else if (n==0) return FunAkkermana(m-1,1);
    else return FunAkkermana (m-1,FunAkkermana (m,n-1));
}
Console.WriteLine (FunAkkermana(m,n));
