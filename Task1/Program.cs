// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Задайте значение N");
int N = Convert.ToInt32(Console.ReadLine());
int end = 1;
string Recurs (int N, int end)
{
  if (N==end)
   {
     return N.ToString();
    
   }
    return (N +","+ Recurs(N-1,end));
}
Console.Write(Recurs(N,end));